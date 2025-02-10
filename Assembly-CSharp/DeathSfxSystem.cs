// Decompiled with JetBrains decompiler
// Type: DeathSfxSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using Dead;
using FMODUnity;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DeathSfxSystem : GameSystem
{
  [SerializeField]
  private float globalChance = 0.1f;
  [SerializeField]
  private float globalChanceAdd = 0.02f;
  [SerializeField]
  private DeathSfxSystem.Profile[] profiles;
  private float currentGlobalChance;
  private readonly Dictionary<string, Tuple<DeathSfxSystem.Profile, float>> profileLookup = new Dictionary<string, Tuple<DeathSfxSystem.Profile, float>>();

  private void OnEnable()
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

  private void OnDisable() => global::Events.OnEntityKilled -= new UnityAction<Entity, DeathType>(this.EntityKilled);

  private void EntityKilled(Entity entity, DeathType deathType)
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

  private bool CheckChance(float chance)
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
