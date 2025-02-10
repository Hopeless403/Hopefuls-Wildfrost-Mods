// Decompiled with JetBrains decompiler
// Type: BattleLogDisplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.UI;

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
