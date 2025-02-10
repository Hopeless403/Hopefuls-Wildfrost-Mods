// Decompiled with JetBrains decompiler
// Type: BossSetUp
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using Dead;
using NaughtyAttributes;
using UnityEngine;

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
