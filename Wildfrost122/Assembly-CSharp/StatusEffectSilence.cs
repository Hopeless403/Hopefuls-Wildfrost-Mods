// Decompiled with JetBrains decompiler
// Type: StatusEffectSilence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Silence", fileName = "Silence")]
public class StatusEffectSilence : StatusEffectData
{
  protected override void Init()
  {
    this.OnTurnEnd += new StatusEffectData.EffectEntityEventHandler(this.CustomCountDown);
  }

  public override bool RunBeginEvent()
  {
    ++this.target.silenceCount;
    this.target.PromptUpdate();
    return false;
  }

  public override bool RunTurnEndEvent(Entity entity)
  {
    return (Object) entity == (Object) this.target && this.target.enabled;
  }

  private IEnumerator CustomCountDown(Entity entity)
  {
    StatusEffectSilence status = this;
    int amount = 1;
    Events.InvokeStatusEffectCountDown((StatusEffectData) status, ref amount);
    if (amount != 0)
      yield return (object) status.CountDown(entity, amount);
  }

  public override bool RunEndEvent()
  {
    --this.target.silenceCount;
    this.target.PromptUpdate();
    return false;
  }
}
