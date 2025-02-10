// Decompiled with JetBrains decompiler
// Type: CharacterAvatarMoveToCard
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
public class CharacterAvatarMoveToCard : MonoBehaviour
{
  [SerializeField]
  private Vector3 inCardPosition;
  [SerializeField]
  private Vector3 inCardRotation;
  [SerializeField]
  private Vector3 inCardScale;

  public void MoveToCard(Card card)
  {
    this.transform.SetParent(card.mainImage.transform);
    this.transform.localPosition = this.inCardPosition;
    this.transform.localEulerAngles = this.inCardRotation;
    this.transform.localScale = this.inCardScale;
  }
}
