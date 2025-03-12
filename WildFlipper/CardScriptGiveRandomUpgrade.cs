using NaughtyAttributes;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using UnityEngine;
using UnityEngine.AddressableAssets;


namespace WildFlipper
{
    public partial class WildFlipperMod
    {
        public class CardScriptGiveRandomUpgrade : CardScript
        {
            public bool fromPool = false;
            [ShowIf(nameof(fromPool))]
            public CardUpgradeData[] upgradePool;


            [HideIf(nameof(fromPool))]
            public int? minTier = 0;
            public int? maxTier = null;

            public CardUpgradeData.Type ofType = CardUpgradeData.Type.Charm;
            public string[] illegalUpgrades = ["CardUpgradeMuncher", "CardUpgradeEffigy"];

            public override void Run(CardData target)
            {
                IEnumerable<CardUpgradeData> possibleUpgrades = [];
                if (fromPool)
                {
                    possibleUpgrades = upgradePool?.Where(u => u.CanAssign(target));
                }
                else
                {
                    possibleUpgrades = AddressableLoader.GetGroup<CardUpgradeData>(nameof(CardUpgradeData))
                        .Where(u
                        => u.type == ofType 
                        && (!minTier.HasValue || u.tier >= minTier)
                        && (!maxTier.HasValue || u.tier <= maxTier)
                        && !(illegalUpgrades == null && illegalUpgrades.Contains(u.name))
                        );
                }

                if (possibleUpgrades == null)
                    return;

                Entity targetedEntity = GameObject.FindObjectsOfType<Entity>().FirstOrDefault(e => e.data == target);
                CardUpgradeData chosenUpgrade = possibleUpgrades.InRandomOrder().First().Clone();

                if (targetedEntity != null)
                    chosenUpgrade.Assign(targetedEntity);
                else chosenUpgrade.Assign(target);
                _ = typeof(AssetReference);
                new AssetReference("Assets/Content/Campaign/Presets/preset1 press demo.txt");
                new AssetReferenceGameObject("Assets/Content/Campaign/Presets/preset1 press demo.txt");
            }
        }
    }
}


