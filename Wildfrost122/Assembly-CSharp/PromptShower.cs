﻿// Decompiled with JetBrains decompiler
// Type: PromptShower
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using UnityEngine;
using UnityEngine.Localization;

#nullable disable
public class PromptShower : MonoBehaviour
{
  [SerializeField]
  private bool showOnEnable = true;
  [SerializeField]
  private bool showOnce = true;
  [SerializeField]
  [ShowIf("showOnce")]
  private string saveDataString;
  [SerializeField]
  private Prompt.Anchor anchor;
  [SerializeField]
  private Vector2 position;
  [SerializeField]
  private float width;
  [SerializeField]
  private Prompt.Emote.Type emote;
  [SerializeField]
  private LocalizedString localizedString;

  private void OnEnable()
  {
    if (!this.showOnEnable)
      return;
    this.Show((object) null);
  }

  public void Show(object insert)
  {
    if (this.showOnce)
    {
      if (SaveSystem.LoadProgressData<bool>(this.saveDataString, false))
        return;
      SaveSystem.SaveProgressData<bool>(this.saveDataString, true);
    }
    PromptSystem.Hide();
    PromptSystem.Create(this.anchor, this.position.x, this.position.y, this.width, this.emote);
    if (insert != null)
      PromptSystem.SetTextAction((Prompt.GetTextCallback) (() => string.Format(this.localizedString.GetLocalizedString(), insert)));
    else
      PromptSystem.SetTextAction((Prompt.GetTextCallback) (() => this.localizedString.GetLocalizedString()));
  }

  public void Hide() => PromptSystem.Hide();
}
