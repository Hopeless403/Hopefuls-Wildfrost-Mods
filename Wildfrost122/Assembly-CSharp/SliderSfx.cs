// Decompiled with JetBrains decompiler
// Type: SliderSfx
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using FMODUnity;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

#nullable disable
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
