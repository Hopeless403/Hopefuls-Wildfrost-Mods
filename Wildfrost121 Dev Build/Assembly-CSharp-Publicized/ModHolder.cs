// Decompiled with JetBrains decompiler
// Type: ModHolder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using Deadpan.Enums.Engine.Components.Modding;
using System.Diagnostics;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
public class ModHolder : MonoBehaviour
{
  public WildfrostMod Mod;
  public TextMeshProUGUI Title;
  public TextMeshProUGUI Description;
  public Image Icon;
  public GameObject PublishButton;
  public ToggleSprite[] toggleSprites;
  public BellRinger bellRinger;
  public bool DrawingUpload;

  public void OnEnable()
  {
    global::Events.OnModLoaded += new UnityAction<WildfrostMod>(this.ModToggled);
    global::Events.OnModUnloaded += new UnityAction<WildfrostMod>(this.ModToggled);
  }

  public void OnDisable()
  {
    global::Events.OnModLoaded -= new UnityAction<WildfrostMod>(this.ModToggled);
    global::Events.OnModUnloaded -= new UnityAction<WildfrostMod>(this.ModToggled);
  }

  public void ModToggled(WildfrostMod mod)
  {
    if (mod.GUID != this.Mod.GUID)
      return;
    this.UpdateSprites();
  }

  public void ToggleMod()
  {
    this.Mod.ModToggle();
    if (!this.Mod.HasLoaded)
      return;
    this.bellRinger.Ring();
  }

  public void OnGUI()
  {
    if (!this.DrawingUpload)
      return;
    if (GUILayout.Button("Confirm publish for " + this.Mod.GUID))
    {
      this.Mod.UpdateOrPublishWorkshop();
      this.DrawingUpload = false;
    }
    else
    {
      if (!GUILayout.Button("Cancel publish for " + this.Mod.GUID))
        return;
      this.DrawingUpload = false;
    }
  }

  public void PublishMod() => this.DrawingUpload = true;

  public void OpenModDirectory() => Process.Start(this.Mod.ModDirectory);

  public void UpdateInfo()
  {
    this.Title.text = this.Mod.Title;
    this.Description.text = this.Mod.Description;
    this.Icon.sprite = this.Mod.IconSprite;
    this.PublishButton.SetActive(this.Mod.ModDirectory.Contains(Application.streamingAssetsPath));
    this.UpdateSprites();
  }

  public void UpdateSprites()
  {
    foreach (ToggleSprite toggleSprite in this.toggleSprites)
      toggleSprite.Set(this.Mod.HasLoaded);
  }
}
