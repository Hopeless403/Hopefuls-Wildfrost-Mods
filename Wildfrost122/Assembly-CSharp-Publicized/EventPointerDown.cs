// Decompiled with JetBrains decompiler
// Type: EventPointerDown
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

#nullable disable
public class EventPointerDown : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
{
  [SerializeField]
  public UnityEvent pointerDown;
  [SerializeField]
  public bool afterFrame;

  public void OnPointerDown(PointerEventData eventData)
  {
    if (this.afterFrame)
      this.StartCoroutine(this.InvokeAfterFrame());
    else
      this.pointerDown.Invoke();
  }

  public IEnumerator InvokeAfterFrame()
  {
    yield return (object) new WaitForEndOfFrame();
    this.pointerDown.Invoke();
  }
}
