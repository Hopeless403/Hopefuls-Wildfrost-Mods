using Deadpan.Enums.Engine.Components.Modding;
using Steamworks;
using System.Collections.Generic;
using UnityEngine;

namespace Merriweather
{
    public partial class MerriweatherMod
    {
        internal class Umbra
        {
            public const string UmbraName = "Umbra";
            public const string SummonAntumbraName = "When Deployed Summon Antumbra (Once Per Combat)";

            public List<object> GetAssets()
            {
                new Achievement("owo").Trigger();
                SteamUserStats.
                List<object> assets = [
                    new CardDataBuilder(instance)
                        .CreateUnit(UmbraName, UmbraName, bloodProfile:"Blood Profile Black")
                        .SetStats(7,1,4)
                        .SetAttackEffect(instance.CreateEffectStack("Null",1))
                        .SetTraits(instance.CreateTraitStack("Barrage", 1))
                        .AddPool()
                        .SubscribeToAfterAllBuildEvent(d => {
                            d.startWithEffects = [
                                instance.CreateEffectStack(SummonAntumbraName,1)
                                ];
                        })
                    ,
                    new StatusEffectDataBuilder(instance)
                        .Create<StatusEffectSummon>(SummonAntumbraName)
                        .FreeModify(
                            s => s.textKey = 
                                LocalizationHelper.GetCollection("Card Text", SystemLanguage.English)
                                .GetString("Summon X")
                            )
                        .WithTextInsert($"<card={Extensions.PrefixGUID(Antumbra.AntumbraName, instance)}>")
                        .SubscribeToAfterAllBuildEvent(d => {
                            var s = d as StatusEffectSummon;
                            s.summonCard = instance.Get<CardData>(Antumbra.AntumbraName);
                        })
                    ];
                return assets;
            }
        }
    }
}
