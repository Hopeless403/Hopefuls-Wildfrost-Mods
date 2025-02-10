// Decompiled with JetBrains decompiler
// Type: WarningTutorialSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Localization;

#nullable disable
public class WarningTutorialSystem : GameSystem
{
  [SerializeField]
  private LocalizedString promptStringRef;
  private bool promptShown;

  private void OnEnable()
  {
    global::Events.OnCheckAction += new global::Events.UnityActionRef<PlayAction, bool>(this.CheckAction);
    global::Events.OnActionPerform += new UnityAction<PlayAction>(this.ActionPerform);
  }

  private void OnDisable()
  {
    global::Events.OnCheckAction -= new global::Events.UnityActionRef<PlayAction, bool>(this.CheckAction);
    global::Events.OnActionPerform -= new UnityAction<PlayAction>(this.ActionPerform);
  }

  private void CheckAction(ref PlayAction action, ref bool allow)
  {
    if (this.promptShown || !(action is ActionTriggerAgainst actionTriggerAgainst) || !((UnityEngine.Object) actionTriggerAgainst.triggeredBy == (UnityEngine.Object) References.Player.entity))
      return;
    int damage;
    bool instantKill;
    WarningTutorialSystem.GetDamageDetails(actionTriggerAgainst.entity, out damage, out instantKill);
    if (!(damage > 0 | instantKill))
      return;
    Entity entity = (Entity) null;
    if ((bool) (UnityEngine.Object) actionTriggerAgainst.targetContainer)
      entity = actionTriggerAgainst.targetContainer.FirstOrDefault<Entity>((Func<Entity, bool>) (a => a.data.cardType.miniboss && (UnityEngine.Object) a.owner == (UnityEngine.Object) References.Player));
    else if (actionTriggerAgainst.target.data.cardType.miniboss && (UnityEngine.Object) actionTriggerAgainst.target.owner == (UnityEngine.Object) References.Player)
      entity = actionTriggerAgainst.target;
    if (!(bool) (UnityEngine.Object) entity)
      return;
    if (instantKill)
    {
      allow = false;
      this.ShowPrompt(actionTriggerAgainst.entity);
    }
    else
    {
      if ((bool) (UnityEngine.Object) entity.FindStatus("block"))
        return;
      int current = entity.hp.current;
      StatusEffectData status = entity.FindStatus("shell");
      if ((bool) (UnityEngine.Object) status)
        current += status.count;
      if (current > damage)
        return;
      allow = false;
      this.ShowPrompt(actionTriggerAgainst.entity);
    }
  }

  private static void GetDamageDetails(Entity entity, out int damage, out bool instantKill)
  {
    instantKill = false;
    damage = entity.damage.current + entity.tempDamage.Value;
    foreach (CardData.StatusEffectStacks attackEffect in entity.attackEffects)
    {
      if (attackEffect.data is StatusEffectInstantSacrifice)
        instantKill = true;
    }
  }

  private void ActionPerform(PlayAction action)
  {
    if (!this.promptShown)
      return;
    this.HidePrompt();
  }

  private void ShowPrompt(Entity attackingCard)
  {
    PromptSystem.Hide();
    PromptSystem.Create(Prompt.Anchor.Left, 0.0f, 1f, 3f, Prompt.Emote.Type.Scared);
    PromptSystem.SetTextAction((Prompt.GetTextCallback) (() => this.promptStringRef.GetLocalizedString((object) attackingCard.data.title)));
    PromptSystem.Shake();
    this.promptShown = true;
  }

  private void HidePrompt()
  {
    PromptSystem.Hide();
    this.promptShown = false;
  }
}
