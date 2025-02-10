// Decompiled with JetBrains decompiler
// Type: BossSetUp
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

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
  public Entity entity;
  [SerializeField]
  [Required(null)]
  public Character character;

  public void Awake() => this.SetUp();

  public void SetUp()
  {
    this.entity.random3 = PettyRandom.Vector3();
    this.entity.data = this.cardData.Clone();
    this.entity.hp.max = this.entity.data.hp;
    this.entity.hp.current = this.entity.hp.max;
    this.entity.data.hasAttack = false;
  }
}
