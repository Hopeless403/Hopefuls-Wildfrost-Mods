// Decompiled with JetBrains decompiler
// Type: CharacterAvatarMoveToCard
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

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
