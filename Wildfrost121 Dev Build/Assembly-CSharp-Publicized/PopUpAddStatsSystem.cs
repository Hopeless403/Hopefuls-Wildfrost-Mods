// Decompiled with JetBrains decompiler
// Type: PopUpAddStatsSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Localization;

#nullable disable
public class PopUpAddStatsSystem : GameSystem
{
  [SerializeField]
  public LocalizedString counterRef;
  [SerializeField]
  public LocalizedString counterThisTurnRef;
  [SerializeField]
  public LocalizedString counterFrozenRef;
  [SerializeField]
  public LocalizedString reactionRef;
  [SerializeField]
  public LocalizedString reactionJoinRef;
  [SerializeField]
  public LocalizedString reactionFrozenRef;
  [SerializeField]
  public LocalizedString reactionSilencedRef;
  public Entity hover;
  public bool hoverEntityIsSnowed;
  public bool hoverEntitySilenced;
  public const string buffedColour = "#5F5";
  public const string debuffedColour = "#e8a0a0";

  public void OnEnable()
  {
    global::Events.OnEntityHover += new UnityAction<Entity>(this.HoverChanged);
    global::Events.OnPopupCreated += new UnityAction<KeywordData, CardPopUpPanel>(this.PopupCreated);
  }

  public void OnDisable()
  {
    global::Events.OnEntityHover -= new UnityAction<Entity>(this.HoverChanged);
    global::Events.OnPopupCreated -= new UnityAction<KeywordData, CardPopUpPanel>(this.PopupCreated);
  }

  public void HoverChanged(Entity entity)
  {
    this.hover = entity;
    this.hoverEntityIsSnowed = entity.IsSnowed;
    this.hoverEntitySilenced = entity.silenced;
  }

  public void PopupCreated(KeywordData keyword, CardPopUpPanel panel)
  {
    if (!(bool) (UnityEngine.Object) this.hover)
      return;
    switch (keyword.name)
    {
      case "Health":
        string str1 = "<color=white>";
        string text1 = (this.hover.hp.current >= this.hover.hp.max ? (this.hover.hp.current <= this.hover.hp.max ? str1 + string.Format("{0}", (object) this.hover.hp.current) : str1 + string.Format("<color={0}>{1}</color>", (object) "#5F5", (object) this.hover.hp.current)) : str1 + string.Format("<color={0}>{1}</color>", (object) "#e8a0a0", (object) this.hover.hp.current)) + string.Format("/{0}</color>", (object) this.hover.hp.max);
        panel.AddToTitle(text1);
        panel.BuildTextElement();
        break;
      case "Attack":
        string str2 = "<color=white>";
        int num = this.hover.damage.current + this.hover.tempDamage.Value;
        string text2 = (num >= this.hover.damage.max ? (num <= this.hover.damage.max ? str2 + string.Format("{0}", (object) num) : str2 + string.Format("<color={0}>{1}</color>", (object) "#5F5", (object) num)) : str2 + string.Format("<color={0}>{1}</color>", (object) "#e8a0a0", (object) num)) + string.Format("/{0}</color>", (object) this.hover.damage.max);
        panel.AddToTitle(text2);
        panel.BuildTextElement();
        break;
      case "Counter":
        string str3 = "<color=white>";
        string text3 = (this.hover.counter.current <= this.hover.counter.max ? str3 + string.Format("{0}", (object) this.hover.counter.current) : str3 + string.Format("<color={0}>{1}</color>", (object) "#e8a0a0", (object) this.hover.counter.current)) + string.Format("/{0}</color>", (object) this.hover.counter.max);
        panel.AddToTitle(text3);
        panel.AddToBody(this.BuildCounterBodyText(this.hoverEntityIsSnowed, this.hover.counter.current));
        panel.BuildTextElement();
        break;
      case "Reaction":
        panel.AddToBody(this.BuildReactionBodyText(this.hoverEntityIsSnowed, this.hoverEntitySilenced));
        panel.BuildTextElement();
        break;
    }
  }

  public string BuildCounterBodyText(bool frozen, int turnsTilTrigger)
  {
    if (frozen)
      return this.counterFrozenRef.GetLocalizedString();
    if (turnsTilTrigger <= 1)
      return this.counterThisTurnRef.GetLocalizedString();
    return this.counterRef.GetLocalizedString().Format((object) turnsTilTrigger);
  }

  public string BuildReactionBodyText(bool frozen, bool silenced)
  {
    if (silenced)
      return this.reactionSilencedRef.GetLocalizedString();
    if (frozen)
      return this.reactionFrozenRef.GetLocalizedString();
    List<string> values = new List<string>();
    foreach (StatusEffectData statusEffect in this.hover.statusEffects)
    {
      if (statusEffect.isReaction && !statusEffect.textKey.IsEmpty)
        values.Add(PopUpAddStatsSystem.FormatReactionText(statusEffect));
    }
    foreach (Entity.TraitStacks trait in this.hover.traits)
    {
      if (trait.data.isReaction)
        values.Add("<" + PopUpAddStatsSystem.FirstCharToLowerCase(trait.data.keyword.body) + ">");
    }
    return this.reactionRef.GetLocalizedString().Format((object) string.Join(this.reactionJoinRef.GetLocalizedString(), (IEnumerable<string>) values));
  }

  public static string FormatReactionText(StatusEffectData effect)
  {
    string str1 = Text.GetEffectText(effect.textKey, effect.textInsert, effect.count);
    for (int index = 0; index < str1.Length; ++index)
    {
      if (str1[index] == '<')
      {
        int num = str1.IndexOf('>', index);
        string str2 = str1.Substring(index + 1, num - index - 1);
        string newValue = str2;
        if (str2.Contains('='))
        {
          string[] strArray = str2.Split('=', StringSplitOptions.None);
          switch (strArray[0].Trim())
          {
            case "keyword":
              KeywordData keyword = Text.ToKeyword(strArray[1]);
              newValue = !keyword.iconName.IsNullOrWhitespace() ? "><sprite name=" + keyword.iconName + "><" : keyword.title;
              break;
            case "card":
              newValue = AddressableLoader.Get<CardData>("CardData", strArray[1].Trim()).title;
              break;
          }
        }
        str1 = str1.Replace(str1.Substring(index, num - index + 1), newValue);
        index += newValue.Length;
      }
    }
    return ("<" + PopUpAddStatsSystem.FirstCharToLowerCase(str1) + ">").Replace("<>", "");
  }

  public static string FirstCharToLowerCase(string str)
  {
    if (!char.IsUpper(str[0]))
      return str;
    if (str.Length == 1)
      return str.ToLower();
    string str1 = char.ToLower(str[0]).ToString();
    string str2 = str;
    int length1 = str2.Length;
    int startIndex = 1;
    int num = startIndex;
    int length2 = length1 - num;
    string str3 = str2.Substring(startIndex, length2);
    return str1 + str3;
  }
}
