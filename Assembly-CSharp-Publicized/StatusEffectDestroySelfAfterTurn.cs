// Decompiled with JetBrains decompiler
// Type: StatusEffectDestroySelfAfterTurn
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

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
