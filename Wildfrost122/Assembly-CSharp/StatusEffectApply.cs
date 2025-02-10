// Decompiled with JetBrains decompiler
// Type: StatusEffectApply
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

#nullable disable
public class StatusEffectApply
{
  public Entity applier;
  public Entity target;
  public StatusEffectData effectData;
  public int count;

  public StatusEffectApply(Entity applier, Entity target, StatusEffectData effectData, int count)
  {
    this.applier = applier;
    this.target = target;
    this.effectData = effectData;
    this.count = count;
  }
}
