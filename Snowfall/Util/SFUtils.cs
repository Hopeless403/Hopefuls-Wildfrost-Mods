// Decompiled with JetBrains decompiler
// Type: Snowfall2.Util.SFUtils
// Assembly: Snowfall, Version=0.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 26AFE777-3FAB-4D6F-AF6C-494837402D4A
// Assembly location: C:\Users\harri\AppData\Local\Temp\Temp1_Snowfall_-_Alpha_2.1.2.zip\Snowfall.dll

using Deadpan.Enums.Engine.Components.Modding;
using HarmonyLib;
using Snowfall2.Classes.ScriptableAmounts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.Experimental.Rendering;

namespace Snowfall2.Util
{
  public static class SFUtils
  {
    private static readonly Dictionary<string, Sprite> SpriteCache = new Dictionary<string, Sprite>();

    public static CardData.TraitStacks CreateTraitStacks(
      string dataName,
      int stacks,
      WildfrostMod mod)
    {
      return new CardData.TraitStacks(mod.Get<TraitData>(dataName), stacks);
    }

    public static CardData.StatusEffectStacks CreateSEStacks(
      string dataName,
      int stacks,
      WildfrostMod mod)
    {
      return new CardData.StatusEffectStacks(mod.Get<StatusEffectData>(dataName), stacks);
    }

    public static T CreateScriptableAmount<T>(
      int amount = 0,
      float factor = 1f,
      string statusType = "snow",
      int offset = 0,
      ScriptableDeco.DecoType? decoType = null,
      ScriptableAmount internalSA = null,
      ScriptableAmount otherSA = null)
      where T : ScriptableAmount
    {
      T t = ScriptableObject.CreateInstance<T>();
      string str = typeof (T).Name.Replace("Scriptable", "");
      switch (str)
      {
        case "FixedAmount":
          t.name = string.Format("{0} {1}", (object) str, (object) amount);
          t = t.Set<T>(nameof (amount), (object) amount);
          break;
        case "Gold":
          t.name = string.Format("{0} Factor {1}", (object) str, (object) factor);
          t = t.Set<T>(nameof (factor), (object) factor);
          break;
        case "CurrentStatus":
        case "CurrentStatusBoostable":
          t.name = "Current" + statusType.ToUpperFirstLetter() + (str == "CurrentStatusBoostable" ? "Boostable" : "");
          // ISSUE: explicit reference operation
          (^ref t).name += offset.ToString(" + #; - #;");
          t = t.Set<T>(nameof (statusType), (object) statusType).Set<T>(nameof (offset), (object) offset);
          break;
        case "Deco":
          t.name = string.Format("{0} {1}{{{2}}}", (object) str, (object) decoType, (object) internalSA.name) + (otherSA != null ? ".{" + otherSA.name + "}" : "");
          t = t.Set<T>("basic", (object) internalSA).Set<T>(nameof (decoType), (object) decoType).Set<T>("other", (object) otherSA);
          break;
        default:
          t.name = str;
          break;
      }
      return t;
    }

    public static ScriptableDeco AddScriptableDeco(
      this ScriptableAmount data,
      ScriptableDeco.DecoType type,
      ScriptableAmount otherSA = null)
    {
      return SFUtils.CreateScriptableAmount<ScriptableDeco>(decoType: new ScriptableDeco.DecoType?(type), internalSA: data, otherSA: otherSA);
    }

    public static string SwapWith(this string s, string s1, string s2)
    {
      return Regex.Replace(s, s1 + "|" + s2, new MatchEvaluator(f));

      string f(Match match) => !(match.Value == s1) ? s1 : s2;
    }

