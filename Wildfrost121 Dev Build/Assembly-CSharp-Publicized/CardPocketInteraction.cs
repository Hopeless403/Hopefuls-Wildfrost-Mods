// Decompiled with JetBrains decompiler
// Type: CardPocketInteraction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class CardPocketInteraction : MonoBehaviour
{
  [SerializeField]
  public UINavigationItem nav;
  [SerializeField]
  public GameObject root;
  [SerializeField]
  public UnityEvent onClick;
  [SerializeField]
  public UnityEvent onPress;
  [SerializeField]
  public UnityEvent onRelease;
  [SerializeField]
  public UnityEvent onHover;
  [SerializeField]
  public UnityEvent onUnHover;
  public bool interactable = true;
  [SerializeField]
  public bool defaultAnimations = true;
  public bool hover;
  public bool hovered;
  public bool press;
  public bool pressed;

  public void SetInteractable(bool value) => this.interactable = value;

  public bool IsInteractable
  {
    get
    {
      if (!this.interactable)
        return false;
      return (Object) this.nav == (Object) null || this.nav.enabled;
    }
  }

  public void Update()
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

  public void Press() => this.press = this.IsInteractable;

  public void Release() => this.press = false;
}
