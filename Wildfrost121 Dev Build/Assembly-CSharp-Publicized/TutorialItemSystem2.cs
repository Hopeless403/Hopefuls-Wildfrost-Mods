// Decompiled with JetBrains decompiler
// Type: TutorialItemSystem2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

#nullable disable
public class TutorialItemSystem2 : GameSystem
{
  public bool init;
  public ItemEventRoutine itemEvent;
  public bool waitForOpen;
  public float promptDelay;

  public void OnEnable()
  {
    global::Events.OnEventStart += new UnityAction<CampaignNode, EventRoutine>(this.EventStart);
    global::Events.OnActionPerform += new UnityAction<PlayAction>(TutorialItemSystem2.ActionPerformed);
    global::Events.OnSceneChanged += new UnityAction<Scene>(this.SceneChanged);
  }

  public void OnDisable()
  {
    global::Events.OnEventStart -= new UnityAction<CampaignNode, EventRoutine>(this.EventStart);
    global::Events.OnActionPerform -= new UnityAction<PlayAction>(TutorialItemSystem2.ActionPerformed);
    global::Events.OnSceneChanged -= new UnityAction<Scene>(this.SceneChanged);
    PromptSystem.Hide();
  }

  public void Init(ItemEventRoutine itemEvent)
  {
    this.init = true;
    this.itemEvent = itemEvent;
    this.waitForOpen = true;
  }

  public void Update()
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

  public void EventStart(CampaignNode node, EventRoutine @event)
  {
    if (!(@event is ItemEventRoutine itemEvent))
      return;
    this.Init(itemEvent);
  }

  public static void ActionPerformed(PlayAction action)
  {
    if (!(action is ActionSelect))
      return;
    PromptSystem.Hide();
  }

  public void SceneChanged(Scene scene) => Object.Destroy((Object) this);
}
