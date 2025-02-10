// Decompiled with JetBrains decompiler
// Type: BackButtonGamePadController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

#nullable disable
public class BackButtonGamePadController : MonoBehaviour
{
  public static bool isGoingBack;
  public Button backButton;
  public EventTrigger eventTrigger;
  public UINavigationLayer uINavigationLayer;
  public UINavigationItem navigationItem;
  public UnityEvent OnBackButtonOverride;
  private const float backClearTime = 0.1f;
  private Coroutine GoingBackClear;
  private bool navItemEnabled;
  private bool press;

  private void Update()
  {
    if (this.navItemEnabled)
    {
      if (!this.CheckNavigationItem())
        this.navItemEnabled = false;
      else if (BackButtonGamePadController.isGoingBack)
      {
        if (this.GoingBackClear == null)
          this.GoingBackClear = this.StartCoroutine(this.RunGoBackClear());
        if (!this.press)
          return;
        this.press = false;
        this.Release();
      }
      else if ((Object) MonoBehaviourSingleton<UINavigationSystem>.instance.lastActiveNavigationLayer == (Object) this.uINavigationLayer && !MonoBehaviourSingleton<Cursor3d>.instance.usingMouse)
      {
        if (this.press)
        {
          if (!InputSystem.Enabled || InputSystem.reset)
          {
            this.press = false;
            this.Release();
          }
          if (InputSystem.IsButtonHeld("Back"))
            return;
          this.Release();
        }
        else
        {
          if (!InputSystem.IsButtonPressed("Back"))
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
    else
    {
      if (!this.CheckNavigationItem())
        return;
      this.navItemEnabled = true;
    }
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
    BackButtonGamePadController.isGoingBack = true;
    if (this.OnBackButtonOverride != null && this.OnBackButtonOverride.GetPersistentEventCount() > 0)
      this.OnBackButtonOverride.Invoke();
    else
      this.backButton.onClick.Invoke();
  }

  private IEnumerator RunGoBackClear()
  {
    yield return (object) new WaitForSecondsRealtime(0.1f);
    BackButtonGamePadController.isGoingBack = false;
    this.GoingBackClear = (Coroutine) null;
  }

  internal void Start() => this.CheckForNavigationLayer(this.transform);

  private void CheckForNavigationLayer(Transform checkTransform)
  {
    UINavigationLayer component = checkTransform.GetComponent<UINavigationLayer>();
    if (component != null && component.isOverrideLayer)
      this.uINavigationLayer = component;
    if (!((Object) this.uINavigationLayer == (Object) null) || !((Object) checkTransform.transform.parent != (Object) null))
      return;
    this.CheckForNavigationLayer(checkTransform.transform.parent);
  }

  private bool CheckNavigationItem()
  {
    return !(bool) (Object) this.navigationItem || MonoBehaviourSingleton<UINavigationSystem>.instance.AvailableNavigationItems.Contains(this.navigationItem);
  }
}
