// Decompiled with JetBrains decompiler
// Type: TutorialCompanionSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

#nullable disable
public class TutorialCompanionSystem : GameSystem
{
  private EventRoutineCompanion companionEvent;
  private bool init;
  private bool waitForBreak = true;
  private bool waitForInspect;
  private bool inspectDone;
  private float promptDelay;
  private bool prompt2Show;

  private void OnEnable()
  {
    global::Events.OnCheckAction += new global::Events.UnityActionRef<PlayAction, bool>(this.CheckAction);
    global::Events.OnEventStart += new UnityAction<CampaignNode, EventRoutine>(this.EventStart);
    global::Events.OnInspect += new UnityAction<Entity>(this.Inspected);
    global::Events.OnActionPerform += new UnityAction<PlayAction>(this.ActionPerformed);
    global::Events.OnSceneChanged += new UnityAction<Scene>(this.SceneChanged);
  }

  private void OnDisable()
  {
    global::Events.OnCheckAction -= new global::Events.UnityActionRef<PlayAction, bool>(this.CheckAction);
    global::Events.OnEventStart -= new UnityAction<CampaignNode, EventRoutine>(this.EventStart);
    global::Events.OnInspect -= new UnityAction<Entity>(this.Inspected);
    global::Events.OnActionPerform -= new UnityAction<PlayAction>(this.ActionPerformed);
    global::Events.OnSceneChanged -= new UnityAction<Scene>(this.SceneChanged);
    PromptSystem.Hide();
  }

  private void Init(EventRoutineCompanion companionEvent)
  {
    this.init = true;
    this.companionEvent = companionEvent;
    this.waitForBreak = true;
    this.waitForInspect = false;
    this.inspectDone = false;
  }

  private void Update()
  {
    if (this.init && this.waitForBreak && (Object) this.companionEvent != (Object) null && this.companionEvent.broken)
    {
      this.waitForBreak = false;
      this.waitForInspect = true;
      this.promptDelay = 1f;
    }
    if ((double) this.promptDelay <= 0.0)
      return;
    this.promptDelay -= Time.deltaTime;
    if ((double) this.promptDelay > 0.0)
      return;
    PromptSystem.Create(Prompt.Anchor.TopLeft, 1f, -3f, 5f, Prompt.Emote.Type.Explain);
    PromptSystem.SetTextAction((Prompt.GetTextCallback) (() =>
    {
      if (!MonoBehaviourSingleton<Cursor3d>.instance.usingMouse)
        return ControllerButtonSystem.ProcessActionTags(MonoBehaviourSingleton<StringReference>.instance.tutorialCompanion1Gamepad);
      return !TouchInputModule.active ? ControllerButtonSystem.ProcessActionTags(MonoBehaviourSingleton<StringReference>.instance.tutorialCompanion1) : ControllerButtonSystem.ProcessActionTags(MonoBehaviourSingleton<StringReference>.instance.tutorialCompanion1Touch);
    }));
  }

  private void CheckAction(ref PlayAction action, ref bool allow)
  {
    if (!this.inspectDone)
    {
      if (action is ActionInspect)
        return;
      allow = false;
      PromptSystem.Shake();
    }
    else
    {
      if (!(action is ActionSelect actionSelect) || !((Object) actionSelect.entity == (Object) null))
        return;
      allow = false;
      if (this.prompt2Show)
      {
        PromptSystem.Shake();
      }
      else
      {
        PromptSystem.Create(Prompt.Anchor.Left, 1f, 1f, 5f);
        PromptSystem.SetTextAction((Prompt.GetTextCallback) (() => MonoBehaviourSingleton<StringReference>.instance.tutorialCompanion2.GetLocalizedString()));
        this.prompt2Show = true;
      }
    }
  }

  private void EventStart(CampaignNode node, EventRoutine @event)
  {
    if (!(@event is EventRoutineCompanion companionEvent))
      return;
    this.Init(companionEvent);
  }

  private void Inspected(Entity entity)
  {
    if (!this.waitForInspect || this.inspectDone)
      return;
    this.inspectDone = true;
    PromptSystem.Hide();
  }

  private void ActionPerformed(PlayAction action)
  {
    if (!(action is ActionSelect))
      return;
    PromptSystem.Hide();
    this.prompt2Show = false;
  }

  private void SceneChanged(Scene scene) => Object.Destroy((Object) this);
}
