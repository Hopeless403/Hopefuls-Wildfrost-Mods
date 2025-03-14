﻿// Decompiled with JetBrains decompiler
// Type: ToggleBasedOnCardController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.Events;

public class ToggleBasedOnCardController : MonoBehaviour
{
  [SerializeField]
  private CardController cardController;
  [SerializeField]
  private MonoBehaviour[] components;
  [SerializeField]
  private UnityEvent onEnable;
  [SerializeField]
  private UnityEvent onDisable;

  public void AssignCardController(CardController controller)
  {
    this.cardController = controller;
    if (controller.enabled)
      this.Enable();
    else
      this.Disable();
  }

  private void OnEnable()
  {
    global::Events.OnCardControllerEnabled += new UnityAction<CardController>(this.CardControllerEnabled);
    global::Events.OnCardControllerDisabled += new UnityAction<CardController>(this.CardControllerDisabled);
  }

  private void OnDisable()
  {
    global::Events.OnCardControllerEnabled -= new UnityAction<CardController>(this.CardControllerEnabled);
    global::Events.OnCardControllerDisabled -= new UnityAction<CardController>(this.CardControllerDisabled);
  }

  private void CardControllerEnabled(CardController controller)
  {
    if (!((Object) controller == (Object) this.cardController))
      return;
    this.Enable();
  }

  private void CardControllerDisabled(CardController controller)
  {
    if (!((Object) controller == (Object) this.cardController))
      return;
    this.Disable();
  }

  private void Enable()
  {
    foreach (Behaviour component in this.components)
      component.enabled = true;
    this.onEnable?.Invoke();
  }

  private void Disable()
  {
    foreach (Behaviour component in this.components)
      component.enabled = false;
    this.onDisable?.Invoke();
  }
}
