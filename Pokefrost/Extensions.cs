// Decompiled with JetBrains decompiler
// Type: Pokefrost.Ext
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using Deadpan.Enums.Engine.Components.Modding;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Localization;
using UnityEngine.Localization.Components;
using UnityEngine.Localization.Tables;
using UnityEngine.UI;

#nullable disable
namespace Pokefrost
{
  public static class Ext
  {
    public static Sprite panel;
    public static Sprite panelSmall;

    public static StringTable Collection
    {
      get
      {
        return LocalizationHelper.GetCollection("Card Text", (LocaleIdentifier) SystemLanguage.English);
      }
    }

    public static StringTable KeyCollection
    {
      get
      {
        return LocalizationHelper.GetCollection("Tooltips", (LocaleIdentifier) SystemLanguage.English);
      }
    }

    public static void CreateColoredInkAnim(WildfrostMod mod, Color color, string type)
    {
      VfxStatusSystem objectOfType = UnityEngine.Object.FindObjectOfType<VfxStatusSystem>();
      GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(objectOfType.profileLookup["ink"].applyEffectPrefab, Pokefrost.Pokefrost.pokefrostUI.transform);
      ParticleSystem component1 = gameObject.transform.GetChild(0).GetComponent<ParticleSystem>();
      component1.colorOverLifetime.color = (ParticleSystem.MinMaxGradient) color;
      component1.main.startColor = (ParticleSystem.MinMaxGradient) color;
      Sprite sprite1 = AddressableExtMethods.ASprite("Splatter.png");
      ParticleSystem component2 = gameObject.transform.GetChild(4).GetComponent<ParticleSystem>();
      component2.textureSheetAnimation.AddSprite(sprite1);
      component2.textureSheetAnimation.RemoveSprite(0);
      component2.main.startColor = (ParticleSystem.MinMaxGradient) color;
      ParticleSystem component3 = gameObject.transform.GetChild(5).GetComponent<ParticleSystem>();
      component3.textureSheetAnimation.AddSprite(sprite1);
      component3.textureSheetAnimation.RemoveSprite(0);
      component3.main.startColor = (ParticleSystem.MinMaxGradient) color;
      ParticleSystem component4 = gameObject.transform.GetChild(6).GetComponent<ParticleSystem>();
      component4.textureSheetAnimation.AddSprite(sprite1);
      component4.textureSheetAnimation.RemoveSprite(0);
      component4.main.startColor = (ParticleSystem.MinMaxGradient) color;
      Sprite sprite2 = mod.ImagePath("Splat.png").ToSprite();
      ParticleSystem component5 = gameObject.transform.GetChild(9).GetComponent<ParticleSystem>();
      component5.textureSheetAnimation.AddSprite(sprite2);
      component5.textureSheetAnimation.RemoveSprite(0);
      component5.main.startColor = (ParticleSystem.MinMaxGradient) color;
      VfxStatusSystem.Profile profile = new VfxStatusSystem.Profile()
      {
        type = type,
        applyEffectPrefab = gameObject
      };
      objectOfType.profiles = ((IEnumerable<VfxStatusSystem.Profile>) objectOfType.profiles).AddItem<VfxStatusSystem.Profile>(profile).ToArray<VfxStatusSystem.Profile>();
      objectOfType.profileLookup["juice"] = profile;
    }

    public static void PopupText(Transform transform, string s, bool localized = true)
    {
      NoTargetTextSystem objectOfType = UnityEngine.Object.FindObjectOfType<NoTargetTextSystem>();
      if (!((UnityEngine.Object) objectOfType != (UnityEngine.Object) null))
        return;
      TMP_Text textElement = objectOfType.textElement;
      StringTable collection = LocalizationHelper.GetCollection("Tooltips", (LocaleIdentifier) SystemLanguage.English);
      string str = localized ? collection.GetString(s).GetLocalizedString() : s;
      textElement.text = str;
      objectOfType.PopText(transform.position);
    }

