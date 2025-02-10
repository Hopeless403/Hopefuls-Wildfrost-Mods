// Decompiled with JetBrains decompiler
// Type: SliderSfx
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using FMODUnity;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

#nullable disable
public class SliderSfx : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
{
  [SerializeField]
  public Slider slider;
  [SerializeField]
  public EventReference sfxEvent;
  public bool drag;

  public void Fire() => SfxSystem.OneShot(this.sfxEvent);

  public void OnPointerDown(PointerEventData eventData) => this.drag = true;

  public void OnPointerUp(PointerEventData eventData)
  {
    if (this.drag)
      this.Fire();
    this.drag = false;
  }
}
