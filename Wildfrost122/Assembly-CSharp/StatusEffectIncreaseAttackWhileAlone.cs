// Decompiled with JetBrains decompiler
// Type: StatusEffectIncreaseAttackWhileAlone
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections.Generic;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Traits/Increase Attack While Alone", fileName = "Increase Attack While Alone")]
public class StatusEffectIncreaseAttackWhileAlone : StatusEffectData
{
  [SerializeField]
  private bool active;
  [SerializeField]
  private int currentBonus;

  public override bool RunCardMoveEvent(Entity entity)
  {
    if ((Object) entity == (Object) this.target && this.active && !this.CanTrigger())
      this.Deactivate();
    else if ((((IList<CardContainer>) entity.preContainers).ContainsAny<CardContainer>((IEnumerable<CardContainer>) this.target.containers) || ((IList<CardContainer>) this.target.containers).ContainsAny<CardContainer>((IEnumerable<CardContainer>) entity.containers)) && this.CanTrigger())
      this.Check();
    return false;
  }

  public override bool RunEnableEvent(Entity entity)
  {
    this.Check();
    return false;
  }

  public override bool RunEntityDestroyedEvent(Entity entity, DeathType deathType)
  {
    if (this.CanTrigger())
      this.Check();
    return false;
  }

  public override bool RunEffectBonusChangedEvent()
  {
    if (this.active)
    {
      this.Deactivate();
      this.Activate();
    }
    return false;
  }

  private void Check()
  {
    int num = this.CountOthersInMyRows();
    if (!this.active)
    {
      if (num > 0)
        return;
      this.Activate();
    }
    else
    {
      if (num <= 0)
        return;
      this.Deactivate();
    }
  }

  public override bool HasStackRoutine => this.active;

  public override bool RunStackEvent(int stacks)
  {
    if (this.active)
    {
      this.currentBonus += stacks;
      this.target.tempDamage += stacks;
      this.target.PromptUpdate();
    }
    return false;
  }

  private int CountOthersInMyRows()
  {
    int num = 0;
    foreach (CardContainer container in this.target.containers)
    {
      foreach (Entity entity in container)
      {
        if (entity.IsAliveAndExists() && (Object) entity != (Object) this.target)
          ++num;
      }
    }
    return num;
  }

  private void Activate()
  {
    this.active = true;
    this.currentBonus = this.GetAmount();
    this.target.tempDamage += this.currentBonus;
    this.target.PromptUpdate();
  }

  private void Deactivate()
  {
    this.active = false;
    this.target.tempDamage -= this.currentBonus;
    this.target.PromptUpdate();
  }

  protected override bool CanTrigger() => base.CanTrigger() && Battle.IsOnBoard(this.target);
}
