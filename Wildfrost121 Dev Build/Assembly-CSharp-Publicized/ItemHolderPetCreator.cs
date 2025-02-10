// Decompiled with JetBrains decompiler
// Type: ItemHolderPetCreator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
public class ItemHolderPetCreator : MonoBehaviour
{
  [SerializeField]
  public Entity owner;
  public ItemHolderPet currentPet;

  public void Create(ItemHolderPet prefab)
  {
    this.DestroyCurrent();
    this.currentPet = Object.Instantiate<ItemHolderPet>(prefab, this.transform);
    this.currentPet.owner = this.owner;
    this.currentPet.Show();
  }

  public void DestroyCurrent()
  {
    if (!(bool) (Object) this.currentPet)
      return;
    this.currentPet.gameObject.Destroy();
  }

  public void Used()
  {
    if (!(bool) (Object) this.currentPet)
      return;
    this.currentPet.Used();
  }
}