    public static void AddLookup(string summoned, string summoner)
    {
      CreatedByLookup.lookup[summoned] = summoner;
    }

    public static void LoadPanels(WildfrostMod mod)
    {
      Ext.panel = AddressableExtMethods.ASprite("Panel");
      Ext.panelSmall = AddressableExtMethods.ASprite("PanelSmall");
    }

    public static T[] RemoveNulls<T>(this T[] data, WildfrostMod mod) where T : DataFile
    {
      List<T> list = data.ToList<T>();
      list.RemoveAll((Predicate<T>) (x => (UnityEngine.Object) x == (UnityEngine.Object) null || x?.ModAdded == mod));
      return list.ToArray();
    }

    public static T CreateTrait<T>(
      string name,
      WildfrostMod mod,
      KeywordData keyword,
      params StatusEffectData[] effects)
      where T : TraitData
    {
      T instance = ScriptableObject.CreateInstance<T>();
      instance.name = name;
      instance.effects = effects;
      instance.keyword = keyword;
      instance.ModAdded = mod;
      AddressableLoader.AddToGroup<TraitData>("TraitData", (TraitData) instance);
      return instance;
    }

    public static T CreateStatus<T>(
      string name,
      string desc = null,
      string textInsert = null,
      string type = "",
      bool boostable = false,
      bool stackable = true)
      where T : StatusEffectData
    {
      T instance = ScriptableObject.CreateInstance<T>();
      instance.name = name;
      instance.targetConstraints = new TargetConstraint[0];
      if (!desc.IsNullOrEmpty())
      {
        Ext.Collection.SetString(name + "_text", desc);
        instance.textKey = Ext.Collection.GetString(name + "_text");
        if (!textInsert.IsNullOrEmpty())
          instance.textInsert = textInsert;
      }
      instance.type = type;
      instance.hiddenKeywords = new KeywordData[0];
      instance.canBeBoosted = boostable;
      instance.stackable = stackable;
      return instance;
    }

    public static T SetConstraints<T>(this T t, params TargetConstraint[] ts) where T : StatusEffectData
    {
      t.targetConstraints = ts;
      return t;
    }

    public static T ApplyX<T>(
      this T t,
      StatusEffectData effectToApply,
      StatusEffectApplyX.ApplyToFlags flags)
      where T : StatusEffectApplyX
    {
      t.effectToApply = effectToApply;
      t.applyToFlags = flags;
      return t;
    }

    public static T SetApplyConstraints<T>(this T t, params TargetConstraint[] ts) where T : StatusEffectApplyX
    {
      t.applyConstraints = ts;
      return t;
    }

    public static T Register<T>(this T status, WildfrostMod mod) where T : StatusEffectData
    {
      status.ModAdded = mod;
      Pokefrost.Pokefrost.statusList.Add((StatusEffectData) status);
      AddressableLoader.AddToGroup<StatusEffectData>("StatusEffectData", (StatusEffectData) status);
      return status;
    }

