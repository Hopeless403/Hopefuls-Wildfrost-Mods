// Decompiled with JetBrains decompiler
// Type: CardPocketInteraction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.Events;

public class CardPocketInteraction : MonoBehaviour
{
  [SerializeField]
  private UINavigationItem nav;
  [SerializeField]
  private GameObject root;
  [SerializeField]
  private UnityEvent onClick;
  [SerializeField]
  private UnityEvent onPress;
  [SerializeField]
  private UnityEvent onRelease;
  [SerializeField]
  private UnityEvent onHover;
  [SerializeField]
  private UnityEvent onUnHover;
  public bool interactable = true;
  [SerializeField]
  private bool defaultAnimations = true;
  private bool hover;
  private bool hovered;
  private bool press;
  private bool pressed;

  public void SetInteractable(bool value) => this.interactable = value;

  private bool IsInteractable
  {
    get
    {
      if (!this.interactable)
        return false;
      return (Object) this.nav == (Object) null || this.nav.enabled;
    }
  }

  private void Update()
  {
    if (this.hover)
    {
      if (!this.hovered)
      {
        this.hovered = true;
        if (this.defaultAnimations)
        {
          LeanTween.cancel(this.root);
          LeanTween.scale(this.root, Vector3.one * 1.1f, 0.2f).setEase(LeanTweenType.easeOutBack);
        }
        this.onHover?.Invoke();
      }
    }
    else if (this.hovered)
    {
      this.hovered = false;
      if (this.defaultAnimations)
      {
        LeanTween.cancel(this.root);
        LeanTween.scale(this.root, Vector3.one, 0.1f).setEase(LeanTweenType.easeOutQuart);
      }
      this.onUnHover?.Invoke();
    }
    if (this.press)
    {
      if (!this.pressed)
      {
        this.pressed = true;
        if (this.defaultAnimations)
        {
          LeanTween.cancel(this.root);
          LeanTween.scale(this.root, Vector3.one, 0.1f).setEase(LeanTweenType.easeOutQuart);
        }
        this.onPress?.Invoke();
      }
    }
    else if (this.pressed)
    {
      this.pressed = false;
      this.onRelease?.Invoke();
      if (this.hover)
      {
        if (this.defaultAnimations)
        {
          LeanTween.cancel(this.root);
          LeanTween.scale(this.root, Vector3.one * 1.1f, 0.1f).setEase(LeanTweenType.easeOutQuart);
        }
        this.onClick?.Invoke();
      }
      else
      {
        if (this.defaultAnimations)
        {
          LeanTween.cancel(this.root);
          LeanTween.scale(this.root, Vector3.one, 0.1f).setEase(LeanTweenType.easeOutQuart);
        }
        if ((Object) MonoBehaviourSingleton<UINavigationSystem>.instance.currentNavigationItem == (Object) this.nav)
          this.Hover();
      }
    }
    if (!this.press)
    {
      if (!this.hover || !InputSystem.IsSelectPressed())
        return;
      this.Press();
    }
    else
    {
      if (InputSystem.IsSelectHeld())
        return;
      this.Release();
    }
  }

  public void Hover() => this.hover = this.IsInteractable;

  public void UnHover() => this.hover = false;

  private void Press() => this.press = this.IsInteractable;

  private void Release() => this.press = false;
}
