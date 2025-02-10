// Decompiled with JetBrains decompiler
// Type: EventPointerExit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

#nullable disable
public class EventPointerExit : MonoBehaviour, IPointerExitHandler, IEventSystemHandler
{
  [SerializeField]
  private UnityEvent pointerExit;
  [SerializeField]
  private bool afterFrame;

  public void OnPointerExit(PointerEventData eventData)
  {
    if (this.afterFrame)
      this.StartCoroutine(this.InvokeAfterFrame());
    else
      this.pointerExit.Invoke();
  }

  private IEnumerator InvokeAfterFrame()
  {
    yield return (object) new WaitForEndOfFrame();
    this.pointerExit.Invoke();
  }
}
