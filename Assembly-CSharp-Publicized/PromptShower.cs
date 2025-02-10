// Decompiled with JetBrains decompiler
// Type: PromptShower
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using UnityEngine;
using UnityEngine.Localization;

public class PromptShower : MonoBehaviour
{
  [SerializeField]
  public bool showOnEnable = true;
  [SerializeField]
  public bool showOnce = true;
  [SerializeField]
  [ShowIf("showOnce")]
  public string saveDataString;
  [SerializeField]
  public Prompt.Anchor anchor;
  [SerializeField]
  public Vector2 position;
  [SerializeField]
  public float width;
  [SerializeField]
  public Prompt.Emote.Type emote;
  [SerializeField]
  public LocalizedString localizedString;

  public void OnEnable()
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
