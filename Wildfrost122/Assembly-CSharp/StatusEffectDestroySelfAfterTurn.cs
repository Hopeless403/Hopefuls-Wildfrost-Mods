// Decompiled with JetBrains decompiler
// Type: StatusEffectDestroySelfAfterTurn
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Specific/Destroy Self After Turn", fileName = "Destroy Self After Turn")]
public class StatusEffectDestroySelfAfterTurn : StatusEffectData
{
  private bool cardPlayed;

  public override bool RunCardPlayedEvent(Entity entity, Entity[] targets)
  {
    if (!this.cardPlayed && (Object) entity == (Object) this.target && !this.target.silenced)
    {
      ActionQueue.Add((PlayAction) new ActionKill(entity));
      this.cardPlayed = true;
    }
    return false;
  }
}
