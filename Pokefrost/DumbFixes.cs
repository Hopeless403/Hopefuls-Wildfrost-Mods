// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectWhileInHandXUpdate
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System.Collections;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectWhileInHandXUpdate : StatusEffectWhileInHandX
  {
    public bool removeOnPlay = false;

    public override bool HasCardPlayedRoutine => this.removeOnPlay;

    public override IEnumerator BeginRoutine()
    {
      yield return (object) base.BeginRoutine();
      this.target.display.promptUpdateDescription = true;
      this.target.PromptUpdate();
    }

    public override IEnumerator CardPlayedRoutine(Entity entity, Entity[] targets)
    {
      Debug.Log((object) "[Curse] Card Played");
      if ((Object) entity == (Object) this.target && this.removeOnPlay)
      {
        yield return (object) this.CountDown(this.target, this.count);
        entity.statusEffects.Remove((StatusEffectData) this);
        this.target.display.promptUpdateDescription = true;
        this.target.PromptUpdate();
        Debug.Log((object) "[Curse] Removed... maybe");
      }
    }
  }
}
