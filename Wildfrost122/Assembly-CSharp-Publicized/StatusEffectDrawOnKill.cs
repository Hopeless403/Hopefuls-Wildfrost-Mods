// Decompiled with JetBrains decompiler
// Type: StatusEffectDrawOnKill
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Specific/Draw On Kill", fileName = "Draw On Kill")]
public class StatusEffectDrawOnKill : StatusEffectData
{
  public override bool RunEntityDestroyedEvent(Entity entity, DeathType deathType)
  {
    if (entity.lastHit != null && (Object) entity.lastHit.attacker == (Object) this.target)
      ActionQueue.Stack((PlayAction) new ActionDraw(this.target.owner, this.GetAmount()));
    return false;
  }
}
