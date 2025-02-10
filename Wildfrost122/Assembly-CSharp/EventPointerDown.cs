// Decompiled with JetBrains decompiler
// Type: EventPointerDown
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

#nullable disable
public class EventPointerDown : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
{
  [SerializeField]
  private UnityEvent pointerDown;
  [SerializeField]
  private bool afterFrame;

  public void OnPointerDown(PointerEventData eventData)
  {
    if (this.afterFrame)
      this.StartCoroutine(this.InvokeAfterFrame());
    else
      this.pointerDown.Invoke();
  }

  private IEnumerator InvokeAfterFrame()
  {
    yield return (object) new WaitForEndOfFrame();
    this.pointerDown.Invoke();
  }
}
