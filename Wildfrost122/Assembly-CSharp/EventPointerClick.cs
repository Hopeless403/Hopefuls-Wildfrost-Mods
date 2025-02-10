// Decompiled with JetBrains decompiler
// Type: EventPointerClick
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

#nullable disable
public class EventPointerClick : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
{
  [SerializeField]
  private UnityEvent pointerClick;
  [SerializeField]
  private bool afterFrame;

  public void OnPointerClick(PointerEventData eventData)
  {
    if (this.afterFrame)
      this.StartCoroutine(this.InvokeAfterFrame());
    else
      this.pointerClick.Invoke();
  }

  private IEnumerator InvokeAfterFrame()
  {
    yield return (object) new WaitForEndOfFrame();
    this.pointerClick.Invoke();
  }
}
