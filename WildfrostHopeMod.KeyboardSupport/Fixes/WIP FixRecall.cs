using UnityEngine;

namespace WildfrostHopeMod.KeyboardSupport
{
    public class FixRecall : MonoBehaviour
    {
        bool fix = false;
        public void Update()
        {
            if (!Battle.instance?.player)
                return;
            else if (Battle.instance.playerCardController.dragging)
                foreach (var slot in (Battle.instance.GetRow(Battle.instance.player, 1) as CardSlotLane).slots)
                {
                    if (!slot.nav) continue;
                    slot.nav.overrideInputs = true;
                    slot.nav.inputDown = Battle.instance.player.drawContainer?.nav;
                    fix = true;
                }
            else if (fix)
                foreach (var slot in (Battle.instance.GetRow(Battle.instance.player, 1) as CardSlotLane).slots)
                {/*
                    slot.nav.overrideInputs = false;
                    slot.nav.inputDown = null;*/
                    fix = false;
                }
        }
    }
}