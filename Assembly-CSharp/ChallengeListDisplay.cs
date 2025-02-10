// Decompiled with JetBrains decompiler
// Type: ChallengeListDisplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

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
