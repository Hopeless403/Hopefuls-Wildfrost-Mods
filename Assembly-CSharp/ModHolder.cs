// Decompiled with JetBrains decompiler
// Type: ModHolder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using Deadpan.Enums.Engine.Components.Modding;
using System.Diagnostics;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ModHolder : MonoBehaviour
{
  public WildfrostMod Mod;
  public TextMeshProUGUI Title;
  public TextMeshProUGUI Description;
  public Image Icon;
  public GameObject PublishButton;
  public ToggleSprite[] toggleSprites;
  public BellRinger bellRinger;

  public void ToggleMod()
  {
    this.Mod.ModToggle();
    this.UpdateSprites();
    if (!this.Mod.HasLoaded)
      return;
    this.bellRinger.Ring();
  }

  public void PublishMod() => this.Mod.UpdateOrPublishWorkshop();

  public void OpenModDirectory() => Process.Start(this.Mod.ModDirectory);

  public void UpdateInfo()
  {
    this.Title.text = this.Mod.Title;
    this.Description.text = this.Mod.Description;
    this.Icon.sprite = this.Mod.IconSprite;
    this.PublishButton.SetActive(this.Mod.ModDirectory.Contains(Application.streamingAssetsPath));
    this.UpdateSprites();
  }

  private void UpdateSprites()
  {
    foreach (ToggleSprite toggleSprite in this.toggleSprites)
      toggleSprite.Set(this.Mod.HasLoaded);
  }
}
