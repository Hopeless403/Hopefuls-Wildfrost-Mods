// Decompiled with JetBrains decompiler
// Type: StatusEffectDestroySelfAfterTurn
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Specific/Destroy Self After Turn", fileName = "Destroy Self After Turn")]
public class StatusEffectDestroySelfAfterTurn : StatusEffectData
{
  public bool cardPlayed;

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