    public static GameObject CreateButtonIcon(
      this WildfrostMod mod,
      string name,
      Sprite sprite,
      string type,
      string copyTextFrom,
      Color textColor,
      KeywordData[] keys)
    {
      GameObject buttonIcon = new GameObject(name);
      buttonIcon.transform.SetParent(Pokefrost.Pokefrost.pokefrostUI.transform);
      buttonIcon.SetActive(false);
      StatusIconExt statusIconExt = buttonIcon.AddComponent<StatusIconExt>();
      Dictionary<string, GameObject> cardIcons = CardManager.cardIcons;
      statusIconExt.animator = buttonIcon.AddComponent<ButtonAnimator>();
      statusIconExt.button = buttonIcon.AddComponent<ButtonExt>();
      statusIconExt.animator.button = (Selectable) statusIconExt.button;
      if (!copyTextFrom.IsNullOrEmpty())
      {
        GameObject gameObject = cardIcons[copyTextFrom].GetComponentInChildren<TextMeshProUGUI>().gameObject.InstantiateKeepName<GameObject>();
        gameObject.transform.SetParent(buttonIcon.transform);
        statusIconExt.textElement = (TMP_Text) gameObject.GetComponent<TextMeshProUGUI>();
        statusIconExt.textColour = textColor;
        statusIconExt.textColourAboveMax = textColor;
        statusIconExt.textColourBelowMax = textColor;
      }
      statusIconExt.onCreate = new UnityEvent();
      statusIconExt.onDestroy = new UnityEvent();
      statusIconExt.onValueDown = new UnityEventStatStat();
      statusIconExt.onValueUp = new UnityEventStatStat();
      statusIconExt.afterUpdate = new UnityEvent();
      buttonIcon.AddComponent<Image>().sprite = sprite;
      CardHover cardHover = buttonIcon.AddComponent<CardHover>();
      cardHover.enabled = false;
      cardHover.IsMaster = false;
      CardPopUpTarget cardPopUpTarget = buttonIcon.AddComponent<CardPopUpTarget>();
      cardPopUpTarget.keywords = keys;
      cardHover.pop = cardPopUpTarget;
      RectTransform component = buttonIcon.GetComponent<RectTransform>();
      component.anchorMin = Vector2.zero;
      component.anchorMax = Vector2.zero;
      component.sizeDelta *= 0.008f;
      buttonIcon.SetActive(true);
      statusIconExt.type = type;
      cardIcons[type] = buttonIcon;
      buttonIcon.AddComponent<UINavigationItem>();
      return buttonIcon;
    }

    public static GameObject CreateIcon(
      this WildfrostMod mod,
      string name,
      Sprite sprite,
      string type,
      string copyTextFrom,
      Color textColor,
      KeywordData[] keys,
      int posX = 1)
    {
      GameObject icon = new GameObject(name);
      icon.transform.SetParent(Pokefrost.Pokefrost.pokefrostUI.transform);
      icon.SetActive(false);
      StatusIcon statusIcon = (StatusIcon) icon.AddComponent<StatusIconExt>();
      Dictionary<string, GameObject> cardIcons = CardManager.cardIcons;
      if (!copyTextFrom.IsNullOrEmpty())
      {
        GameObject gameObject = cardIcons[copyTextFrom].GetComponentInChildren<TextMeshProUGUI>().gameObject.InstantiateKeepName<GameObject>();
        gameObject.transform.SetParent(icon.transform);
        statusIcon.textElement = (TMP_Text) gameObject.GetComponent<TextMeshProUGUI>();
        statusIcon.textColour = textColor;
        statusIcon.textColourAboveMax = textColor;
        statusIcon.textColourBelowMax = textColor;
      }
      statusIcon.onCreate = new UnityEvent();
      statusIcon.onDestroy = new UnityEvent();
      statusIcon.onValueDown = new UnityEventStatStat();
      statusIcon.onValueUp = new UnityEventStatStat();
      statusIcon.afterUpdate = new UnityEvent();
      icon.AddComponent<Image>().sprite = sprite;
      CardHover cardHover = icon.AddComponent<CardHover>();
      cardHover.enabled = false;
      cardHover.IsMaster = false;
      CardPopUpTarget cardPopUpTarget = icon.AddComponent<CardPopUpTarget>();
      cardPopUpTarget.keywords = keys;
      cardPopUpTarget.posX = (float) posX;
      cardHover.pop = cardPopUpTarget;
      RectTransform component = icon.GetComponent<RectTransform>();
      component.anchorMin = Vector2.zero;
      component.anchorMax = Vector2.zero;
      component.sizeDelta *= 0.01f;
      icon.SetActive(true);
      statusIcon.type = type;
      cardIcons[type] = icon;
      return icon;
    }

