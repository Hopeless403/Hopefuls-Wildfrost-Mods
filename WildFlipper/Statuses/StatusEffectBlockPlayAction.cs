using HarmonyLib;
using System;
using System.Data;
using System.Linq;
using UnityEngine;


namespace WildFlipper
{
    public partial class WildFlipperMod
    {
        public class StatusEffectBlockPlayAction : StatusEffectData
        {
            public string[] actionsNamesToBlock = new string[0];
            private Type[] actionsTypesToBlock => actionsNamesToBlock.Select(AccessTools.TypeByName).ToArray();


            public override void Init()
            {
                Events.OnCheckAction += CheckAction;
            }
            public void OnDestroy()
            {
                Events.OnCheckAction -= CheckAction;
            }

            public void CheckAction(ref PlayAction action, ref bool allowed)
            {
                Debug.LogWarning(action);
                if (actionsNamesToBlock == null)
                    return;

                Debug.LogWarning(actionsNamesToBlock.Length);
                if (actionsNamesToBlock.Any())
                    Debug.LogWarning(actionsNamesToBlock.Join());

                foreach (var name in actionsNamesToBlock)
                {
                    Debug.LogWarning("THIS IS " + name);
                    Type type = AccessTools.TypeByName(name);

                    if (type != null && type.IsAssignableFrom(action.GetType()))
                    {
                        Debug.LogError("WE GOTEM");
                        allowed = false;
                    }
                }

                Debug.LogError("ACTION IS " + allowed);
            }

        }
    }
}


