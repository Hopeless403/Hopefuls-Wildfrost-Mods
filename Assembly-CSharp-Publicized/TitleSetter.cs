// Decompiled with JetBrains decompiler
// Type: TitleSetter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Components;
using UnityEngine.UI;

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
