// Decompiled with JetBrains decompiler
// Type: Pokefrost.InitialBellCounterReductionModifierSystem
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace Pokefrost
{
  public class InitialBellCounterReductionModifierSystem : GameSystem
  {
    private Timer timer;
    private int preCounter;
    private bool active = false;

    public void OnEnable()
    {
      global::Events.OnBattleStart += new UnityAction(this.CreateTimer);
      global::Events.OnBattlePreTurnStart += new UnityAction<int>(this.StartTimer);
      global::Events.OnBattleEnd += new UnityAction(this.HideTimer);
    }

    public void OnDisable()
    {
      global::Events.OnBattleStart -= new UnityAction(this.CreateTimer);
      global::Events.OnBattlePreTurnStart -= new UnityAction<int>(this.StartTimer);
      global::Events.OnBattleEnd -= new UnityAction(this.HideTimer);
      if (!(bool) (Object) this.timer)
        return;
      this.timer.End();
    }

    private void HideTimer()
    {
      if (!(bool) (Object) this.timer)
        return;
      this.timer.Hide();
    }

    private void StartTimer(int turn)
    {
      if (!(bool) (Object) this.timer || turn != 0)
        return;
      this.Activate();
    }

    private void CreateTimer()
    {
      if (!(bool) (Object) this.timer)
      {
        this.timer = Timer.Create(60f);
        this.timer.OnFinished += new UnityAction(this.Deactivate);
      }
      else
      {
        this.timer.SetTime(60f);
        this.timer.Show();
      }
    }

    public void Activate()
    {
      if (this.active)
        return;
      RedrawBellSystem objectOfType = Object.FindObjectOfType<RedrawBellSystem>();
      this.preCounter = objectOfType.counter.max;
      objectOfType.counter.max = 1;
      if (objectOfType.counter.current > 1)
      {
        objectOfType.counter.current = 1;
        objectOfType.SetCounter(objectOfType.counter.current);
      }
      this.timer.Play();
      this.active = true;
    }

    public void Deactivate()
    {
      if (!this.active)
        return;
      Object.FindObjectOfType<RedrawBellSystem>().counter.max = this.preCounter;
      Debug.Log((object) "[Pokefrost] Set max.");
      this.timer.Stop();
      this.timer.Hide();
      this.active = false;
    }
  }
}
