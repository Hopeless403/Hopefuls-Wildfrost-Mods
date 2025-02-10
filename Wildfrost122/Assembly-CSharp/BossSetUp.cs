// Decompiled with JetBrains decompiler
// Type: BossSetUp
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using Dead;
using NaughtyAttributes;
using UnityEngine;

#nullable disable
public class BossSetUp : MonoBehaviour
{
  public CharacterAvatar avatarPrefab;
  public CardData cardData;
  [SerializeField]
  [Required(null)]
  private Entity entity;
  [SerializeField]
  [Required(null)]
  private Character character;

  private void Awake() => this.SetUp();

  public void SetUp()
  {
    this.entity.random3 = PettyRandom.Vector3();
    this.entity.data = this.cardData.Clone();
    this.entity.hp.max = this.entity.data.hp;
    this.entity.hp.current = this.entity.hp.max;
    this.entity.data.hasAttack = false;
  }
}
