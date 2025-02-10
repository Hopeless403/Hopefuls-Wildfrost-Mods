// Decompiled with JetBrains decompiler
// Type: StatusEffectApply
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

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
