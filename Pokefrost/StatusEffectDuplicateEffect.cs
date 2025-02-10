// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectDuplicateEffect
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectDuplicateEffect : StatusEffectApplyX
  {
    private int chain = 0;
    private int maxChain = 3;
    private Dictionary<string, Vector2Int> amounts = new Dictionary<string, Vector2Int>();
    public StatusEffectApplyX.ApplyToFlags whenAppliedFlags;
    public bool debuffsOnly = false;
    public bool instantCustom = false;

    public override void Init()
    {
      this.PostApplyStatus += new StatusEffectData.EffectApplyEventHandler(this.Copy);
    }

    public override bool RunApplyStatusEvent(StatusEffectApply apply)
    {
      if (!(bool) (UnityEngine.Object) apply.applier || (UnityEngine.Object) apply.applier == (UnityEngine.Object) this.target || !(bool) (UnityEngine.Object) apply.target || !(bool) (UnityEngine.Object) apply.effectData || apply.effectData.type.IsNullOrWhitespace() || this.target.silenced || (!apply.effectData.isStatus || !apply.effectData.offensive || !apply.effectData.visible) && this.debuffsOnly || !this.GetAppliedTargets().Contains(apply.target))
        return false;
      this.amounts[apply.effectData.type] = this.CurrentAmounts(apply.target, apply.effectData.type);
      Debug.Log((object) ("[Pokefrost] " + apply.effectData.type));
      return false;
    }

    public List<Entity> GetAppliedTargets()
    {
      StatusEffectApplyX.ApplyToFlags applyToFlags = this.applyToFlags;
      this.applyToFlags = this.whenAppliedFlags;
      List<Entity> targets = this.GetTargets();
      this.applyToFlags = applyToFlags;
      return targets;
    }

    private IEnumerator Copy(StatusEffectApply apply)
    {
      ++this.chain;
      if (this.chain != this.maxChain)
      {
        StatusEffectApplyXInstant effect;
        int num;
        if (this.instantCustom)
        {
          effect = this.effectToApply as StatusEffectApplyXInstant;
          num = effect != null ? 1 : 0;
        }
        else
          num = 0;
        if (num != 0)
          effect.effectToApply = apply.effectData;
        else
          this.effectToApply = apply.effectData;
        yield return (object) this.Run(this.GetTargets(), apply.count);
        this.chain = 0;
      }
    }

    public override bool RunPostApplyStatusEvent(StatusEffectApply apply)
    {
      Vector2Int vector2Int1;
      if (!(bool) (UnityEngine.Object) apply.applier || (UnityEngine.Object) apply.applier == (UnityEngine.Object) this.target || !(bool) (UnityEngine.Object) apply.target || !(bool) (UnityEngine.Object) apply.effectData || apply.effectData.type.IsNullOrWhitespace() || this.target.silenced || !this.GetAppliedTargets().Contains(apply.target) || !this.amounts.TryGetValue(apply.effectData.type, out vector2Int1))
        return false;
      Vector2Int vector2Int2 = this.CurrentAmounts(apply.target, apply.effectData.type);
      if (vector2Int2.x - vector2Int1.x - (vector2Int2.y - vector2Int1.y) <= 0 && vector2Int2.x - vector2Int1.x != 0)
        return false;
      this.amounts.Remove(apply.effectData.type);
      return true;
    }

    protected Vector2Int CurrentAmounts(Entity frontAlly, string effectType)
    {
      StatusEffectData statusEffectData = frontAlly.statusEffects.FirstOrDefault<StatusEffectData>((Func<StatusEffectData, bool>) (s => s.type == effectType));
      return (UnityEngine.Object) statusEffectData == (UnityEngine.Object) null ? Vector2Int.zero : new Vector2Int(statusEffectData.count, statusEffectData.temporary);
    }
  }
}
