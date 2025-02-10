// Decompiled with JetBrains decompiler
// Type: Text
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.Localization;

#nullable disable
public static class Text
{
  public static global::Text.ColourProfileHex darkProfile = new global::Text.ColourProfileHex("3B262C", "000", "41874AFF", "880033FF", "4B6A9CFF", "4B6A9Caa", "4188baff", "4B6A9Caa", "ffe6");
  public static global::Text.ColourProfileHex lightProfile = new global::Text.ColourProfileHex("FFF", "FFFF99FF", "BBFFCCFF", "FFCCBBFF", "FFFF99FF", "FFFF99aa", "BBFFCCFF", "FFCCBBFF", "ffe6");

  public static string Process(string original) => global::Text.Process(original, 0, 1f, global::Text.lightProfile);

  public static string Process(string original, global::Text.ColourProfileHex profile)
  {
    return global::Text.Process(original, 0, 1f, profile);
  }

  public static string Process(
    string original,
    int effectBonus,
    float effectFactor,
    global::Text.ColourProfileHex profile)
  {
    string text = original.Trim();
    int length = text.Length;
    for (int index = 0; index < length; ++index)
    {
      if (text[index] == '<')
      {
        string tag = global::Text.FindTag(text, index);
        if (tag.Length > 0)
        {
          text = text.Remove(index, tag.Length + 2);
          string str = global::Text.ProcessTag(text, tag, effectBonus, effectFactor, profile);
          if (str.Length > 0)
          {
            text = text.Insert(index, str);
            index += str.Length;
          }
          length = text.Length;
          --index;
        }
      }
    }
    return text;
  }

  public static string FindTag(string text, int startIndex)
  {
    string tag = "";
    int num = text.IndexOf('>', startIndex) - startIndex;
    if (num > 0)
      tag = text.Substring(startIndex + 1, num - 1);
    return tag;
  }

  public static string ProcessTag(
    string text,
    string tag,
    int effectBonus,
    float effectFactor,
    global::Text.ColourProfileHex profile)
  {
    char c = tag[0];
    bool flag1 = char.IsDigit(c);
    if (tag.Length == 1 && !flag1)
      return "<" + tag + ">";
    string str1 = string.Empty;
    string str2 = (string) null;
    if (c == '+' || c == '-' || c == 'x')
      str2 = c.ToString();
    int result1;
    if ((flag1 || str2 != null) && int.TryParse(Regex.Replace(tag, "[^0-9]+", string.Empty), out result1))
    {
      int num = Mathf.Max(0, Mathf.RoundToInt((float) (result1 + effectBonus) * effectFactor));
      string str3 = "<color=#" + profile.effectColour + ">";
      string str4 = "</color>";
      if (num > result1)
        str3 = "<color=#" + profile.effectBuffedColour + ">";
      else if (num < result1)
        str3 = "<color=#" + profile.effectDebuffedColour + ">";
      str1 = string.Format("<b>{0}{1}{2}{3}</b>", (object) str3, (object) str2, (object) num, (object) str4);
    }
    else
    {
      string[] strArray1 = tag.Split('=', StringSplitOptions.None);
      if (strArray1.Length == 2)
      {
        switch (strArray1[0].Trim())
        {
          case "card":
            string assetName = strArray1[1].Trim();
            CardData cardData = AddressableLoader.Get<CardData>("CardData", assetName);
            if (!(bool) (UnityEngine.Object) cardData)
              Debug.LogError((object) ("Error processing text: " + text + "\nCard [" + assetName + "] does not exist!"));
            str1 = "<#" + profile.keywordColour + ">" + cardData.title + "</color>";
            break;
          case "color":
          case "size":
            str1 = "<" + tag + ">";
            break;
          case "keyword":
            string text1 = strArray1[1].Trim();
            KeywordData keyword = global::Text.ToKeyword(text1);
            bool flag2 = !keyword.iconName.IsNullOrWhitespace();
            if (flag2 && keyword.showIcon && !keyword.showName)
            {
              str1 = "<sprite name=" + keyword.iconName + ">";
              break;
            }
            if (keyword.showName)
            {
              string[] strArray2 = text1.Split(' ', StringSplitOptions.None);
              bool flag3 = strArray2.Length > 2 && strArray2[2] == "silenced";
              string str5 = flag3 ? profile.keywordSilencedColour : profile.keywordColour;
              if (flag2 && keyword.showIcon)
                str1 = str1 + "<sprite name=\"" + keyword.iconName + "\" color=#" + str5 + ">";
              string str6 = str1 + "<color=#" + str5 + ">";
              if (flag3)
                str6 += "<s>";
              string str7;
              if (keyword.canStack && strArray2.Length > 1)
              {
                int result2 = 1;
                int num = 1;
                if (strArray2.Length != 0 && int.TryParse(strArray2[1], out result2))
                  num = Mathf.Max(0, Mathf.RoundToInt((float) (result2 + effectBonus) * effectFactor));
                string str8 = "<color=#" + str5 + ">";
                string str9 = "</color>";
                if (num > result2)
                  str8 = "<color=#" + profile.keywordBuffedColour + ">";
                else if (num < result2)
                  str8 = "<color=#" + profile.keywordDebuffedColour + ">";
                str7 = str6 + string.Format("{0} <b>{1}{2}{3}</b>", (object) keyword.title, (object) str8, (object) num, (object) str9);
              }
              else
                str7 = str6 + keyword.title;
              str1 = str7 + "</color>";
              if (flag3)
              {
                str1 += "</s>";
                break;
              }
              break;
            }
            break;
          case "spr":
          case "sprite":
          case "sprite name":
            str1 = "<sprite name=" + strArray1[1].Trim() + ">";
            break;
        }
      }
    }
    if (str1.IsNullOrWhitespace())
    {
      if (c.Equals('/'))
        str1 = "<" + tag + ">";
      else
        str1 = "<color=#" + profile.effectColour + ">" + tag + "</color>";
    }
    return str1;
  }

