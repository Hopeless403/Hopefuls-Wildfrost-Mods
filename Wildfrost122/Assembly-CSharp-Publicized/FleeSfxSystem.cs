// Decompiled with JetBrains decompiler
// Type: FleeSfxSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

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
  public float globalChance = 1f;
  [SerializeField]
  public FleeSfxSystem.Profile[] profiles;
  [SerializeField]
  public EventReference fallbackEnemy;
  [SerializeField]
  public EventReference fallbackPlayer;
  [SerializeField]
  public CardData[] excludeFromFallback;
  public readonly Dictionary<string, FleeSfxSystem.Profile> profileLookup = new Dictionary<string, FleeSfxSystem.Profile>();

  public void OnEnable()
  {
    global::Events.OnEntityFlee += new UnityAction<Entity>(this.EntityFlee);
    this.profileLookup.Clear();
    foreach (FleeSfxSystem.Profile profile in this.profiles)
    {
      foreach (UnityEngine.Object card in profile.cards)
        this.profileLookup[card.name] = profile;
    }
  }

  public void OnDisable() => global::Events.OnEntityFlee -= new UnityAction<Entity>(this.EntityFlee);

  public void EntityFlee(Entity entity)
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

  public static bool CheckChance(float chance)
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
