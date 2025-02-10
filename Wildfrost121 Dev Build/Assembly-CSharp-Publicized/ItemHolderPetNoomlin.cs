// Decompiled with JetBrains decompiler
// Type: ItemHolderPetNoomlin
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using FMODUnity;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class ItemHolderPetNoomlin : ItemHolderPet
{
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
  [Header("SFX")]
  [SerializeField]
  public EventReference showSfx;
  [SerializeField]
  public EventReference usedSfx;

  public override void Show()
  {
    base.Show();
    if ((bool) (Object) this.head && this.headOptions.Length != 0)
      this.head.sprite = this.headOptions[Mathf.RoundToInt((float) this.headOptions.Length * this.owner.data.random3.x).Mod(this.headOptions.Length)];
    this.showTween.Fire();
    this.headWobbler.WobbleRandom();
    if (this.showSfx.IsNull || !this.owner.inPlay)
      return;
    SfxSystem.OneShot(this.showSfx);
  }

  public override void Used()
  {
    base.Used();
    ItemHolderPetUsed itemHolderPetUsed = Object.Instantiate<ItemHolderPetUsed>(this.usedPrefab, (Transform) null);
    itemHolderPetUsed.transform.position = this.transform.position;
    itemHolderPetUsed.transform.eulerAngles = this.transform.eulerAngles;
    itemHolderPetUsed.SetUp(this.head.sprite);
    if (this.usedSfx.IsNull || !this.owner.inPlay)
      return;
    SfxSystem.OneShot(this.usedSfx);
  }
}
