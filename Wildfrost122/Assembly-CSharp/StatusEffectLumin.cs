// Decompiled with JetBrains decompiler
// Type: StatusEffectLumin
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Lumin", fileName = "Lumin")]
public class StatusEffectLumin : StatusEffectData
{
  public override bool RunPostApplyStatusEvent(StatusEffectApply apply)
  {
    if ((bool) (Object) apply.effectData && apply.count > 0 && apply.effectData.type == this.type && (Object) apply.target != (Object) this.target)
    {
      ActionSequence action = new ActionSequence(this.Remove());
      action.note = "Remove Lumin from [" + this.target.name + "]";
      ActionQueue.Stack((PlayAction) action, true);
    }
    return false;
  }

  public override bool RunBeginEvent()
  {
    ++this.target.effectFactor;
    return false;
  }

  public override bool RunEndEvent()
  {
    --this.target.effectFactor;
    return false;
  }
}
