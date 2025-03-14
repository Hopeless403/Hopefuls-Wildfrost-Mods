﻿// Decompiled with JetBrains decompiler
// Type: ToggleBasedOnCardController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class ToggleBasedOnCardController : MonoBehaviour
{
  [SerializeField]
  public CardController cardController;
  [SerializeField]
  public MonoBehaviour[] components;
  [SerializeField]
  public UnityEvent onEnable;
  [SerializeField]
  public UnityEvent onDisable;

  public void AssignCardController(CardController controller)
  {
    this.cardController = controller;
    if (controller.enabled)
      this.Enable();
    else
      this.Disable();
  }

  public void OnEnable()
  {
    global::Events.OnCardControllerEnabled += new UnityAction<CardController>(this.CardControllerEnabled);
    global::Events.OnCardControllerDisabled += new UnityAction<CardController>(this.CardControllerDisabled);
  }

  public void OnDisable()
  {
    global::Events.OnCardControllerEnabled -= new UnityAction<CardController>(this.CardControllerEnabled);
    global::Events.OnCardControllerDisabled -= new UnityAction<CardController>(this.CardControllerDisabled);
  }

  public void CardControllerEnabled(CardController controller)
  {
    if (!((Object) controller == (Object) this.cardController))
      return;
    this.Enable();
  }

  public void CardControllerDisabled(CardController controller)
  {
    if (!((Object) controller == (Object) this.cardController))
      return;
    this.Disable();
  }

  public void Enable()
  {
    foreach (Behaviour component in this.components)
      component.enabled = true;
    this.onEnable?.Invoke();
  }

  public void Disable()
  {
    foreach (Behaviour component in this.components)
      component.enabled = false;
    this.onDisable?.Invoke();
  }
}
