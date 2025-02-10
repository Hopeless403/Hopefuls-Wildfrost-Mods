// Decompiled with JetBrains decompiler
// Type: StatusEffectSilence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Silence", fileName = "Silence")]
public class StatusEffectSilence : StatusEffectData
{
  public override void Init()
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

  public IEnumerator CustomCountDown(Entity entity)
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
