// Decompiled with JetBrains decompiler
// Type: BattleLogDisplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class BattleLogDisplay : MonoBehaviour
{
  [SerializeField]
  public BattleLogDisplayBuilder builder;
  [SerializeField]
  public ScrollRect scroll;
  [SerializeField]
  public GameObject loadingWidget;
  public bool promptScrollToBottom;
  public bool loadingWidgetActive;

  public void OnEnable()
  {
    this.CheckScrollToBottom();
    this.loadingWidget.SetActive(this.builder.running);
    this.loadingWidgetActive = this.loadingWidget.activeSelf;
  }

  public void Update()
  {
    this.CheckScrollToBottom();
    if (!this.loadingWidgetActive || this.builder.running)
      return;
    this.loadingWidget.SetActive(false);
    this.loadingWidgetActive = false;
  }

  public void CheckScrollToBottom()
  {
    if (!this.promptScrollToBottom || this.builder.running)
      return;
    this.scroll.normalizedPosition = Vector2.zero;
    this.promptScrollToBottom = false;
  }

  public void PromptScrollToBottom() => this.promptScrollToBottom = true;
}
