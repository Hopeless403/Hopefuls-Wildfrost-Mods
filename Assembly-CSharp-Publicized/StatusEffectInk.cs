// Decompiled with JetBrains decompiler
// Type: StatusEffectInk
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Ink", fileName = "Ink")]
public class StatusEffectInk : StatusEffectData
{
  public bool primed;

  public override void Init() => this.OnCardPlayed += new StatusEffectData.EffectCardPlayEventHandler(this.Check);

  public override bool RunPreCardPlayedEvent(Entity entity, Entity[] targets)
  {
    if (!this.primed && this.target.enabled && (Object) entity == (Object) this.target)
      this.primed = true;
    return false;
  }

  public override bool RunCardPlayedEvent(Entity entity, Entity[] targets) => this.primed && this.target.enabled && (Object) entity == (Object) this.target;

  public IEnumerator Check(Entity entity, Entity[] targets)
  {
    // ISSUE: reference to a compiler-generated field
    int num = this.\u003C\u003E1__state;
    StatusEffectInk statusEffectInk = this;
    if (num != 0)
    {
      if (num != 1)
        return false;
      // ISSUE: reference to a compiler-generated field
      this.\u003C\u003E1__state = -1;
      return false;
    }
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = -1;
    Hit hit = new Hit(statusEffectInk.target, statusEffectInk.target);
    hit.AddAttackerStatuses();
    ActionQueue.Stack((PlayAction) new ActionSequence(statusEffectInk.CountDown()), true);
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E2__current = (object) hit.Process();
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = 1;
    return true;
  }

  public IEnumerator CountDown()
  {
    StatusEffectInk status = this;
    int amount = 1;
    Events.InvokeStatusEffectCountDown((StatusEffectData) status, ref amount);
    if (amount != 0)
      yield return (object) status.CountDown(status.target, amount);
  }
}
