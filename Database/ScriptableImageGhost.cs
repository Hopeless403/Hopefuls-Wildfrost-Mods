using UnityEngine;
using UnityEngine.UI;

namespace WildfrostHopeMod.MapleFrost
{
    // Ensures that the GameObject (prefab) this is attached to will have an Image component
    // If it doesn't already have one, an Image will be added
    [RequireComponent(typeof(Image))]
    public class ScriptableImageBase : ScriptableCardImage
    {
        public Image image => GetComponent<Image>();

        // if you want, you can have multiple sprites depending on the situation
        //public Sprite[] sprites; // similar to Storm Globe

        // for this example we want to show single alternate sprite in a nice situation
        //public virtual Sprite altSprite; // set on demand

        public void Start()
        {
            // Set the GameObject's size to the card size 
            GetComponent<RectTransform>().sizeDelta = new Vector2(3.8f, 5.7f);
            // The image will try to autofill to fit the RectTransform size
            image.preserveAspect = true;
            // This fixes the card being hoverable
            image.raycastTarget = false;
        }

        // gets called when the Entity display is created
        public override void AssignEvent()
        {
            // we use the CardData's main sprite for a backup here
            // otherwise it won't have any sprite
            image.sprite = this.entity.data.mainSprite;
        }

        // gets called after UpdateDisplay is called
        public override void UpdateEvent()
        {

        }
    }

    public class ScriptableImageGhost : ScriptableImageBase
    {
        public Sprite altSprite;
        public override void UpdateEvent()
        {
            Debug.LogWarning("Update event triggered");
            var num = Mathf.Max(0, this.entity.hp.current);
            var den = Mathf.Max(1, this.entity.hp.max);
            Debug.LogWarning($"Health is at {num}/{den}");

            // set the card's opacity to the percentage of its health remaining
            (this.entity.display as Card).canvasGroup.alpha = Mathf.Clamp((float)num / (float)den, 0, 1);

            // change the sprite depending on what's happening now
            if (this.entity.hp.current == 69 && altSprite != null)
                image.sprite = altSprite;
            else
                image.sprite = this.entity.data.mainSprite;
        }
    }

}
