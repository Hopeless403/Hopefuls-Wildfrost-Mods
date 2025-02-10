// Decompiled with JetBrains decompiler
// Type: ShopPrice
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using TMPro;
using UnityEngine;

public class ShopPrice : MonoBehaviour
{
  public ShopItem target;
  public Transform follow;
  [SerializeField]
  private Vector3 offset;
  [SerializeField]
  private TMP_Text textAsset;
  [SerializeField]
  private string format = "{0}<sprite name=bling>";
  [SerializeField]
  private string discountedFormat = "<color=red><s>{1}</s></color> {0}<sprite name=bling>";
  public float scaleWithTarget = 0.5f;
  public float scaleOffsetWithTarget = 0.5f;

  public void Set(ShopItem target, Vector3 offset)
  {
    this.target = target;
    this.follow = target.transform;
    this.offset = offset;
  }

  public void SetOffset(Vector3 offset) => this.offset = offset;

  public void SetPrice(int price, float priceFactor = 1f)
  {
    this.target.price = price;
    this.target.priceFactor = priceFactor;
    if ((double) priceFactor != 1.0)
      this.SetText(string.Format(this.discountedFormat, (object) this.target.GetPrice(), (object) price));
    else
      this.SetText(string.Format(this.format, (object) price));
  }

  private void SetText(string text) => this.textAsset.text = text;

  public bool Check() => (Object) this.follow != (Object) null;

  public void UpdatePosition()
  {
    if ((Object) this.follow == (Object) null)
    {
      this.gameObject.Destroy();
    }
    else
    {
      Vector3 a = this.offset;
      if ((double) this.scaleOffsetWithTarget > 0.0)
        a = Vector3.Scale(a, Vector3.Lerp(Vector3.one, this.follow.localScale, this.scaleOffsetWithTarget));
      this.transform.position = this.follow.position + a;
      if ((double) this.scaleWithTarget <= 0.0)
        return;
      this.transform.localScale = Vector3.Lerp(Vector3.one, this.follow.localScale, this.scaleWithTarget);
    }
  }

  public enum Position
  {
    Top,
    Bottom,
  }
}
