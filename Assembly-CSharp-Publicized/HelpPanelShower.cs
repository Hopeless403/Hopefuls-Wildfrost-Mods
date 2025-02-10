// Decompiled with JetBrains decompiler
// Type: HelpPanelShower
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Localization;

public class HelpPanelShower : MonoBehaviour
{
  [SerializeField]
  public LocalizedString key;
  [SerializeField]
  public Prompt.Emote.Type emote = Prompt.Emote.Type.Explain;
  [SerializeField]
  public LocalizedString[] buttonTextKeys;
  [SerializeField]
  public string[] buttonHotKeys;
  [SerializeField]
  public bool canGoBack = true;

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
