// Decompiled with JetBrains decompiler
// Type: StatusEffectCannotBeRecalled
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Traits/Cannot Recall", fileName = "Cannot Recall")]
public class StatusEffectCannotBeRecalled : StatusEffectData
{
  private bool active;

  public override bool RunBeginEvent()
  {
    if (!this.active && (bool) (Object) this.target && this.GetAmount() > 0)
      this.Activate();
    return false;
  }

  public override bool RunEndEvent()
  {
    if (this.active && (bool) (Object) this.target)
      this.Deactivate();
    return false;
  }

  public override bool RunEffectBonusChangedEvent()
  {
    if ((bool) (Object) this.target)
    {
      int amount = this.GetAmount();
      if (amount > 0 && !this.active)
        this.Activate();
      else if (amount <= 0 && this.active)
        this.Deactivate();
    }
    return false;
  }

  private void Activate()
  {
    ++this.target.blockRecall;
    this.active = true;
  }

  private void Deactivate()
  {
    --this.target.blockRecall;
    this.active = false;
  }
}
