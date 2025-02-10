// Decompiled with JetBrains decompiler
// Type: SliderSfx
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using FMODUnity;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

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
