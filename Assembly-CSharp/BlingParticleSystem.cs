// Decompiled with JetBrains decompiler
// Type: BlingParticleSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using Dead;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BlingParticleSystem : GameSystem
{
  [SerializeField]
  private BlingParticle blingPrefab;
  [SerializeField]
  private int initialPoolSize = 20;
  [SerializeField]
  private Sprite lowValueSprite;
  [SerializeField]
  private Sprite highValueSprite;
  [SerializeField]
  private int highValueAmount = 5;
  private readonly Queue<BlingParticle> pool = new Queue<BlingParticle>();

  private void Start()
  {
    for (int index = 0; index < this.initialPoolSize; ++index)
      this.Pool(Object.Instantiate<BlingParticle>(this.blingPrefab, this.transform));
  }

  private void OnEnable() => global::Events.OnDropGold += new UnityAction<int, string, Character, Vector3>(this.DropGold);

  private void OnDisable() => global::Events.OnDropGold -= new UnityAction<int, string, Character, Vector3>(this.DropGold);

  private void DropGold(int amount, string source, Character owner, Vector3 position)
  {
    int num = PettyRandom.Range(3, 5);
    owner.data.inventory.goldOwed += amount;
    BlingParticle blingParticle;
    for (; amount > 0; amount -= blingParticle.value)
    {
      blingParticle = this.Get();
      blingParticle.transform.position = position;
      blingParticle.gameObject.SetActive(true);
      blingParticle.owner = owner;
      if (num > 0 || amount < this.highValueAmount)
      {
        blingParticle.value = 1;
        blingParticle.sprite = this.lowValueSprite;
        --num;
      }
      else
      {
        blingParticle.value = this.highValueAmount;
        blingParticle.sprite = this.highValueSprite;
      }
    }
  }

  private BlingParticle Get() => this.pool.Count > 0 ? this.pool.Dequeue() : Object.Instantiate<BlingParticle>(this.blingPrefab, this.transform);

  public void Pool(BlingParticle particle)
  {
    particle.gameObject.SetActive(false);
    this.pool.Enqueue(particle);
  }
}
