// Decompiled with JetBrains decompiler
// Type: EventPointerClick
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

#nullable disable
public class EventPointerClick : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
{
  [SerializeField]
  public UnityEvent pointerClick;
  [SerializeField]
  public bool afterFrame;

  public void OnPointerClick(PointerEventData eventData)
  {
    if (this.afterFrame)
      this.StartCoroutine(this.InvokeAfterFrame());
    else
      this.pointerClick.Invoke();
  }

  public IEnumerator InvokeAfterFrame()
  {
    yield return (object) new WaitForEndOfFrame();
    this.pointerClick.Invoke();
  }
}
