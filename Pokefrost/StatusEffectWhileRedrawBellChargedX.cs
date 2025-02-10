// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectWhileRedrawBellChargedX
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectWhileRedrawBellChargedX : StatusEffectWhileActiveX
  {
    private RedrawBellSystem bellSystem;

    public override void Init()
    {
      global::Events.OnRedrawBellHit += new UnityAction<RedrawBellSystem>(this.Reset);
      global::Events.OnBattlePreTurnStart += new UnityAction<int>(this.TryActivate);
      base.Init();
    }

    public override void OnDestroy()
    {
      global::Events.OnRedrawBellHit -= new UnityAction<RedrawBellSystem>(this.Reset);
      global::Events.OnBattlePreTurnStart -= new UnityAction<int>(this.TryActivate);
      base.OnDestroy();
    }

    private void Reset(RedrawBellSystem arg0)
    {
      if (!this.active)
        return;
      ActionQueue.Stack((PlayAction) new ActionSequence(this.Deactivate()));
    }

    private void TryActivate(int arg0)
    {
      if (!this.CanActivate() || this.active)
        return;
      ActionQueue.Stack((PlayAction) new ActionSequence(this.Activate()));
    }

    public override bool CanActivate()
    {
      if ((Object) this.bellSystem == (Object) null)
        this.bellSystem = Object.FindObjectOfType<RedrawBellSystem>();
      return this.bellSystem.IsCharged && this.bellSystem.interactable;
    }

    public override bool CheckActivateOnMove(
      CardContainer[] fromContainers,
      CardContainer[] toContainers)
    {
      return false;
    }

    public override bool CheckDeactivateOnMove(
      CardContainer[] fromContainers,
      CardContainer[] toContainers)
    {
      return false;
    }
  }
}
