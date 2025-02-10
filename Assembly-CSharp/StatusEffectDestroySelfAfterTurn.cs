// Decompiled with JetBrains decompiler
// Type: StatusEffectDestroySelfAfterTurn
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

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
