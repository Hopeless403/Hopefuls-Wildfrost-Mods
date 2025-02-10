// Decompiled with JetBrains decompiler
// Type: RewiredHotKeyController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class RewiredHotKeyController : MonoBehaviour
{
  [SerializeField]
  private string HotKeyString;
  public UINavigationLayer uINavigationLayer;
  public Button uiButton;
  public EventTrigger eventTrigger;
  public UnityEvent OnHotKeyPressed;
  public bool ignoreLayers;
  public bool ignoreActivateCooldown;
  public HotKeyDisplay display;
  [Header("Keyboard")]
  [SerializeField]
  private bool hasKeyboardInput;
  [SerializeField]
  [ShowIf("hasKeyboardInput")]
  private KeyCode keyboardAction;
  private bool press;
  private static int ActivateCooldown;
  private static RewiredHotKeyController ActivateCooldownInstance;

  private bool IsHotKeyHeld()
  {
    if (!MonoBehaviourSingleton<Cursor3d>.instance.usingMouse)
      return InputSystem.IsButtonHeld(this.HotKeyString);
    return this.hasKeyboardInput && Input.GetKey(this.keyboardAction);
  }

  private bool IsHotKeyPressed()
  {
    if (!MonoBehaviourSingleton<Cursor3d>.instance.usingMouse)
      return InputSystem.IsButtonPressed(this.HotKeyString);
    return this.hasKeyboardInput && Input.GetKeyDown(this.keyboardAction);
  }

  public void SetActionName(string value)
  {
    this.HotKeyString = value;
    if (!(bool) (Object) this.display)
      return;
    this.display.SetActionName(value);
  }

  private void Update()
  {
    if (RewiredHotKeyController.ActivateCooldown > 0 && (Object) RewiredHotKeyController.ActivateCooldownInstance == (Object) this && --RewiredHotKeyController.ActivateCooldown <= 0)
      RewiredHotKeyController.ActivateCooldownInstance = (RewiredHotKeyController) null;
    if ((this.ignoreLayers ? 1 : ((Object) MonoBehaviourSingleton<UINavigationSystem>.instance.lastActiveNavigationLayer == (Object) this.uINavigationLayer ? 1 : 0)) != 0 && (!MonoBehaviourSingleton<Cursor3d>.instance.usingMouse || this.hasKeyboardInput))
    {
      if (this.press)
      {
        if (!InputSystem.Enabled || InputSystem.reset)
        {
          this.press = false;
          this.Release();
        }
        else
        {
          if (this.IsHotKeyHeld())
            return;
          if (RewiredHotKeyController.ActivateCooldown > 0 && (bool) (Object) RewiredHotKeyController.ActivateCooldownInstance)
          {
            if (!this.ignoreActivateCooldown)
              this.press = false;
          }
          else
          {
            RewiredHotKeyController.ActivateCooldown = 5;
            RewiredHotKeyController.ActivateCooldownInstance = this;
          }
          this.Release();
        }
      }
      else
      {
        if (!this.IsHotKeyPressed())
          return;
        this.Press();
      }
    }
    else
    {
      if (!this.press)
        return;
      this.press = false;
      this.Release();
    }
  }

  private void OnDisable()
  {
    if (RewiredHotKeyController.ActivateCooldown <= 0 || !((Object) RewiredHotKeyController.ActivateCooldownInstance == (Object) this))
      return;
    RewiredHotKeyController.ActivateCooldown = 0;
    RewiredHotKeyController.ActivateCooldownInstance = (RewiredHotKeyController) null;
  }

  private void Press()
  {
    this.press = true;
    if (!(bool) (Object) this.eventTrigger || !this.eventTrigger.enabled)
      return;
    this.eventTrigger.OnPointerDown((PointerEventData) null);
  }

  private void Release()
  {
    if (this.press)
      this.Invoke();
    if ((bool) (Object) this.eventTrigger)
    {
      if (this.press && this.eventTrigger.enabled)
        this.eventTrigger.OnPointerClick((PointerEventData) null);
      this.eventTrigger.OnPointerUp((PointerEventData) null);
    }
    this.press = false;
  }

  private void Invoke()
  {
    if (this.OnHotKeyPressed != null && this.OnHotKeyPressed.GetPersistentEventCount() > 0)
    {
      this.OnHotKeyPressed.Invoke();
    }
    else
    {
      if (!(bool) (Object) this.uiButton || !this.uiButton.interactable)
        return;
      this.uiButton.onClick?.Invoke();
    }
  }
}
