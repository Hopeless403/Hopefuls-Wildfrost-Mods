// Decompiled with JetBrains decompiler
// Type: Pokefrost.TicketTimerModifierSystem
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using Deadpan.Enums.Engine.Components.Modding;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Localization;

#nullable disable
namespace Pokefrost
{
  public class TicketTimerModifierSystem : QuestSystem
  {
    public static string Key_Slow = "websiteofsites.wildfrost.pokefrost.tooslow";
    private Timer timer;

    public override string ProgressName => "TickTock";

    [PokeLocalizer]
    public new static void DefineStrings()
    {
      LocalizationHelper.GetCollection("UI Text", (LocaleIdentifier) SystemLanguage.English).SetString(TicketTimerModifierSystem.Key_Slow, "The ship has departed...");
    }

    public void OnEnable()
    {
      global::Events.OnBattlePreTurnStart += new UnityAction<int>(this.StartTimer);
      global::Events.OnBattleTurnEnd += new UnityAction<int>(this.ReadTime);
      global::Events.OnBattleEnd += new UnityAction(this.PauseTimer);
      this.progress = 900;
      this.FindProgress();
      if (this.progress <= 0)
        return;
      this.MakeTimer();
    }

    public void OnDisable()
    {
      global::Events.OnBattlePreTurnStart -= new UnityAction<int>(this.StartTimer);
      global::Events.OnBattleTurnEnd -= new UnityAction<int>(this.ReadTime);
      global::Events.OnBattleEnd -= new UnityAction(this.PauseTimer);
      if (!(bool) (Object) this.timer)
        return;
      this.timer.End();
    }

    private void PauseTimer()
    {
      if (!(bool) (Object) this.timer)
      {
        this.progress = 0;
      }
      else
      {
        this.timer.Stop();
        this.ReadTime(420);
      }
    }

    private void StartTimer(int _)
    {
      if (!(bool) (Object) this.timer)
        this.progress = 0;
      else
        this.timer.Play();
    }

    private void ReadTime(int _)
    {
      if (!(bool) (Object) this.timer)
        this.progress = 0;
      else
        this.UpdateProgress((int) this.timer.Time);
    }

    public void MakeTimer()
    {
      if (!(bool) (Object) this.timer)
        this.timer = Timer.Create((float) this.progress);
      this.timer.SetTime((float) this.progress);
    }

    public override bool CheckConditions(out string failureText)
    {
      failureText = this.GetFailureText(TicketTimerModifierSystem.Key_Slow);
      Debug.Log((object) string.Format("[Pokefrost] Checking Progress... {0}", (object) this.progress));
      return this.progress > 0;
    }

    public override void QuestBattleStart()
    {
      this.Disable();
      this.timer.End();
    }

    public override void QuestBattleFinish() => this.UpdateProgress(0);
  }
}
