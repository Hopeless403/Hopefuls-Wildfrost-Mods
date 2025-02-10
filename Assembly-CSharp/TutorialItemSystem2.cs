// Decompiled with JetBrains decompiler
// Type: TutorialItemSystem2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class TutorialItemSystem2 : GameSystem
{
  private bool init;
  private ItemEventRoutine itemEvent;
  private bool waitForOpen;
  private float promptDelay;

  private void OnEnable()
  {
    global::Events.OnEventStart += new UnityAction<CampaignNode, EventRoutine>(this.EventStart);
    global::Events.OnActionPerform += new UnityAction<PlayAction>(TutorialItemSystem2.ActionPerformed);
    global::Events.OnSceneChanged += new UnityAction<Scene>(this.SceneChanged);
  }

  private void OnDisable()
  {
    global::Events.OnEventStart -= new UnityAction<CampaignNode, EventRoutine>(this.EventStart);
    global::Events.OnActionPerform -= new UnityAction<PlayAction>(TutorialItemSystem2.ActionPerformed);
    global::Events.OnSceneChanged -= new UnityAction<Scene>(this.SceneChanged);
    PromptSystem.Hide();
  }

  private void Init(ItemEventRoutine itemEvent)
  {
    this.init = true;
    this.itemEvent = itemEvent;
    this.waitForOpen = true;
  }

  private void Update()
  {
    if (this.init && this.waitForOpen && (bool) (Object) this.itemEvent && this.itemEvent.IsOpen)
    {
      this.waitForOpen = false;
      this.promptDelay = 1.5f;
    }
    if ((double) this.promptDelay <= 0.0)
      return;
    this.promptDelay -= Time.deltaTime;
    if ((double) this.promptDelay > 0.0)
      return;
    PromptSystem.Create(Prompt.Anchor.Left, 0.5f, 0.5f, 4f, Prompt.Emote.Type.Explain);
    PromptSystem.SetTextAction((Prompt.GetTextCallback) (() => MonoBehaviourSingleton<StringReference>.instance.tutorialItem.GetLocalizedString()));
  }

  private void EventStart(CampaignNode node, EventRoutine @event)
  {
    if (!(@event is ItemEventRoutine itemEvent))
      return;
    this.Init(itemEvent);
  }

  private static void ActionPerformed(PlayAction action)
  {
    if (!(action is ActionSelect))
      return;
    PromptSystem.Hide();
  }

  private void SceneChanged(Scene scene) => Object.Destroy((Object) this);
}