    public static KeywordData CreateBasicKeyword(
      this WildfrostMod mod,
      string name,
      string title,
      string desc,
      bool useSmallPanel = false)
    {
      KeywordData instance = ScriptableObject.CreateInstance<KeywordData>();
      instance.name = name;
      Ext.KeyCollection.SetString(instance.name + "_text", title);
      instance.titleKey = Ext.KeyCollection.GetString(instance.name + "_text");
      Ext.KeyCollection.SetString(instance.name + "_desc", desc);
      instance.descKey = Ext.KeyCollection.GetString(instance.name + "_desc");
      instance.ModAdded = mod;
      instance.showName = true;
      instance.panelSprite = useSmallPanel ? Ext.panelSmall : Ext.panel;
      instance.panelColor = new Color(0.15f, 0.15f, 0.15f, 0.9f);
      AddressableLoader.AddToGroup<KeywordData>("KeywordData", instance);
      return instance;
    }

    public static KeywordData CreateIconKeyword(
      this WildfrostMod mod,
      string name,
      string title,
      string desc,
      string icon,
      bool useSmallPanel = false)
    {
      KeywordData instance = ScriptableObject.CreateInstance<KeywordData>();
      instance.name = name;
      Ext.KeyCollection.SetString(instance.name + "_text", title);
      instance.titleKey = Ext.KeyCollection.GetString(instance.name + "_text");
      Ext.KeyCollection.SetString(instance.name + "_desc", desc);
      instance.descKey = Ext.KeyCollection.GetString(instance.name + "_desc");
      instance.showIcon = true;
      instance.showName = false;
      instance.iconName = icon;
      instance.ModAdded = mod;
      instance.panelSprite = useSmallPanel ? Ext.panelSmall : Ext.panel;
      instance.panelColor = new Color(0.15f, 0.15f, 0.15f, 0.9f);
      AddressableLoader.AddToGroup<KeywordData>("KeywordData", instance);
      return instance;
    }

    public static KeywordData ChangeColor(
      this KeywordData data,
      Color? title = null,
      Color? body = null,
      Color? note = null)
    {
      Color valueOrDefault1;
      int num1;
      if (title.HasValue)
      {
        valueOrDefault1 = title.GetValueOrDefault();
        num1 = 1;
      }
      else
        num1 = 0;
      if (num1 != 0)
        data.titleColour = valueOrDefault1;
      Color valueOrDefault2;
      int num2;
      if (body.HasValue)
      {
        valueOrDefault2 = body.GetValueOrDefault();
        num2 = 1;
      }
      else
        num2 = 0;
      if (num2 != 0)
        data.bodyColour = valueOrDefault2;
      Color valueOrDefault3;
      int num3;
      if (note.HasValue)
      {
        valueOrDefault3 = note.GetValueOrDefault();
        num3 = 1;
      }
      else
        num3 = 0;
      if (num3 != 0)
        data.noteColour = valueOrDefault3;
      return data;
    }

    public static KeywordData ChangePanel(this KeywordData data, Sprite panel = null, Color? color = null)
    {
      if ((UnityEngine.Object) panel != (UnityEngine.Object) null)
        data.panelSprite = panel;
      Color valueOrDefault;
      int num;
      if (color.HasValue)
      {
        valueOrDefault = color.GetValueOrDefault();
        num = 1;
      }
      else
        num = 0;
      data.panelColor = num == 0 ? Color.white : valueOrDefault;
      return data;
    }

    public static T CreateStatusButton<T>(
      this WildfrostMod mod,
      string name,
      string type,
      string iconGroup = "counter")
      where T : StatusEffectData
    {
      T instance = ScriptableObject.CreateInstance<T>();
      instance.name = name;
      instance.targetConstraints = new TargetConstraint[0];
      instance.type = type;
      instance.isStatus = true;
      instance.iconGroupName = iconGroup;
      instance.visible = true;
      instance.stackable = false;
      return instance;
    }

    public static CampaignNodeTypeBuilder CreateCampaignNodeType<T>(
      this WildfrostMod mod,
      string name,
      string letter,
      bool canSkip = true)
      where T : CampaignNodeType
    {
      return new CampaignNodeTypeBuilder(mod).Create<T>(name).WithCanEnter(true).WithCanLink(true).WithInteractable(true).WithCanSkip(canSkip).WithMustClear(!canSkip).WithLetter(letter).WithZoneName(name);
    }

