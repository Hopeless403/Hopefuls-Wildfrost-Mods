// Decompiled with JetBrains decompiler
// Type: DeathSfxSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using Dead;
using FMODUnity;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class DeathSfxSystem : GameSystem
{
  [SerializeField]
  public float globalChance = 0.1f;
  [SerializeField]
  public float globalChanceAdd = 0.02f;
  [SerializeField]
  public DeathSfxSystem.Profile[] profiles;
  public float currentGlobalChance;
  public readonly Dictionary<string, Tuple<DeathSfxSystem.Profile, float>> profileLookup = new Dictionary<string, Tuple<DeathSfxSystem.Profile, float>>();

  public void OnEnable()
  {
    this.currentGlobalChance = this.globalChance;
    global::Events.OnEntityKilled += new UnityAction<Entity, DeathType>(this.EntityKilled);
    this.profileLookup.Clear();
    foreach (DeathSfxSystem.Profile profile in this.profiles)
    {
      foreach (DeathSfxSystem.CardRef card in profile.cards)
        this.profileLookup[card.card.name] = new Tuple<DeathSfxSystem.Profile, float>(profile, card.pitchShift);
    }
  }

  public void OnDisable()
  {
    global::Events.OnEntityKilled -= new UnityAction<Entity, DeathType>(this.EntityKilled);
  }

  public void EntityKilled(Entity entity, DeathType deathType)
  {
    Tuple<DeathSfxSystem.Profile, float> tuple;
    if (!this.profileLookup.TryGetValue(entity.data.name, out tuple))
      return;
    DeathSfxSystem.Profile profile = tuple.Item1;
    float num1 = tuple.Item2;
    if (!this.CheckChance(profile.chance))
      return;
    int num2 = (int) SfxSystem.OneShot(profile.eventReference).setPitch(1f + num1);
  }

  public bool CheckChance(float chance)
  {
    if ((double) PettyRandom.Range(0.0f, 1f) < (double) chance * (double) this.currentGlobalChance)
    {
      this.currentGlobalChance = this.globalChance;
      return true;
    }
    this.currentGlobalChance += this.globalChanceAdd;
    return false;
  }

  [Serializable]
  public class Profile
  {
    public EventReference eventReference;
    public DeathSfxSystem.CardRef[] cards;
    public float chance;
  }

  [Serializable]
  public class CardRef
  {
    public CardData card;
    public float pitchShift;
  }
}
