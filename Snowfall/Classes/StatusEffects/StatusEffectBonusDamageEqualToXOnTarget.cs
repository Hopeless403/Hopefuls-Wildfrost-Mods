// Decompiled with JetBrains decompiler
// Type: Snowfall2.Classes.StatusEffects.StatusEffectBonusDamageEqualToXOnTarget
// Assembly: Snowfall, Version=0.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 26AFE777-3FAB-4D6F-AF6C-494837402D4A
// Assembly location: C:\Users\harri\AppData\Local\Temp\Temp1_Snowfall_-_Alpha_2.1.2.zip\Snowfall.dll

using System.Collections;
using UnityEngine;

namespace Snowfall2.Classes.StatusEffects
{
  public class StatusEffectBonusDamageEqualToXOnTarget : StatusEffectData
  {
    public string effectType;
    public bool ping = true;
    private int currentAmount;
    private bool toReset;

    public override void Init() => this.PreCardPlayed += new StatusEffectData.EffectCardPlayEventHandler(this.Gain);

    public override bool RunPreCardPlayedEvent(Entity entity, Entity[] targets) => (Object) entity == (Object) this.target && !this.toReset && this.CanTrigger();

    public IEnumerator Gain(Entity entity, Entity[] targets)
    {
      Entity[] entityArray = targets;
      for (int index = 0; index < entityArray.Length; ++index)
      {
        Entity target = entityArray[index];
        StatusEffectData statusEffectData = target.FindStatus(this.effectType);
        if (!(bool) (Object) statusEffectData || statusEffectData.count <= 0)
        {
          yield break;
        }
        else
        {
          int inc = statusEffectData.count;
          entity.tempDamage += inc;
          this.currentAmount += inc;
          statusEffectData = (StatusEffectData) null;
          target = (Entity) null;
        }
      }
      entityArray = (Entity[]) null;
      this.toReset = true;
      entity.PromptUpdate();
      if (this.ping)
      {
        double num = (double) this.target.curveAnimator.Ping();
        yield return (object) Sequences.Wait(0.5f);
      }
    }

    public override bool RunTurnEndEvent(Entity entity)
    {
      if ((Object) entity == (Object) this.target.owner.entity && this.toReset)
      {
        this.toReset = false;
        if (this.currentAmount != 0)
        {
          this.target.tempDamage -= this.currentAmount;
          this.currentAmount = 0;
          this.target.PromptUpdate();
        }
      }
      return false;
    }
  }
}