    public static T CopyWithSESwapped<T>(this T se, WildfrostMod mod, string typeA, string typeB) where T : StatusEffectData
    {
      string upperFirstLetter1 = typeA.ToUpperFirstLetter();
      string upperFirstLetter2 = typeB.ToUpperFirstLetter();
      string name = se.name.SwapWith(upperFirstLetter1, upperFirstLetter2);
      if ((UnityEngine.Object) mod.Get<StatusEffectData>(name) != (UnityEngine.Object) null)
        return mod.Get<StatusEffectData>(name) as T;
      T data = UnityEngine.Object.Instantiate<T>(se);
      data.name = name;
      if (!data.textKey.IsEmpty)
        data.Edit<StatusEffectData, StatusEffectDataBuilder>().WithText(data.textKey.GetLocalizedString().SwapWith(typeA, typeB));
      if (data.targetConstraints.Length != 0)
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        data.targetConstraints = ((IEnumerable<TargetConstraint>) data.targetConstraints).Select<TargetConstraint, TargetConstraint>(SFUtils.\u003C\u003EO.\u003C0\u003E__Instantiate ?? (SFUtils.\u003C\u003EO.\u003C0\u003E__Instantiate = new Func<TargetConstraint, TargetConstraint>(UnityEngine.Object.Instantiate<TargetConstraint>))).ToArray<TargetConstraint>();
        foreach (TargetConstraint targetConstraint in data.targetConstraints)
        {
          if (targetConstraint is TargetConstraintHasStatus constraintHasStatus)
          {
            if (constraintHasStatus.status.type == typeA)
              constraintHasStatus.status = mod.Get<StatusEffectData>(upperFirstLetter2);
            else if (constraintHasStatus.status.type == typeB)
              constraintHasStatus.status = mod.Get<StatusEffectData>(upperFirstLetter1);
          }
        }
      }
      if (data is StatusEffectApplyX statusEffectApplyX)
      {
        if (statusEffectApplyX.scriptableAmount != null)
        {
          statusEffectApplyX.scriptableAmount = UnityEngine.Object.Instantiate<ScriptableAmount>(statusEffectApplyX.scriptableAmount);
          if (statusEffectApplyX.scriptableAmount is ScriptableCurrentStatus scriptableAmount)
            scriptableAmount.statusType = scriptableAmount.statusType.SwapWith(typeA, typeB);
        }
        if (statusEffectApplyX.contextEqualAmount != null)
        {
          statusEffectApplyX.contextEqualAmount = UnityEngine.Object.Instantiate<ScriptableAmount>(statusEffectApplyX.contextEqualAmount);
          if (statusEffectApplyX.contextEqualAmount is ScriptableCurrentStatus contextEqualAmount)
            contextEqualAmount.statusType = contextEqualAmount.statusType.SwapWith(typeA, typeB);
        }
        if (statusEffectApplyX.applyConstraints.Length != 0)
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          statusEffectApplyX.applyConstraints = ((IEnumerable<TargetConstraint>) statusEffectApplyX.applyConstraints).Select<TargetConstraint, TargetConstraint>(SFUtils.\u003C\u003EO.\u003C0\u003E__Instantiate ?? (SFUtils.\u003C\u003EO.\u003C0\u003E__Instantiate = new Func<TargetConstraint, TargetConstraint>(UnityEngine.Object.Instantiate<TargetConstraint>))).ToArray<TargetConstraint>();
          foreach (TargetConstraint applyConstraint in statusEffectApplyX.applyConstraints)
          {
            if (applyConstraint is TargetConstraintHasStatus constraintHasStatus)
            {
              if (constraintHasStatus.status.type == typeA)
                constraintHasStatus.status = mod.Get<StatusEffectData>(upperFirstLetter2);
              else if (constraintHasStatus.status.type == typeB)
                constraintHasStatus.status = mod.Get<StatusEffectData>(upperFirstLetter1);
            }
          }
        }
        statusEffectApplyX.effectToApply = statusEffectApplyX.effectToApply.CopyWithSESwapped<StatusEffectData>(mod, typeA, typeB);
      }
      if (data is StatusEffectInstantLoseX effectInstantLoseX)
        effectInstantLoseX.statusToLose = effectInstantLoseX.statusToLose.CopyWithSESwapped<StatusEffectData>(mod, typeA, typeB);
      return data.Register<T>();
    }

    public static Sprite LoadSprite(string baseLoc, string loc, Vector2? pivot = null)
    {
      if (SFUtils.SpriteCache.ContainsKey(loc))
        return SFUtils.SpriteCache[loc];
      Texture2D texture2D = new Texture2D(2, 2, GraphicsFormat.R16G16B16A16_SFloat, TextureCreationFlags.None);
      texture2D.LoadImage(File.ReadAllBytes(baseLoc + "\\" + (loc.EndsWith(".png") ? loc : loc + ".png")));
      texture2D.filterMode = FilterMode.Point;
      Sprite spriteEx = texture2D.ToSpriteEX(pivot);
      SFUtils.SpriteCache.Add(loc, spriteEx);
      return spriteEx;
    }

    public static Sprite ToSpriteEX(this Texture2D t, Vector2? v = null)
    {
      Vector2 pivot = v ?? new Vector2(0.5f, 0.5f);
      return Sprite.Create(t, new Rect(0.0f, 0.0f, (float) t.width, (float) t.height), pivot, 100f, 0U, SpriteMeshType.Tight);
    }

    public static GameMode GetGameMode(string name) => AddressableLoader.GetGroup<GameMode>("GameMode").Find((Predicate<GameMode>) (a => a.name == name));

    public static RewardPool CreateRewardPool(string name, string type, List<DataFile> list)
    {
      RewardPool instance = ScriptableObject.CreateInstance<RewardPool>();
      instance.name = name;
      instance.type = type;
      instance.list = list;
      return instance;
    }

    public static T Set<T>(this T t, string name, object value)
    {
      BindingFlags bindingAttr = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;
      FieldInfo field = t.GetType().GetField(name, bindingAttr);
      if ((object) field == null)
        t.GetType().GetProperty(name, bindingAttr)?.SetValue((object) t, value);
      else
        field?.SetValue((object) t, value);
      return t;
    }

    public static T CreateTargetConstraint<T>(
      string cardName = "TargetConstraint",
      bool not = false,
      int value = 0,
      int moreThan = 0,
      StatusEffectData status = null,
      StatusEffectData effect = null,
      string statusType = "",
      TraitData trait = null,
      bool ignoreSilenced = false,
      CardType[] allowedTypes = null,
      CardData[] allowedCards = null,
      bool mustBeMiniboss = false)
      where T : TargetConstraint
    {
      T instance = ScriptableObject.CreateInstance<T>();
      instance.name = cardName;
      return instance.Set<T>(nameof (not), (object) not).Set<T>(nameof (value), (object) value).Set<T>(nameof (moreThan), (object) moreThan).Set<T>(nameof (status), (object) status).Set<T>(nameof (effect), (object) effect).Set<T>(nameof (statusType), (object) statusType).Set<T>(nameof (trait), (object) trait).Set<T>(nameof (ignoreSilenced), (object) ignoreSilenced).Set<T>(nameof (allowedTypes), (object) allowedTypes).Set<T>(nameof (allowedCards), (object) allowedCards).Set<T>(nameof (mustBeMiniboss), (object) mustBeMiniboss);
    }

    public static T ApplyBy<T>(
      this StatusEffectData inner,
      WildfrostMod mod,
      string newName,
      string newDesc,
      StatusEffectApplyX.ApplyToFlags applyTo = StatusEffectApplyX.ApplyToFlags.Self,
      bool targetMustBeAlive = true)
      where T : StatusEffectApplyX
    {
      return new StatusEffectDataBuilder(mod).Create<T>(newName).WithText(newDesc).FreeModify<T>((Action<T>) (se =>
      {
        se.effectToApply = inner;
        se.applyToFlags = applyTo;
        se.targetConstraints = Array.Empty<TargetConstraint>();
        se.applyConstraints = inner.targetConstraints;
        se.canBeBoosted = inner.canBeBoosted;
        se.stackable = inner.stackable;
        se.targetMustBeAlive = targetMustBeAlive;
        se.type = "";
      })).Register<StatusEffectData, StatusEffectDataBuilder>() as T;
    }

    public static T CreateCardScript<T>(string scriptName) where T : CardScript
    {
      T instance = ScriptableObject.CreateInstance<T>();
      instance.name = Extensions.PrefixGUID(scriptName, (WildfrostMod) SnowfallMod.Instance);
      return instance;
    }

    public static CardDataBuilder AsEnemyClunker(this CardDataBuilder builder) => builder.FreeModify((Action<CardData>) (c => c.isEnemyClunker = true));

    public static StatusEffectDataBuilder NoStacks(this StatusEffectDataBuilder builder) => builder.WithStackable(false).WithCanBeBoosted(false);

    public static T Register<T, B>(this DataFileBuilder<T, B> builder)
      where T : DataFile
      where B : DataFileBuilder<T, B>, new()
    {
      return builder.Build().Set<T>("ModAdded", (object) builder.Mod).Register<T>();
    }

    public static T Register<T>(this T data) where T : DataFile
    {
      if (SnowfallMod.Registered.ContainsKey(typeof (T).Name))
      {
        if (!SnowfallMod.Registered[typeof (T).Name].Any<DataFile>((Func<DataFile, bool>) (d => d.name == ((T) data).name)))
        {
          AddressableLoader.AddToGroup<T>(typeof (T).Name, data);
          SnowfallMod.Registered[typeof (T).Name].Add((DataFile) data);
        }
      }
      else
      {
        AddressableLoader.AddToGroup<T>(typeof (T).Name, data);
        SnowfallMod.Registered.Add(typeof (T).Name, new List<DataFile>()
        {
          (DataFile) data
        });
      }
      return data;
    }

    public static void SwitchToSaveProfile(string switchTo, bool copyFiles = false)
    {
      SaveSystem.Profile = switchTo;
      SaveSystem.folderName = SaveSystem.profileFolder + "/" + switchTo;
      if (SaveSystem.Enabled)
        Events.InvokeSaveSystemProfileChanged();
      string str1 = SaveSystem.profileFolder + "/Default";
      DirectoryInfo parent = System.IO.Directory.GetParent(SaveSystem.settings.FullPath);
      if (((System.IO.Directory.Exists(parent.FullName + "/" + SaveSystem.folderName) ? 0 : (System.IO.Directory.Exists(parent.FullName + "/" + str1) ? 1 : 0)) & (copyFiles ? 1 : 0)) == 0)
        return;
      DirectoryInfo directory = System.IO.Directory.CreateDirectory(parent.FullName + "/" + SaveSystem.folderName);
      string[] strArray = new string[5]
      {
        "Campaign",
        "Battle",
        "History",
        "Save",
        "Stats"
      };
      foreach (string str2 in strArray)
      {
        if (File.Exists(parent?.ToString() + "/" + str1 + "/" + str2 + ".sav"))
          File.Copy(parent?.ToString() + "/" + str1 + "/" + str2 + ".sav", directory?.ToString() + "/" + str2 + ".sav");
        if (File.Exists(parent?.ToString() + "/" + str1 + "/" + str2 + ".sav.bac"))
          File.Copy(parent?.ToString() + "/" + str1 + "/" + str2 + ".sav.bac", directory?.ToString() + "/" + str2 + ".sav.bac");
      }
    }

    public static BattleWavePoolData CreateBattleWavePoolData(
      WildfrostMod mod,
      string battleName,
      string wavePoolName,
      BattleWavePoolData.Wave[] waves = null,
      List<string> unitList = null,
      int pullCount = 1,
      int weight = 1)
    {
      if (waves == null && unitList == null)
        throw new ArgumentNullException("Either waves or unitList must be non-null");
      List<CardData> cardDataList = new List<CardData>();
      if (unitList != null)
      {
        cardDataList.AddRange(unitList.Select<string, CardData>(new Func<string, CardData>(mod.Get<CardData>)));
        BattleWavePoolData.Wave wave = new BattleWavePoolData.Wave()
        {
          units = cardDataList,
          fixedOrder = false,
          maxSize = 6,
          value = 0,
          positionPriority = 0
        };
        waves = waves.AddToArray<BattleWavePoolData.Wave>(wave);
      }
      return ScriptableObject.CreateInstance<BattleWavePoolData>().Set<BattleWavePoolData>("name", (object) (Extensions.PrefixGUID(battleName, mod) + " " + wavePoolName)).Set<BattleWavePoolData>(nameof (waves), (object) waves).Set<BattleWavePoolData>("forcePulls", (object) pullCount).Set<BattleWavePoolData>("maxPulls", (object) pullCount).Set<BattleWavePoolData>(nameof (weight), (object) weight);
    }

    public static BattleWavePoolData.Wave CreateBattleWaveData(CardData[] units, bool fixedOrder = false) => new BattleWavePoolData.Wave()
    {
      units = units.ToList<CardData>(),
      fixedOrder = fixedOrder,
      maxSize = 6,
      value = 0,
      positionPriority = 0
    };
  }
}
