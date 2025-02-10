using Deadpan.Enums.Engine.Components.Modding;
using System.Collections.Generic;
using UnityEngine;

namespace Merriweather
{
    public partial class MerriweatherMod
    {
        internal class Antumbra
        {
            public const string AntumbraName = "Antumbra";
            public const string InkToRandomEnemy = "On Card Played Apply Ink To RandomEnemy";
            public const string InkToAllyBehind = "On Card Played Apply Ink To AllyBehind";
            public const string WhileInkdTransformPenumbraName = "While Umbra Is Inked Transform Into Penumbra";

            public List<object> GetAssets()
            {
                List<object> assets = [
                    new CardDataBuilder(instance)
                        .CreateUnit(AntumbraName, AntumbraName, bloodProfile:"Blood Profile Black")
                        
                        .SubscribeToAfterAllBuildEvent(d => {
                            d.startWithEffects = [
                                instance.CreateEffectStack(InkToAllyBehind,3),
                                instance.CreateEffectStack(WhileInkdTransformPenumbraName,1)
                                ];
                        })
                    ,
                    instance.StatusCopy(InkToRandomEnemy, InkToAllyBehind)
                        .FreeModify<StatusEffectApplyXOnCardPlayed>(s => 
                        {
                            s.applyToFlags = StatusEffectApplyX.ApplyToFlags.AllyBehind;
                            s.textKey = LocalizationHelper
                                .GetCollection("Card Text", SystemLanguage.English)
                                .GetString("Apply X to ally behind");
                        })
                        .WithTextInsert("<keyword=null>")
                    ,

                    instance.StatusCopy(InkToRandomEnemy, InkToAllyBehind)
                        .FreeModify<StatusEffectApplyXOnCardPlayed>(s =>
                        {
                            s.applyToFlags = StatusEffectApplyX.ApplyToFlags.AllyBehind;
                            s.textKey = LocalizationHelper
                                .GetCollection("Card Text", SystemLanguage.English)
                                .GetString("Apply X to ally behind");
                        })
                        .WithTextInsert("<keyword=null>")
                    ,



                    new StatusEffectDataBuilder(instance)
                        .Create<StatusEffectSummon>(WhileInkdTransformPenumbraName)
                        .FreeModify(
                            s => s.textKey = 
                                LocalizationHelper.GetCollection("Card Text", SystemLanguage.English)
                                .GetString("Summon X")
                            )
                        .WithTextInsert()
                    ,
                    ];
                return assets;
            }
        }
    }
}
