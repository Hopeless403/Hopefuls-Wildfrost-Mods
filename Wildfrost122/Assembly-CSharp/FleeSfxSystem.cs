// Decompiled with JetBrains decompiler
// Type: FleeSfxSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using Dead;
using FMODUnity;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class FleeSfxSystem : GameSystem
{
  [SerializeField]
  private float globalChance = 1f;
  [SerializeField]
  private FleeSfxSystem.Profile[] profiles;
  [SerializeField]
  private EventReference fallbackEnemy;
  [SerializeField]
  private EventReference fallbackPlayer;
  [SerializeField]
  private CardData[] excludeFromFallback;
  private readonly Dictionary<string, FleeSfxSystem.Profile> profileLookup = new Dictionary<string, FleeSfxSystem.Profile>();

  private void OnEnable()
  {
    global::Events.OnEntityFlee += new UnityAction<Entity>(this.EntityFlee);
    this.profileLookup.Clear();
    foreach (FleeSfxSystem.Profile profile in this.profiles)
    {
      foreach (UnityEngine.Object card in profile.cards)
        this.profileLookup[card.name] = profile;
    }
  }

  private void OnDisable() => global::Events.OnEntityFlee -= new UnityAction<Entity>(this.EntityFlee);

  private void EntityFlee(Entity entity)
  {
    FleeSfxSystem.Profile profile;
    if (this.profileLookup.TryGetValue(entity.data.name, out profile))
    {
      if (!FleeSfxSystem.CheckChance(profile.chance * this.globalChance))
        return;
      SfxSystem.OneShot(profile.eventReference);
    }
    else
    {
      if (!((IEnumerable<CardData>) this.excludeFromFallback).All<CardData>((Func<CardData, bool>) (a => a.name != entity.data.name)) || !FleeSfxSystem.CheckChance(this.globalChance))
        return;
      SfxSystem.OneShot(entity.owner.team == References.Player.team ? this.fallbackPlayer : this.fallbackEnemy);
      SfxSystem.OneShot(this.fallbackEnemy);
    }
  }

  private static bool CheckChance(float chance)
  {
    return (double) PettyRandom.Range(0.0f, 1f) < (double) chance;
  }

  [Serializable]
  public class Profile
  {
    public EventReference eventReference;
    public CardData[] cards;
    public float chance;
  }
}
