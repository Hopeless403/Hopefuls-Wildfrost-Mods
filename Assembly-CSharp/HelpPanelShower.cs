// Decompiled with JetBrains decompiler
// Type: HelpPanelShower
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Localization;

public class HelpPanelShower : MonoBehaviour
{
  [SerializeField]
  private LocalizedString key;
  [SerializeField]
  private Prompt.Emote.Type emote = Prompt.Emote.Type.Explain;
  [SerializeField]
  private LocalizedString[] buttonTextKeys;
  [SerializeField]
  private string[] buttonHotKeys;
  [SerializeField]
  private bool canGoBack = true;

  public void SetKey(LocalizedString key, Prompt.Emote.Type? emoteType = null)
  {
    this.key = key;
    if (!emoteType.HasValue)
      return;
    this.emote = emoteType.Value;
  }

  public void Show()
  {
    HelpPanelSystem.Show(this.key);
    HelpPanelSystem.SetEmote(this.emote);
    HelpPanelSystem.SetBackButtonActive(this.canGoBack);
  }

  public void AddButton(int index, HelpPanelSystem.ButtonType type, UnityAction action) => HelpPanelSystem.AddButton(type, this.buttonTextKeys[index], this.buttonHotKeys[index], action);
}
