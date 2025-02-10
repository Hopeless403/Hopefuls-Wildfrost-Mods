// Decompiled with JetBrains decompiler
// Type: EventPointerUp
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

#nullable disable
public class EventPointerUp : MonoBehaviour, IPointerUpHandler, IEventSystemHandler
{
  [SerializeField]
  private UnityEvent pointerUp;
  [SerializeField]
  private bool afterFrame;

  public void OnPointerUp(PointerEventData eventData)
  {
    if (this.afterFrame)
      this.StartCoroutine(this.InvokeAfterFrame());
    else
      this.pointerUp.Invoke();
  }

  private IEnumerator InvokeAfterFrame()
  {
    yield return (object) new WaitForEndOfFrame();
    this.pointerUp.Invoke();
  }
}
