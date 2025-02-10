// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusTokenApplyX
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using Deadpan.Enums.Engine.Components.Modding;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Tables;

#nullable disable
namespace Pokefrost
{
  public class StatusTokenApplyX : StatusEffectApplyX, IStatusToken
  {
    public static readonly string Key_Snowed = "websiteofsites.wildfrost.pokefrost.buttonSnowed";
    public static readonly string Key_Inked = "websiteofsites.wildfrost.pokefrost.buttonInked";
    public static readonly string Key_Generic = "websiteofsites.wildfrost.pokefrost.buttonGeneric";
    public static readonly string Key_Autotomize = "websiteofsites.wildfrost.pokefrost.buttonAutotomize";
    public string genericPopup;
    public StatusTokenApplyX.PlayFromFlags playFrom = StatusTokenApplyX.PlayFromFlags.Board;
    public bool finiteUses = false;
    public bool oncePerTurn = false;
    protected bool unusedThisTurn = true;
    public bool endTurn = false;
    public float timing = 0.2f;
    public TargetConstraint[] clickConstraints = new TargetConstraint[0];
    public int fixedAmount = 0;
    public int hitDamage = 0;

    [PokeLocalizer]
    public static void DefineStrings()
    {
      StringTable collection = LocalizationHelper.GetCollection("Tooltips", (LocaleIdentifier) SystemLanguage.English);
      collection.SetString(StatusTokenApplyX.Key_Snowed, "Snowed!");
      collection.SetString(StatusTokenApplyX.Key_Inked, "Inked!");
      collection.SetString(StatusTokenApplyX.Key_Generic, "Not yet!");
      collection.SetString(StatusTokenApplyX.Key_Autotomize, "Please recycle!");
    }

    public override void Init() => base.Init();

    public override bool RunTurnStartEvent(Entity entity)
    {
      if (entity.data.cardType.name == "Leader")
        this.unusedThisTurn = true;
      return base.RunTurnStartEvent(entity);
    }

    public virtual void RunButtonClicked()
    {
      if ((UnityEngine.Object) References.Battle == (UnityEngine.Object) null)
        return;
      if (this.target.IsSnowed)
        this.PopupText(StatusTokenApplyX.Key_Snowed);
      else if (this.target.silenced)
      {
        this.PopupText(StatusTokenApplyX.Key_Inked);
      }
      else
      {
        foreach (TargetConstraint clickConstraint in this.clickConstraints)
        {
          if (!clickConstraint.Check(this.target))
          {
            this.PopupText(this.genericPopup ?? StatusTokenApplyX.Key_Generic);
            return;
          }
        }
        if (References.Battle.phase != Battle.Phase.Play || !this.CorrectPlace() || this.target.IsSnowed || !((UnityEngine.Object) this.target.owner == (UnityEngine.Object) References.Player) || this.target.silenced || this.oncePerTurn && !this.unusedThisTurn)
          return;
        this.target.StartCoroutine(this.ButtonClicked());
        this.unusedThisTurn = false;
      }
    }

    public virtual void PopupText(string s)
    {
      NoTargetTextSystem objectOfType = UnityEngine.Object.FindObjectOfType<NoTargetTextSystem>();
      if (!((UnityEngine.Object) objectOfType != (UnityEngine.Object) null))
        return;
      objectOfType.textElement.text = LocalizationHelper.GetCollection("Tooltips", (LocaleIdentifier) SystemLanguage.English).GetString(s).GetLocalizedString();
      objectOfType.PopText(this.target.transform.position);
    }

    public bool CheckFlag(StatusTokenApplyX.PlayFromFlags flag) => (this.playFrom & flag) != 0;

    public virtual bool CorrectPlace()
    {
      return this.CheckFlag(StatusTokenApplyX.PlayFromFlags.Board) && Battle.IsOnBoard(this.target) || this.CheckFlag(StatusTokenApplyX.PlayFromFlags.Hand) && References.Player.handContainer.Contains(this.target) || this.CheckFlag(StatusTokenApplyX.PlayFromFlags.Draw) && this.target.preContainers.Contains<CardContainer>(References.Player.drawContainer) || this.CheckFlag(StatusTokenApplyX.PlayFromFlags.Discard) && this.target.preContainers.Contains<CardContainer>(References.Player.discardContainer);
    }

    public IEnumerator ButtonClicked()
    {
      if (this.hitDamage != 0)
      {
        List<Entity> enemies = this.GetTargets();
        int trueAmount = this.hitDamage == -1 ? this.count : this.hitDamage;
        foreach (Entity enemy in enemies)
        {
          if (enemy.IsAliveAndExists())
          {
            Hit hit = new Hit(this.target, enemy, trueAmount);
            hit.canRetaliate = false;
            yield return (object) hit.Process();
            hit = (Hit) null;
          }
        }
        enemies = (List<Entity>) null;
      }
      yield return (object) this.Run(this.GetTargets(), this.fixedAmount);
      List<StatusTokenApplyXListener> listeners = this.FindListeners();
      foreach (StatusTokenApplyXListener listener in listeners)
        yield return (object) listener.Run();
      this.target.display.promptUpdateDescription = true;
      yield return (object) this.PostClick();
    }

    public List<StatusTokenApplyXListener> FindListeners()
    {
      List<StatusTokenApplyXListener> listeners = new List<StatusTokenApplyXListener>();
      foreach (StatusEffectData statusEffect in this.target.statusEffects)
      {
        if (statusEffect is StatusTokenApplyXListener tokenApplyXlistener && tokenApplyXlistener.type == this.type + "_listener")
          listeners.Add(tokenApplyXlistener);
      }
      return listeners;
    }

    public virtual IEnumerator PostClick()
    {
      if (this.finiteUses)
      {
        --this.count;
        if (this.count == 0)
          yield return (object) this.Remove();
        this.target.promptUpdate = true;
      }
      if (this.endTurn)
      {
        yield return (object) Sequences.Wait(this.timing);
        References.Player.endTurn = true;
      }
    }

    public void ButtonCreate(StatusIconExt icon)
    {
    }

    [Flags]
    public enum PlayFromFlags
    {
      None = 0,
      Board = 1,
      Hand = 2,
      Draw = 4,
      Discard = 8,
    }
  }
}
