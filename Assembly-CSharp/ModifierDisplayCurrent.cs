// Decompiled with JetBrains decompiler
// Type: ModifierDisplayCurrent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections.Generic;
using UnityEngine;

public class ModifierDisplayCurrent : ModifierDisplay
{
  [SerializeField]
  private GameObject navController;

  private void OnEnable() => this.CreateIcons();

  private void CreateIcons()
  {
    if (!(bool) (Object) this)
      return;
    this.ClearIcons();
    bool mainGameMode = Campaign.Data.GameMode.mainGameMode;
    CampaignData data1 = Campaign.Data;
    if (data1 != null)
    {
      List<GameModifierData> modifiers = data1.Modifiers;
      if (modifiers != null)
      {
        foreach (GameModifierData data2 in modifiers)
          this.CreateIcon(data2, mainGameMode);
      }
    }
    if (!(bool) (Object) this.navController)
      return;
    this.navController.SetActive(this.modifierCount > 0);
  }

  private void Update()
  {
    CampaignData data = Campaign.Data;
    int num;
    if (data != null)
    {
      List<GameModifierData> modifiers = data.Modifiers;
      if (modifiers != null)
      {
        num = modifiers.Count;
        goto label_4;
      }
    }
    num = 0;
label_4:
    int modifierCount = this.modifierCount;
    if (num == modifierCount)
      return;
    this.CreateIcons();
  }
}
