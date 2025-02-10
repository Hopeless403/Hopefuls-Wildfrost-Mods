// Decompiled with JetBrains decompiler
// Type: TitleSetter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Components;
using UnityEngine.UI;

#nullable disable
public class TitleSetter : MonoBehaviour
{
  [SerializeField]
  private GameObject gameObject;
  [SerializeField]
  private LocalizeStringEvent text;
  [SerializeField]
  private Image underline;
  [SerializeField]
  private bool setActive = true;
  [SerializeField]
  [ShowIf("setActive")]
  private LocalizedString setKey;
  [SerializeField]
  [ShowIf("setActive")]
  private Sprite setUnderlineSprite;

  public void Set()
  {
    this.gameObject.SetActive(this.setActive);
    if (!this.setActive)
      return;
    this.text.StringReference = this.setKey;
    this.underline.sprite = this.setUnderlineSprite;
  }
}
