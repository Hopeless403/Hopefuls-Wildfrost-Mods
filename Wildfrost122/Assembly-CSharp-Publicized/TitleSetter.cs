// Decompiled with JetBrains decompiler
// Type: TitleSetter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Components;
using UnityEngine.UI;

#nullable disable
public class TitleSetter : MonoBehaviour
{
  [SerializeField]
  public GameObject gameObject;
  [SerializeField]
  public LocalizeStringEvent text;
  [SerializeField]
  public Image underline;
  [SerializeField]
  public bool setActive = true;
  [SerializeField]
  [ShowIf("setActive")]
  public LocalizedString setKey;
  [SerializeField]
  [ShowIf("setActive")]
  public Sprite setUnderlineSprite;

  public void Set()
  {
    this.gameObject.SetActive(this.setActive);
    if (!this.setActive)
      return;
    this.text.StringReference = this.setKey;
    this.underline.sprite = this.setUnderlineSprite;
  }
}
