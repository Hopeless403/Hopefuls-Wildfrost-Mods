using System.Linq;
using UnityEngine;

namespace WildfrostHopeMod.KeyboardSupport
{
    public class FixScrollingOverTooManyCards : MonoBehaviour
    {
        public readonly string[] layersToFix = ["CardHand"];
        public UINavItemState previousState;
        public void Update()
        {
            if (References.Player?.discardContainer && References.Player?.drawContainer)
            {
                References.Player.discardContainer.nav.enabled = Battle.instance;
                References.Player.drawContainer.nav.enabled = Battle.instance;
            }

            if (!Battle.instance || !UINavigationSystem.instance.NavigationLayers.Select(l => l.name)
                .Intersect(layersToFix).Any()) return;

            if (References.Player?.discardContainer && References.Player?.drawContainer)
            {
                References.Player.discardContainer.nav.selectionPriority = UINavigationItem.SelectionPriority.Mega;
                References.Player.drawContainer.nav.selectionPriority = UINavigationItem.SelectionPriority.Mega;
            }

            UINavigationItem currentItem = UINavigationSystem.instance.currentNavigationItem;

            if (currentItem != previousState.lastItem)
            {
                previousState.Restore();
                if (References.Player?.discardContainer)
                {
                    References.Player.discardContainer.nav.selectionPriority = UINavigationItem.SelectionPriority.Highest;
                    References.Player.drawContainer.nav.selectionPriority = UINavigationItem.SelectionPriority.Highest;
                }
            }
            if (!layersToFix.Contains(currentItem?.transform.parent.name)) return;
            if (currentItem != previousState.lastItem)
            {
                previousState = new(currentItem);
                if (References.Player?.discardContainer)
                {
                    References.Player.discardContainer.nav.selectionPriority = UINavigationItem.SelectionPriority.Mega;
                    References.Player.drawContainer.nav.selectionPriority = UINavigationItem.SelectionPriority.Mega;
                }
            }
            // should rotate the card hand if too big

            var index = currentItem.transform.GetSiblingIndex();
            var parent = currentItem.transform.parent;
            if (index == 0 || index == parent.childCount - 1)
                return;

            currentItem.overrideInputs = true;
            currentItem.inputLeft = parent.GetChild(index + 1).GetComponent<UINavigationItem>();
            currentItem.inputRight = parent.GetChild(index - 1).GetComponent<UINavigationItem>();
        }

        public struct UINavItemState
        {
            public readonly UINavigationItem lastItem;
            public bool overrideInputs = false;
            public UINavigationItem inputLeft;
            public UINavigationItem inputRight;
            public UINavigationItem inputUp;
            public UINavigationItem inputDown;

            public UINavItemState(UINavigationItem item)
            {
                lastItem = item;
                overrideInputs = item?.overrideInputs ?? false;
                inputLeft = item?.inputLeft;
                inputRight = item?.inputRight;
                inputUp = item?.inputUp;
                inputDown = item?.inputDown;
            }
            public void Restore()
            {
                if (!lastItem) return;
                lastItem.overrideInputs = overrideInputs;
                lastItem.inputLeft = inputLeft;
                lastItem.inputRight = inputRight;
                lastItem.inputUp = inputUp;
                lastItem.inputDown = inputDown;
            }
        }

    }
}