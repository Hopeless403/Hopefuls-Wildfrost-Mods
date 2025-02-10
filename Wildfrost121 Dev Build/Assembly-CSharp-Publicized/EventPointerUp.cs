// Decompiled with JetBrains decompiler
// Type: EventPointerUp
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

#nullable disable
public class EventPointerUp : MonoBehaviour, IPointerUpHandler, IEventSystemHandler
{
  [SerializeField]
  public UnityEvent pointerUp;
  [SerializeField]
  public bool afterFrame;

  public void OnPointerUp(PointerEventData eventData)
  {
    if (this.afterFrame)
      this.StartCoroutine(this.InvokeAfterFrame());
    else
      this.pointerUp.Invoke();
  }

  public IEnumerator InvokeAfterFrame()
  {
    yield return (object) new WaitForEndOfFrame();
    this.pointerUp.Invoke();
  }
}
