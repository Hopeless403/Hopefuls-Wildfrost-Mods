// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectTransfer
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System.Collections;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectTransfer : StatusEffectApplyXInstant
  {
    public override void Init()
    {
      this.OnBegin += new StatusEffectData.EffectEventHandler(((StatusEffectApplyXInstant) this).Process);
      this.OnEnd += new StatusEffectData.EffectEventHandler(this.RemoveEffects);
    }

    public IEnumerator RemoveEffects()
    {
      if (this.effectToApply.GetType() == typeof (StatusEffectMultEffects))
      {
        StatusEffectMultEffects effs = this.effectToApply as StatusEffectMultEffects;
        for (int i = 0; i < effs.effects.Count; ++i)
        {
          for (int j = this.target.statusEffects.Count - 1; j >= 0; --j)
          {
            if (this.target.statusEffects[j].name == effs.effects[i].name)
            {
              if (this.target.statusEffects[j].GetType() == typeof (StatusEffectWhileActiveX))
              {
                StatusEffectWhileActiveX activeEff = this.target.statusEffects[j] as StatusEffectWhileActiveX;
                if (activeEff.active)
                {
                  Debug.Log((object) "DEACTIVATING");
                  yield return (object) activeEff.Deactivate();
                }
                activeEff = (StatusEffectWhileActiveX) null;
              }
              yield return (object) this.target.statusEffects[j].RemoveStacks(this.GetAmount(), true);
              break;
            }
          }
        }
        this.target.display.promptUpdateDescription = true;
        this.target.PromptUpdate();
        effs = (StatusEffectMultEffects) null;
      }
    }
  }
}
