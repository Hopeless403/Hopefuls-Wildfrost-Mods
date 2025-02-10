// Decompiled with JetBrains decompiler
// Type: SliderSfx
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using FMODUnity;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SliderSfx : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
{
  [SerializeField]
  private Slider slider;
  [SerializeField]
  private EventReference sfxEvent;
  private bool drag;

  public void Fire() => SfxSystem.OneShot(this.sfxEvent);

  public void OnPointerDown(PointerEventData eventData) => this.drag = true;

  public void OnPointerUp(PointerEventData eventData)
  {
    if (this.drag)
      this.Fire();
    this.drag = false;
  }
}
