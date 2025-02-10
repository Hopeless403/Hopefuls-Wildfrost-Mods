// Decompiled with JetBrains decompiler
// Type: Names
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;

#nullable disable
public class Names : MonoBehaviourSingleton<Names>
{
  [SerializeField]
  private Names.Asset[] assets;
  private static Dictionary<string, TextAsset> files;
  private static readonly Dictionary<string, Queue<string>> lookup = new Dictionary<string, Queue<string>>();

  public static void Reset() => Names.lookup.Clear();

  private void OnEnable()
  {
    LocalizationSettings.Instance.OnSelectedLocaleChanged += new Action<Locale>(Names.LocaleChanged);
  }

  private void OnDisable()
  {
    LocalizationSettings.Instance.OnSelectedLocaleChanged -= new Action<Locale>(Names.LocaleChanged);
  }

  private static void LocaleChanged(Locale locale)
  {
    Names.files = (Dictionary<string, TextAsset>) null;
    Names.Reset();
  }

  public static string Pull(string key)
  {
    if (!Names.lookup.ContainsKey(key))
      Names.Load(key);
    Queue<string> stringQueue = Names.lookup[key];
    if (stringQueue == null || stringQueue.Count == 0)
    {
      Names.Load(key);
      stringQueue = Names.lookup[key];
    }
    return stringQueue.Dequeue();
  }

  public static string Pull(string characterRace, string characterGender)
  {
    return Names.Pull(characterRace + characterGender);
  }

  private static void Load(string key)
  {
    List<string> stringList = new List<string>();
    foreach (string str in Regex.Split(Names.GetFiles(key).text, "\r\n|\n|\r"))
      stringList.Add(str.Trim());
    stringList.Shuffle<string>();
    Names.lookup[key] = new Queue<string>((IEnumerable<string>) stringList);
  }

  private static TextAsset GetFiles(string key)
  {
    if (Names.files == null)
    {
      Names.files = new Dictionary<string, TextAsset>();
      foreach (Names.Asset asset in MonoBehaviourSingleton<Names>.instance.assets)
      {
        Names.LocaleTextAsset localeTextAsset = ((IEnumerable<Names.LocaleTextAsset>) asset.files).FirstOrDefault<Names.LocaleTextAsset>((Func<Names.LocaleTextAsset, bool>) (a => a.locale.name == LocalizationSettings.SelectedLocale.name)) ?? ((IEnumerable<Names.LocaleTextAsset>) asset.files).First<Names.LocaleTextAsset>();
        Names.files[asset.name] = localeTextAsset.textAsset;
      }
    }
    return Names.files[key];
  }

  [Serializable]
  private struct Asset
  {
    public string name;
    public Names.LocaleTextAsset[] files;
  }

  [Serializable]
  private class LocaleTextAsset
  {
    public Locale locale;
    public TextAsset textAsset;
  }
}
