// Decompiled with JetBrains decompiler
// Type: CardCharmHolder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class CardCharmHolder : UpgradeHolder
{
  [SerializeField]
  public float angleAdd = 20f;
  [SerializeField]
  public Vector2 charmPivot = new Vector2(0.5f, 0.9f);
  [SerializeField]
  public Image ropeImage;

  public override void SetPositions()
  {
    int count = this.list.Count;
    float num = (float) -((double) (count - 1) * 0.5) * this.angleAdd;
    for (int index = 0; index < count; ++index)
    {
      if (this.list[index] is CardCharm cardCharm)
      {
        cardCharm.SetAngle(num + (float) index * this.angleAdd);
        cardCharm.transform.SetSiblingIndex(CardCharmHolder.CalculateSiblingIndex(index, count));
      }
    }
    this.ropeImage?.gameObject.SetActive(count > 0);
  }

  public static int CalculateSiblingIndex(int listIndex, int listLength)
  {
    float num1 = (float) (listLength - 1) * 0.5f;
    float f = (float) listIndex - num1;
    float num2 = Mathf.Sign(f);
    return Mathf.FloorToInt(num1 + f * -num2) * 2 + Mathf.Clamp((int) f, 0, 1);
  }

  public override void Add(UpgradeDisplay upgrade)
  {
    base.Add(upgrade);
    this.CharmAdded(upgrade);
  }

  public override void Insert(int index, UpgradeDisplay upgrade)
  {
    base.Insert(index, upgrade);
    this.CharmAdded(upgrade);
  }

  public void CharmAdded(UpgradeDisplay upgrade)
  {
    if (!(upgrade is CardCharm cardCharm))
      return;
    cardCharm.holder = this.transform;
    ((RectTransform) cardCharm.transform).pivot = this.charmPivot;
  }

  public override void Clear()
  {
    base.Clear();
    this.ropeImage?.gameObject.SetActive(false);
  }
}