    public static GameModifierDataBuilder CreateBell(
      this WildfrostMod mod,
      string name,
      string title,
      string description)
    {
      return new GameModifierDataBuilder(mod).Create(name).WithTitle(title).WithDescription(description).WithRingSfxEvent(mod.Get<GameModifierData>("DoubleBlingsFromCombos").ringSfxEvent);
    }

    public static GameModifierDataBuilder ChangeSprites(
      this GameModifierDataBuilder b,
      string bell = null,
      string dinger = null)
    {
      GameModifierData data = b._data;
      if (!bell.IsNullOrEmpty())
      {
        Texture2D tex = Pokefrost.Pokefrost.instance.ImagePath(bell).ToTex();
        data.bellSprite = Sprite.Create(tex, new Rect(0.0f, 0.0f, (float) tex.width, (float) tex.height), new Vector2(0.5f, 0.9f), 327f);
      }
      if (!dinger.IsNullOrEmpty())
      {
        Texture2D tex = Pokefrost.Pokefrost.instance.ImagePath(dinger).ToTex();
        data.dingerSprite = Sprite.Create(tex, new Rect(0.0f, 0.0f, (float) tex.width, (float) tex.height), new Vector2(0.5f, 1.5f), 327f);
      }
      return b;
    }

    public static CampaignNodeTypeBuilder BetterEvent(
      this CampaignNodeTypeBuilder cn,
      string key,
      WildfrostMod mod)
    {
      MapNode mapNodePrefab = mod.Get<CampaignNodeType>("CampaignNodeCharm").mapNodePrefab.InstantiateKeepName<MapNode>();
      mapNodePrefab.transform.SetParent(Pokefrost.Pokefrost.pokefrostUI.transform, false);
      StringTable collection = LocalizationHelper.GetCollection("UI Text", (LocaleIdentifier) SystemLanguage.English);
      collection.SetString("map_" + mapNodePrefab.name, key);
      mapNodePrefab.label.GetComponentInChildren<LocalizeStringEvent>().StringReference = collection.GetString("map_" + mapNodePrefab.name);
      mapNodePrefab.spriteOptions[0] = AddressableExtMethods.ASprite("trade_event");
      mapNodePrefab.clearedSpriteOptions[0] = AddressableExtMethods.ASprite("trade_done");
      return cn.WithMapNodePrefab(mapNodePrefab).FreeModify<CampaignNodeTypeTrade>((Action<CampaignNodeTypeTrade>) (data => data.key = key));
    }

    public static CampaignNodeTypeBuilder BetterBattle(
      this CampaignNodeTypeBuilder cn,
      WildfrostMod mod)
    {
      MapNode mapNodePrefab = mod.Get<CampaignNodeType>("CampaignNodeBattle").mapNodePrefab.InstantiateKeepName<MapNode>();
      mapNodePrefab.transform.SetParent(Pokefrost.Pokefrost.pokefrostUI.transform, false);
      return cn.WithMapNodePrefab(mapNodePrefab);
    }

    public static void Register(this CampaignNodeTypeBuilder cn, WildfrostMod mod)
    {
      CampaignNodeType campaignNodeType = cn.Build();
      campaignNodeType.ModAdded = mod;
      AddressableLoader.AddToGroup<CampaignNodeType>("CampaignNodeType", campaignNodeType);
    }

    public static CardDataBuilder SStartEffects(
      this CardDataBuilder b,
      params (string, int)[] statusEffects)
    {
      return b.SubscribeToAfterAllBuildEvent((DataFileBuilder<CardData, CardDataBuilder>.AfterBuildDelegate) (data =>
      {
        CardData.StatusEffectStacks[] array = ((IEnumerable<(string, int)>) statusEffects).Select<(string, int), CardData.StatusEffectStacks>((Func<(string, int), CardData.StatusEffectStacks>) (status => new CardData.StatusEffectStacks(Pokefrost.Pokefrost.instance.Get<StatusEffectData>(status.Item1), status.Item2))).ToArray<CardData.StatusEffectStacks>();
        data.startWithEffects = array;
      }));
    }

