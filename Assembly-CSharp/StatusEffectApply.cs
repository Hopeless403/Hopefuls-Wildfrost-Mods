// Decompiled with JetBrains decompiler
// Type: StatusEffectApply
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

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
