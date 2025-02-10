// Decompiled with JetBrains decompiler
// Type: UnplayableCrownCardSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Localization;
using UnityEngine.SceneManagement;

public class UnplayableCrownCardSystem : GameSystem
{
  [SerializeField]
  private LocalizedString promptKey;
  private bool active;
  private bool blocked;
  private bool promptShown;
  private int handCount;
  private const float timerMax = 0.5f;
  private float timer;

  private void OnEnable()
  {
    global::Events.OnBattleStart += new UnityAction(this.BattleStart);
    global::Events.OnSceneChanged += new UnityAction<Scene>(this.SceneChanged);
    global::Events.OnActionPerform += new UnityAction<PlayAction>(this.ActionPerform);
  }

  private void OnDisable()
  {
    global::Events.OnBattleStart -= new UnityAction(this.BattleStart);
    global::Events.OnSceneChanged -= new UnityAction<Scene>(this.SceneChanged);
    global::Events.OnActionPerform -= new UnityAction<PlayAction>(this.ActionPerform);
  }

  private void BattleStart()
  {
    if (this.active)
      return;
    this.Activate();
  }

  private void SceneChanged(Scene scene)
  {
    if (!this.active)
      return;
    this.Deactivate();
  }

  private void ActionPerform(PlayAction action)
  {
    if (!this.active || !(action is ActionDrawHand actionDrawHand) || !((Object) actionDrawHand.character == (Object) References.Player))
      return;
    this.Deactivate();
  }

  private void Activate()
  {
    this.active = true;
    this.handCount = References.Player.handContainer.Count;
    this.timer = 0.5f;
  }

  private void Update()
  {
    if (!this.active || (double) this.timer <= 0.0)
      return;
    this.timer -= Time.deltaTime;
    if ((double) this.timer > 0.0)
      return;
    this.timer = 0.5f;
    this.Check();
  }

  private void Check()
  {
    int count = References.Player.handContainer.Count;
    if (count == this.handCount)
      return;
    this.handCount = count;
    if (this.handCount == 0)
    {
      this.Deactivate();
    }
    else
    {
      if (this.handCount <= 0)
        return;
      bool blocked = this.blocked;
      this.blocked = UnplayableCrownCardSystem.CheckBlocked();
      if (this.blocked && !blocked)
      {
        this.ShowPrompt();
        RedrawBellSystem objectOfType = Object.FindObjectOfType<RedrawBellSystem>();
        if (objectOfType == null)
          return;
        objectOfType.Enable();
        objectOfType.BecomeInteractable();
      }
      else
      {
        if (!blocked || this.blocked)
          return;
        this.Deactivate();
      }
    }
  }

  private void Deactivate()
  {
    this.active = false;
    this.blocked = false;
    if (!this.promptShown)
      return;
    PromptSystem.Hide();
    this.promptShown = false;
  }

  private static bool CheckBlocked()
  {
    int num = 0;
    CardContainer[] array = ((IEnumerable<CardContainer>) Object.FindObjectsOfType<CardContainer>()).ToArray<CardContainer>();
    foreach (Entity card in References.Player.handContainer)
    {
      if (UnplayableCrownCardSystem.CardIsBlocked(card, array))
        ++num;
    }
    return num == References.Player.handContainer.Count;
  }

  private static bool CardIsBlocked(Entity card, CardContainer[] containers)
  {
    foreach (StatusEffectData statusEffect in card.statusEffects)
    {
      if (statusEffect is StatusEffectRecycle statusEffectRecycle)
      {
        if (!statusEffectRecycle.IsEnoughJunkInHand())
          return true;
        break;
      }
    }
    if (!card.NeedsTarget)
      return false;
    foreach (CardContainer container in containers)
    {
      if (card.CanPlayOn(container))
        return false;
    }
    foreach (Entity card1 in References.Battle.cards)
    {
      if (card1.enabled && card.CanPlayOn(card1))
        return false;
    }
    return true;
  }

  private void ShowPrompt()
  {
    PromptSystem.Create(Prompt.Anchor.Left, 1.5f, 2f, 5f, Prompt.Emote.Type.Scared);
    PromptSystem.SetTextAction((Prompt.GetTextCallback) (() => this.promptKey.GetLocalizedString()));
    this.promptShown = true;
  }
}
