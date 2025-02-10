// Decompiled with JetBrains decompiler
// Type: ItemHolderPet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
public class ItemHolderPet : MonoBehaviour
{
  public Entity owner;

  public virtual void Show()
  {
    if (this.gameObject.activeSelf)
      return;
    this.gameObject.SetActive(true);
  }

  public virtual void Used() => this.gameObject.Destroy();
}
