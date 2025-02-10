// Decompiled with JetBrains decompiler
// Type: ChallengeListDisplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
public class ChallengeListDisplay : MonoBehaviour
{
  [SerializeField]
  private ChallengeListDisplayBuilder builder;
  [SerializeField]
  private GameObject loadingWidget;
  private bool loadingWidgetActive;

  private void OnEnable()
  {
    this.loadingWidget.SetActive(this.builder.running);
    this.loadingWidgetActive = this.loadingWidget.activeSelf;
  }

  private void Update()
  {
    if (!this.loadingWidgetActive || this.builder.running)
      return;
    this.loadingWidget.SetActive(false);
    this.loadingWidgetActive = false;
  }
}