    public static CardUpgradeDataBuilder SEffects(
      this CardUpgradeDataBuilder b,
      params (string, int)[] statusEffects)
    {
      return b.SubscribeToAfterAllBuildEvent((DataFileBuilder<CardUpgradeData, CardUpgradeDataBuilder>.AfterBuildDelegate) (data =>
      {
        CardData.StatusEffectStacks[] array = ((IEnumerable<(string, int)>) statusEffects).Select<(string, int), CardData.StatusEffectStacks>((Func<(string, int), CardData.StatusEffectStacks>) (status => new CardData.StatusEffectStacks(Pokefrost.Pokefrost.instance.Get<StatusEffectData>(status.Item1), status.Item2))).ToArray<CardData.StatusEffectStacks>();
        data.effects = array;
      }));
    }

    public static CardDataBuilder SAttackEffects(
      this CardDataBuilder b,
      params (string, int)[] statusEffects)
    {
      return b.SubscribeToAfterAllBuildEvent((DataFileBuilder<CardData, CardDataBuilder>.AfterBuildDelegate) (data =>
      {
        CardData.StatusEffectStacks[] array = ((IEnumerable<(string, int)>) statusEffects).Select<(string, int), CardData.StatusEffectStacks>((Func<(string, int), CardData.StatusEffectStacks>) (status => new CardData.StatusEffectStacks(Pokefrost.Pokefrost.instance.Get<StatusEffectData>(status.Item1), status.Item2))).ToArray<CardData.StatusEffectStacks>();
        data.attackEffects = array;
      }));
    }

    public static CardUpgradeDataBuilder SAttackEffects(
      this CardUpgradeDataBuilder b,
      params (string, int)[] statusEffects)
    {
      return b.SubscribeToAfterAllBuildEvent((DataFileBuilder<CardUpgradeData, CardUpgradeDataBuilder>.AfterBuildDelegate) (data =>
      {
        CardData.StatusEffectStacks[] array = ((IEnumerable<(string, int)>) statusEffects).Select<(string, int), CardData.StatusEffectStacks>((Func<(string, int), CardData.StatusEffectStacks>) (status => new CardData.StatusEffectStacks(Pokefrost.Pokefrost.instance.Get<StatusEffectData>(status.Item1), status.Item2))).ToArray<CardData.StatusEffectStacks>();
        data.attackEffects = array;
      }));
    }

    public static CardDataBuilder STraits(this CardDataBuilder b, params (string, int)[] traits)
    {
      return b.SubscribeToAfterAllBuildEvent((DataFileBuilder<CardData, CardDataBuilder>.AfterBuildDelegate) (data =>
      {
        List<CardData.TraitStacks> list = ((IEnumerable<(string, int)>) traits).Select<(string, int), CardData.TraitStacks>((Func<(string, int), CardData.TraitStacks>) (tr => new CardData.TraitStacks(Pokefrost.Pokefrost.instance.Get<TraitData>(tr.Item1), tr.Item2))).ToList<CardData.TraitStacks>();
        data.traits = list;
      }));
    }

    public static CardUpgradeDataBuilder STraits(
      this CardUpgradeDataBuilder b,
      params (string, int)[] traits)
    {
      return b.SubscribeToAfterAllBuildEvent((DataFileBuilder<CardUpgradeData, CardUpgradeDataBuilder>.AfterBuildDelegate) (data =>
      {
        CardData.TraitStacks[] array = ((IEnumerable<(string, int)>) traits).Select<(string, int), CardData.TraitStacks>((Func<(string, int), CardData.TraitStacks>) (tr => new CardData.TraitStacks(Pokefrost.Pokefrost.instance.Get<TraitData>(tr.Item1), tr.Item2))).ToArray<CardData.TraitStacks>();
        data.giveTraits = array;
      }));
    }
  }
}
