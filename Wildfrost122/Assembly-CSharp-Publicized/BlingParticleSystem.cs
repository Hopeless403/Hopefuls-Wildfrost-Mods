// Decompiled with JetBrains decompiler
// Type: BlingParticleSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using Dead;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class BlingParticleSystem : GameSystem
{
  [SerializeField]
  public BlingParticle blingPrefab;
  [SerializeField]
  public int initialPoolSize = 20;
  [SerializeField]
  public Sprite lowValueSprite;
  [SerializeField]
  public Sprite highValueSprite;
  [SerializeField]
  public int highValueAmount = 5;
  public readonly Queue<BlingParticle> pool = new Queue<BlingParticle>();

  public void Start()
  {
    for (int index = 0; index < this.initialPoolSize; ++index)
      this.Pool(Object.Instantiate<BlingParticle>(this.blingPrefab, this.transform));
  }

  public void OnEnable()
  {
    global::Events.OnDropGold += new UnityAction<int, string, Character, Vector3>(this.DropGold);
  }

  public void OnDisable()
  {
    global::Events.OnDropGold -= new UnityAction<int, string, Character, Vector3>(this.DropGold);
  }

  public void DropGold(int amount, string source, Character owner, Vector3 position)
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

  public BlingParticle Get()
  {
    return this.pool.Count > 0 ? this.pool.Dequeue() : Object.Instantiate<BlingParticle>(this.blingPrefab, this.transform);
  }

  public void Pool(BlingParticle particle)
  {
    particle.gameObject.SetActive(false);
    this.pool.Enqueue(particle);
  }
}
