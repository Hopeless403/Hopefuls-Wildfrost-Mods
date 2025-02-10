// Decompiled with JetBrains decompiler
// Type: ItemHolderPet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.UI;

public class ItemHolderPet : MonoBehaviour
{
  [SerializeField]
  public Entity owner;
  [SerializeField]
  public ItemHolderPetUsed usedPrefab;
  [SerializeField]
  public TweenUI showTween;
  [SerializeField]
  public AngleWobbler headWobbler;
  [Header("Head")]
  [SerializeField]
  public Sprite[] headOptions;
  [SerializeField]
  public Image head;

  public void Show()
  {
    if (this.gameObject.activeSelf)
      return;
    this.gameObject.SetActive(true);
    if ((Object) this.head != (Object) null && this.headOptions.Length != 0)
      this.head.sprite = this.headOptions[Mathf.RoundToInt((float) this.headOptions.Length * this.owner.data.random3.x).Mod(this.headOptions.Length)];
    this.showTween.Fire();
    this.headWobbler.WobbleRandom();
  }

  public void Hide()
  {
    if (!((Object) this.gameObject != (Object) null) || !this.gameObject.activeSelf)
      return;
    this.gameObject.SetActive(false);
  }

  public void Used()
  {
    this.gameObject.SetActive(false);
    ItemHolderPetUsed itemHolderPetUsed = Object.Instantiate<ItemHolderPetUsed>(this.usedPrefab, (Transform) null);
    itemHolderPetUsed.transform.position = this.transform.position;
    itemHolderPetUsed.transform.eulerAngles = this.transform.eulerAngles;
    itemHolderPetUsed.SetUp(this.head.sprite);
  }
}
