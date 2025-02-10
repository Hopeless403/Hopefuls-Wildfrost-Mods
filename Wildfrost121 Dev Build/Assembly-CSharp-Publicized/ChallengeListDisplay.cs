// Decompiled with JetBrains decompiler
// Type: ChallengeListDisplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
public class ChallengeListDisplay : MonoBehaviour
{
  [SerializeField]
  public ChallengeListDisplayBuilder builder;
  [SerializeField]
  public GameObject loadingWidget;
  public bool loadingWidgetActive;

  public void OnEnable()
  {
    this.loadingWidget.SetActive(this.builder.running);
    this.loadingWidgetActive = this.loadingWidget.activeSelf;
  }

  public void Update()
  {
    if (!this.loadingWidgetActive || this.builder.running)
      return;
    this.loadingWidget.SetActive(false);
    this.loadingWidgetActive = false;
  }
}
