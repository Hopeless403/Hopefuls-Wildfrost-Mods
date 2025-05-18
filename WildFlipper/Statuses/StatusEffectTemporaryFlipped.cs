using System.Collections;
using UnityEngine;

public class StatusEffectTemporaryFlipped : StatusEffectData
{
    private bool active;
    private CardHover addedHover;

    public override bool HasStackRoutine => true;
    //public override bool HasEndRoutine => true;

    public override IEnumerator StackRoutine(int stacks)
    {
        if (active || target.display is not Card card) yield break;

        // Temporarily flip the back image before we flip it for real
        float y = card.backGroup.transform.localEulerAngles.y;
        card.backGroup.transform.localEulerAngles = card.backGroup.transform.localEulerAngles.WithY(y + 180);

        target.flipper.FlipDown(force: true);

        yield return null; // Wait one frame for the flipper's Update(). Maybe not necessary?
        yield return new WaitUntil(() => target.flipper.isCompleteFired);

        // Flip the flipper so PointerEnter events work
        target.flipper.transform.localEulerAngles = target.flipper.transform.localEulerAngles.WithY(0);
        card.backGroup.transform.localEulerAngles = card.backGroup.transform.localEulerAngles.WithY(y);

        // Hacky way to force the CardHover's CanHover property
        target.flipper.flipped = false;

        // Add a CardHover component so its hoverable
        addedHover = GameObject.Instantiate(target.flipper.hover, card.backGroup.transform);

        active = true;
        yield break;
    }

    /*public override IEnumerator EndRoutine()
    {
        if (active)
        {
            target.flipper.transform.localEulerAngles = target.flipper.transform.localEulerAngles.WithY(180f);
            target.flipper.flipped = true;
            target.flipper.FlipUp();
        }
        if (addedHover)
        {
            addedHover.Destroy();
        }
        yield break;
    }*/
}