  public static KeywordData ToKeyword(string text)
  {
    int startIndex = text.IndexOf(' ');
    if (startIndex > 0)
      text = text.Remove(startIndex, text.Length - startIndex);
    KeywordData keyword = AddressableLoader.Get<KeywordData>("KeywordData", text);
    string message;
    if (!((UnityEngine.Object) keyword != (UnityEngine.Object) null))
      message = "Keyword for \"" + text + "\" = NULL";
    else
      message = "Keyword for \"" + text + "\" = [" + keyword.name + "]";
    Debug.Log((object) message);
    if (!(bool) (UnityEngine.Object) keyword)
      Debug.LogError((object) ("Keyword \"" + text + "\" not found!"));
    return keyword;
  }

  public static HashSet<KeywordData> GetKeywords(string text)
  {
    HashSet<KeywordData> keywords = new HashSet<KeywordData>();
    for (int index = 0; index < text.Length; ++index)
    {
      if (text[index].Equals('<'))
      {
        string tag = global::Text.FindTag(text, index);
        if (tag.Length > 0 && tag.Contains("="))
        {
          string[] strArray = tag.Split('=', StringSplitOptions.None);
          if (strArray.Length == 2 && strArray[0].Trim() == "keyword")
          {
            KeywordData keyword = global::Text.ToKeyword(strArray[1].Trim());
            if (keyword.show)
              keywords.Add(keyword);
          }
        }
      }
    }
    return keywords;
  }

  public static HashSet<CardData> GetMentionedCards(string text)
  {
    HashSet<CardData> mentionedCards = new HashSet<CardData>();
    for (int index = 0; index < text.Length; ++index)
    {
      if (text[index].Equals('<'))
      {
        string tag = global::Text.FindTag(text, index);
        if (tag.Length > 0 && tag.Contains("="))
        {
          string[] strArray = tag.Split('=', StringSplitOptions.None);
          if (strArray.Length == 2 && strArray[0].Trim() == "card")
          {
            CardData cardData = AddressableLoader.Get<CardData>("CardData", strArray[1].Trim());
            mentionedCards.Add(cardData);
          }
        }
      }
    }
    return mentionedCards;
  }

  public static string GetEffectText(
    LocalizedString textKey,
    string textInsert,
    int amount,
    bool silenced = false)
  {
    string str = global::Text.HandleBracketTags(textKey.GetLocalizedString().Replace("{0}", textInsert).Replace("{e}", textInsert).Replace("{a}", amount.ToString()));
    return silenced ? "<s>" + str + "</s>" : str;
  }

  public static string GetEffectText(
    IEnumerable<LocalizedString> textKeys,
    string textInsert,
    int amount,
    bool silenced = false)
  {
    string str1 = "{0}";
    foreach (LocalizedString textKey in textKeys)
      str1 = str1.Replace("{0}", textKey.GetLocalizedString());
    string str2 = global::Text.HandleBracketTags(str1.Replace("{0}", textInsert).Replace("{e}", textInsert).Replace("{a}", amount.ToString()));
    return silenced ? "<s>" + str2 + "</s>" : str2;
  }

  public static string HandleBracketTags(string text)
  {
    while (true)
    {
      int startIndex = text.IndexOf('[');
      if (startIndex >= 0)
      {
        int count = text.IndexOf(']') - startIndex + 1;
        if (count > 0)
        {
          string str = text.Substring(startIndex + 1, count - 2);
          char ch = str.Length <= 1 || startIndex <= 0 ? str[0] : str[1];
          text = text.Remove(startIndex, count);
          text = text.Insert(startIndex, ch.ToString());
        }
        else
          break;
      }
      else
        break;
    }
    return text;
  }

  [Serializable]
  public struct ColourProfileHex
  {
    public string textColour;
    public string effectColour;
    public string effectBuffedColour;
    public string effectDebuffedColour;
    public string keywordColour;
    public string keywordSilencedColour;
    public string keywordBuffedColour;
    public string keywordDebuffedColour;
    public string flavourColour;

    public ColourProfileHex(
      string textColour,
      string effectColour,
      string effectBuffedColour,
      string effectDebuffedColour,
      string keywordColour,
      string keywordSilencedColour,
      string keywordBuffedColour,
      string keywordDebuffedColour,
      string flavourColour)
    {
      this.textColour = textColour;
      this.effectColour = effectColour;
      this.effectBuffedColour = effectBuffedColour;
      this.effectDebuffedColour = effectDebuffedColour;
      this.keywordColour = keywordColour;
      this.keywordSilencedColour = keywordSilencedColour;
      this.keywordBuffedColour = keywordBuffedColour;
      this.keywordDebuffedColour = keywordDebuffedColour;
      this.flavourColour = flavourColour;
    }
  }
}
