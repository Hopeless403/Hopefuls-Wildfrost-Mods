// Decompiled with JetBrains decompiler
// Type: ItemHolderPetCreator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
public class ItemHolderPetCreator : MonoBehaviour
{
  [SerializeField]
  private Entity owner;
  private ItemHolderPet currentPet;

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
