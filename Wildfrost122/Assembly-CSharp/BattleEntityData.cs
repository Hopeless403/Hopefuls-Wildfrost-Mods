// Decompiled with JetBrains decompiler
// Type: BattleEntityData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Linq;

#nullable disable
[Serializable]
public class BattleEntityData
{
  public CardSaveData cardSaveData;
  public int height;
  public int damage;
  public int damageMax;
  public int hp;
  public int hpMax;
  public int counter;
  public int counterMax;
  public int uses;
  public int usesMax;
  public bool flipped;
  public StatusEffectSaveData[] attackEffects;

  public BattleEntityData()
  {
  }

  public BattleEntityData(Entity entity)
  {
    this.cardSaveData = entity.data.Save();
    this.height = entity.height;
    this.damage = entity.damage.current;
    this.damageMax = entity.damage.max;
    this.hp = entity.hp.current;
    this.hpMax = entity.hp.max;
    this.counter = entity.counter.current;
    this.counterMax = entity.counter.max;
    this.uses = entity.uses.current;
    this.usesMax = entity.uses.max;
    this.flipped = !entity.enabled;
    this.attackEffects = entity.attackEffects.Select<CardData.StatusEffectStacks, StatusEffectSaveData>((Func<CardData.StatusEffectStacks, StatusEffectSaveData>) (a => a.Save())).ToArray<StatusEffectSaveData>();
  }
}
