// Decompiled with JetBrains decompiler
// Type: EventPointerEnter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

#nullable disable
public class EventPointerEnter : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler
{
  [SerializeField]
  private UnityEvent pointerEnter;
  [SerializeField]
  private bool afterFrame;

  public void OnPointerEnter(PointerEventData eventData)
  {
    if (this.afterFrame)
      this.StartCoroutine(this.InvokeAfterFrame());
    else
      this.pointerEnter.Invoke();
  }

  private IEnumerator InvokeAfterFrame()
  {
    yield return (object) new WaitForEndOfFrame();
    this.pointerEnter.Invoke();
  }
}
