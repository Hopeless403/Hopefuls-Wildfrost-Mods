// Decompiled with JetBrains decompiler
// Type: CharacterAvatarMoveToCard
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

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
