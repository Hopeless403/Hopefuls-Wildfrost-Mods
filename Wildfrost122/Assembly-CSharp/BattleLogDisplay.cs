// Decompiled with JetBrains decompiler
// Type: BattleLogDisplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class BattleLogDisplay : MonoBehaviour
{
  [SerializeField]
  private BattleLogDisplayBuilder builder;
  [SerializeField]
  private ScrollRect scroll;
  [SerializeField]
  private GameObject loadingWidget;
  private bool promptScrollToBottom;
  private bool loadingWidgetActive;

  private void OnEnable()
  {
    this.CheckScrollToBottom();
    this.loadingWidget.SetActive(this.builder.running);
    this.loadingWidgetActive = this.loadingWidget.activeSelf;
  }

  private void Update()
  {
    this.CheckScrollToBottom();
    if (!this.loadingWidgetActive || this.builder.running)
      return;
    this.loadingWidget.SetActive(false);
    this.loadingWidgetActive = false;
  }

  private void CheckScrollToBottom()
  {
    if (!this.promptScrollToBottom || this.builder.running)
      return;
    this.scroll.normalizedPosition = Vector2.zero;
    this.promptScrollToBottom = false;
  }

  public void PromptScrollToBottom() => this.promptScrollToBottom = true;
}
