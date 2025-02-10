// Decompiled with JetBrains decompiler
// Type: ModifierIconSpecialBorder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class ModifierIconSpecialBorder : MonoBehaviour
{
  [SerializeField]
  public Image border;
  [SerializeField]
  public Sprite specialBorder;

  public void SetSpecialBorder() => this.border.sprite = this.specialBorder;
}
