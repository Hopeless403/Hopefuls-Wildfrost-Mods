using HarmonyLib;
using System.Collections;
using UnityEngine;
using static ActionEffectApply;

namespace WildFlipper
{
    public partial class WildFlipperMod
    {
        public class StatusEffectRetain : StatusEffectData
        {
            public override void Init()
            {
                Events.OnEntityEnterPocket += CheckMove;
            }
            public void OnDestroy()
            {
                Events.OnEntityEnterPocket -= CheckMove;
            }

            public void CheckMove(Entity entity, CardPocket pocket)
            {
                if (entity != target || pocket != target.owner.discardContainer) 
                    return;

                var sequence = new ActionSequence(Redraw(target))
                {
                    note = $"Retaining {target}",
                };
                ActionQueue.Add(sequence);
            }

            public IEnumerator Redraw(Entity entity)
            {
                if (entity.InContainer(entity.owner.handContainer))
                {
                    Debug.LogWarning($"[{entity}] is already in hand! Skipping retain...");
                    yield break;
                }

                if (entity.InContainer(entity.owner.discardContainer))
                {
                    Debug.LogWarning($"Moving [{entity}] to draw container");
                    yield return Sequences.CardMove(entity, new CardContainer[] { entity.owner.drawContainer }, 0);
                }
                if (entity.InContainer(entity.owner.drawContainer))
                {
                    yield return Sequences.CardMove(entity, new CardContainer[] { entity.owner.handContainer });
                    ActionQueue.Add(new ActionReveal(entity), fixedPosition: true);
                    ActionQueue.Add(new ActionRunEnableEvent(entity), fixedPosition: true);

                    Debug.LogWarning($"Retained [{entity}]");
                    yield break;
                }

                Debug.LogError($"[{entity}] couldn't be retained!");
            }
        }
    }
}
