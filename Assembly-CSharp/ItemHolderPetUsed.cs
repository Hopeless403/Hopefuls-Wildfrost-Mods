// Decompiled with JetBrains decompiler
// Type: ItemHolderPetUsed
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.UI;

public class ItemHolderPetUsed : MonoBehaviour
{
  [SerializeField]
  private Image headImage;
  [SerializeField]
  private Vector2 velocityRangeX = new Vector2(10f, 15f);
  [SerializeField]
  private Vector2 velocityRangeY = new Vector2(11f, 13f);
  [SerializeField]
  private Vector2 velocityRangeZ = new Vector2(-15f, -10f);

  private void Start()
  {
    Vector3 dir = new Vector3(this.velocityRangeX.PettyRandom().WithRandomSign(), this.velocityRangeY.PettyRandom(), this.velocityRangeZ.PettyRandom());
    this.gameObject.GetOrAdd<FlyOffScreen>().Knockback(dir);
  }

  public void SetUp(Sprite headSprite)
  {
    if (!((Object) this.headImage != (Object) null))
      return;
    this.headImage.sprite = headSprite;
  }
}
