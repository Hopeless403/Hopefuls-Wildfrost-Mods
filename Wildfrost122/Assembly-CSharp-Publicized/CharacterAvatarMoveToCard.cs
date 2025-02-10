// Decompiled with JetBrains decompiler
// Type: CharacterAvatarMoveToCard
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
public class CharacterAvatarMoveToCard : MonoBehaviour
{
  [SerializeField]
  public Vector3 inCardPosition;
  [SerializeField]
  public Vector3 inCardRotation;
  [SerializeField]
  public Vector3 inCardScale;

  public void MoveToCard(Card card)
  {
    this.transform.SetParent(card.mainImage.transform);
    this.transform.localPosition = this.inCardPosition;
    this.transform.localEulerAngles = this.inCardRotation;
    this.transform.localScale = this.inCardScale;
  }
}
