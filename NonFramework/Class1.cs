using Deadpan.Enums.Engine.Components.Modding;
using FMODUnity;
using HarmonyLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Elements = UnityEngine.UIElements;
using static UnityEngine.ParticleSystem;
using static CardData;
using System.Reflection;
using UnityEngine.TextCore.Text;

namespace NonFramework
{
    public interface ICardData
    {
        string Tribe { get; }
        string Type { get; }
        string GetPool() => $"{Tribe}{Type}Pool";
    }
    public interface ISnowdweller : ICardData { string ICardData.Tribe => "Basic"; }
    public interface IShademancer : ICardData { string ICardData.Tribe => "Magic"; }
    public interface IUnit : ICardData { string ICardData.Type => "Unit"; }
    public interface IItem : ICardData { string ICardData.Type => "Item"; }
    public interface ISnowdwellerUnit : ISnowdweller, IUnit { }
    public interface ISnowdwellerItem : ISnowdweller, IItem { }

    public class ASnowUnit : ISnowdwellerUnit
    {
        public override string ToString()
        {
            //GetType().FindInterfaces((t,o) => true, )
            return ((ISnowdwellerUnit)this).GetPool();
        }
    }

    public class Nonfstd : WildfrostMod
    {
        public static Nonfstd instance;

        public static string CatalogFolder
            => Path.Combine(instance.ModDirectory, "Windows");

        public static string CatalogPath
            => Path.Combine(CatalogFolder, "catalog.json");

        public Nonfstd(string modDirectory) : base(modDirectory)
        {
            instance = this;
        }
        public override string GUID => "__hope.wildfrost.nf";
        public override string[] Depends => new string[] { };
        public override string Title => "Net 2.1Std";
        public override string Description => $"{new ASnowUnit()}\nLast update: {Directory.GetLastWriteTime(Assembly.GetExecutingAssembly().Location)}";
        public override TMP_SpriteAsset SpriteAsset => base.SpriteAsset;
        public static GameObject behaviour;


        public override void Load()
        {
            LocalizationHelper.GetCollection("Cards", SystemLanguage.English).SetString("owo", "|Body Text!");
            HelpPanelSystem.Show(LocalizationHelper.GetCollection("Cards", SystemLanguage.English).GetString("owo"));


            if (assets.Count <= 0)
                CreateModAssets();
            base.Load();

            behaviour = new GameObject(Title);
            UnityEngine.Object.DontDestroyOnLoad(behaviour);

        }

        public class StatusEffectFlipDownHoverable : StatusEffectInstant
        {
            public override IEnumerator Process()
            {
                target.OnDisable();
                target.flipper.FlipDown();
                yield return null;
                yield return new WaitUntil(() => target.flipper.isCompleteFired);
                target.data = AddressableLoader.GetCardDataClone("Lump");
                yield return (target.display as Card).UpdateData(true);
                target.flipper.FlipUp();
                yield return base.Process();
            }
        }
        public class TargetModeColumn : TargetMode
        {
            public int index = 0;
            public override Entity[] GetTargets(Entity entity, Entity target, CardContainer targetContainer)
            {
                HashSet<Entity> list = new HashSet<Entity>();
                list.AddRange(entity.GetAllEnemies().Where(e => e && e.enabled && e.alive && e.canBeHit && CheckSlot(e, index)));
                return list.Count <= 0 ? null : list.ToArray();
            }
            public override Entity[] GetPotentialTargets(Entity entity, Entity target, CardContainer targetContainer)
            {
                return GetTargets(entity, target, targetContainer);
            }
            public override Entity[] GetSubsequentTargets(Entity entity, Entity target, CardContainer targetContainer)
            {
                return GetTargets(entity, target, targetContainer);
            }
            public bool CheckSlot(Entity entity, int index = 0)
            {
                foreach (CardContainer row in References.Battle.GetRows(entity.owner))
                {
                    if (!(row is CardSlotLane lane))
                        continue;
                    // the row is a proper lane of cards

                    if (lane.slots.Count <= index)
                        continue;

                    CardSlot rowSlot = lane.slots[index];
                    if (entity.actualContainers.Contains(rowSlot))
                        return true;
                }
                return false;
            }
        }


        public class StatusEffectCombineAllies : StatusEffectInstant
        {
            /// <summary>
            /// Leave null to combine into the owner
            /// </summary>
            public CardData combineInto;

            public override IEnumerator Process()
            {
                Entity resultEntity;
                if (!combineInto)
                    resultEntity = target;
                else
                    resultEntity = CardManager.Get(combineInto, target.display.hover.controller, target.owner, false, target.owner == Battle.instance.player).entity;

                //ActionQueue.Stack(new ActionCombine([.. target.GetAllAllies(), resultEntity]), true);
                yield return CombineSystem.Combine(target, resultEntity);
                yield return base.Process();
            }
        }



        private void CreateModAssets(bool forRelease = true)
        {
            assets.Add(new CardDataBuilder().CreateUnit("owo", "OWO"));
        }

        public List<object> assets = new List<object>()
        {
            //Builders.cardData.CreateUnit("uwu","uwu"),
            //(new Scriptable<CardData>() as CardDataBuilder)
        };



        public override List<T> AddAssets<T, Y>()
        {
            if (assets.OfType<T>().Any())
                Debug.LogWarning($"[{Title}] adding {typeof(Y).Name}: {assets.OfType<T>().Select(d => Path.GetExtension(d._data.name)).Join()}");
            return assets.OfType<T>().ToList();
        }

        public override void Unload()
        {
            
            _ = new CardScript[] { new Scriptable<CardScriptMultiplyAttack>(s =>
                {
                    s.multiply = 2.5f;
                    s.roundUp = true;
                })
            };
            base.Unload();
            UnityEngine.Object.Destroy(behaviour);
            behaviour = null;
        }
        public class CardScriptMultiplyAttack : CardScript
        {
            public float multiply;
            public bool roundUp;

            public override void Run(CardData target)
            {
                target.damage = this.roundUp ? Mathf.CeilToInt(target.damage * this.multiply) : Mathf.RoundToInt(target.damage * this.multiply);
                target.damage = Mathf.Max(1, target.damage);
                new Scriptable<CardScriptAddAttackEffect>()
                {
                    
                };
            }
        }
        public class Scriptable<T> where T : ScriptableObject, new()
        {
            const string credit = "Credit to Hopeful";
            readonly Action<T> modifier;
            public Scriptable() { }
            public Scriptable(Action<T> modifier) { this.modifier = modifier; }
            public static implicit operator T(Scriptable<T> scriptable)
            {
                T result = ScriptableObject.CreateInstance<T>();
                scriptable.modifier?.Invoke(result);
                return result;
            }
        }
    }

    public static class Builders
    {
        public static CardDataBuilder cardData 
            => Nonfstd.instance == null 
            ? new CardDataBuilder()
            : new CardDataBuilder(Nonfstd.instance);
    }
}