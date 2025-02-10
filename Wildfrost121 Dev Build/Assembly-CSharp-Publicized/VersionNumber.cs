// Decompiled with JetBrains decompiler
// Type: VersionNumber
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using Deadpan.Enums.Engine.Components.Modding;
using System;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
[RequireComponent(typeof (TMP_Text))]
public class VersionNumber : MonoBehaviour
{
  [SerializeField]
  public bool showProfile;
  [SerializeField]
  public bool showVersion = true;
  public TMP_Text _t;

  public TMP_Text textElement => this._t ?? (this._t = this.GetComponent<TMP_Text>());

  public void OnEnable()
  {
    global::Events.OnSaveSystemProfileChanged += new UnityAction(this.UpdateText);
    global::Events.OnModLoaded += new UnityAction<WildfrostMod>(this.ModStateChanged);
    global::Events.OnModUnloaded += new UnityAction<WildfrostMod>(this.ModStateChanged);
  }

  public void OnDisable()
  {
    global::Events.OnSaveSystemProfileChanged -= new UnityAction(this.UpdateText);
    global::Events.OnModLoaded -= new UnityAction<WildfrostMod>(this.ModStateChanged);
    global::Events.OnModUnloaded -= new UnityAction<WildfrostMod>(this.ModStateChanged);
  }

  public void Start() => this.UpdateText();

  public void ModStateChanged(WildfrostMod mod) => this.UpdateText();

  public void UpdateText()
  {
    string str1 = "";
    if (SaveSystem.Enabled && this.showProfile)
    {
      if (!str1.IsNullOrWhitespace())
        str1 += "\n";
      str1 = str1 + "Profile: " + SaveSystem.Profile;
    }
    if (this.showVersion)
    {
      if (!str1.IsNullOrWhitespace())
        str1 += "\n";
      str1 += string.Format(Config.data.versionFormat, (object) Config.data.versionNotation);
    }
    string str2 = str1 + " (dev)";
    WildfrostMod[] array = Bootstrap.Mods.Where<WildfrostMod>((Func<WildfrostMod, bool>) (a => a.HasLoaded)).ToArray<WildfrostMod>();
    if (array.Length != 0)
    {
      str2 += "<#ff3><size=0.3>";
      foreach (WildfrostMod wildfrostMod in array)
        str2 = str2 + "\n" + wildfrostMod.Title;
    }
    this.textElement.text = str2;
  }
}
