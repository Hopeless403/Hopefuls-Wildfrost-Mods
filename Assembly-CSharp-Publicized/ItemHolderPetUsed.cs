// Decompiled with JetBrains decompiler
// Type: ItemHolderPetUsed
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.UI;

public class ItemHolderPetUsed : MonoBehaviour
{
  [SerializeField]
  public Image headImage;
  [SerializeField]
  public Vector2 velocityRangeX = new Vector2(10f, 15f);
  [SerializeField]
  public Vector2 velocityRangeY = new Vector2(11f, 13f);
  [SerializeField]
  public Vector2 velocityRangeZ = new Vector2(-15f, -10f);

  public void Start()
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
