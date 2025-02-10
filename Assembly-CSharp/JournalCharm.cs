// Decompiled with JetBrains decompiler
// Type: JournalCharm
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JournalCharm : MonoBehaviourRect
{
  public Vector2 popUpOffset = new Vector2(1f, 0.0f);
  [SerializeField]
  private Image image;
  [SerializeField]
  private Material discoveredMaterial;
  private CardUpgradeData upgradeData;
  private bool discovered;
  private bool hover;

  private void OnDisable() => this.UnHover();

  public void Assign(CardUpgradeData upgradeData)
  {
    this.upgradeData = upgradeData;
    this.image.sprite = this.upgradeData.image;
  }

  public void CheckDiscovered(List<string> discoveredCharms)
  {
    if (this.discovered || !discoveredCharms.Contains(this.upgradeData.name))
      return;
    this.SetDiscovered();
  }

  public void SetDiscovered()
  {
    this.discovered = true;
    this.image.material = this.discoveredMaterial;
    this.image.color = Color.white;
  }

  public void Hover()
  {
    if (!this.discovered)
      return;
    this.hover = true;
    CardPopUp.AssignTo(this.rectTransform, this.popUpOffset.x, this.popUpOffset.y);
    CardPopUp.AddPanel(this.upgradeData.name, this.upgradeData.title, this.upgradeData.text);
  }

  public void UnHover()
  {
    if (!this.discovered || !this.hover)
      return;
    this.hover = false;
    CardPopUp.RemovePanel(this.upgradeData.name);
  }
}
