// Decompiled with JetBrains decompiler
// Type: TutorialCompanionSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

#nullable disable
public class TutorialCompanionSystem : GameSystem
{
  public EventRoutineCompanion companionEvent;
  public bool init;
  public bool waitForBreak = true;
  public bool waitForInspect;
  public bool inspectDone;
  public float promptDelay;
  public bool prompt2Show;

  public void OnEnable()
  {
    global::Events.OnCheckAction += new global::Events.UnityActionRef<PlayAction, bool>(this.CheckAction);
    global::Events.OnEventStart += new UnityAction<CampaignNode, EventRoutine>(this.EventStart);
    global::Events.OnInspect += new UnityAction<Entity>(this.Inspected);
    global::Events.OnActionPerform += new UnityAction<PlayAction>(this.ActionPerformed);
    global::Events.OnSceneChanged += new UnityAction<Scene>(this.SceneChanged);
  }

  public void OnDisable()
  {
    global::Events.OnCheckAction -= new global::Events.UnityActionRef<PlayAction, bool>(this.CheckAction);
    global::Events.OnEventStart -= new UnityAction<CampaignNode, EventRoutine>(this.EventStart);
    global::Events.OnInspect -= new UnityAction<Entity>(this.Inspected);
    global::Events.OnActionPerform -= new UnityAction<PlayAction>(this.ActionPerformed);
    global::Events.OnSceneChanged -= new UnityAction<Scene>(this.SceneChanged);
    PromptSystem.Hide();
  }

  public void Init(EventRoutineCompanion companionEvent)
  {
    this.init = true;
    this.companionEvent = companionEvent;
    this.waitForBreak = true;
    this.waitForInspect = false;
    this.inspectDone = false;
  }

  public void Update()
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

  public void CheckAction(ref PlayAction action, ref bool allow)
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

  public void EventStart(CampaignNode node, EventRoutine @event)
  {
    if (!(@event is EventRoutineCompanion companionEvent))
      return;
    this.Init(companionEvent);
  }

  public void Inspected(Entity entity)
  {
    if (!this.waitForInspect || this.inspectDone)
      return;
    this.inspectDone = true;
    PromptSystem.Hide();
  }

  public void ActionPerformed(PlayAction action)
  {
    if (!(action is ActionSelect))
      return;
    PromptSystem.Hide();
    this.prompt2Show = false;
  }

  public void SceneChanged(Scene scene) => Object.Destroy((Object) this);
}
