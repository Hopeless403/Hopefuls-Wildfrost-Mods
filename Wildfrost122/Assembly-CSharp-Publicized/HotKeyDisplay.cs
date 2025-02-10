// Decompiled with JetBrains decompiler
// Type: HotKeyDisplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
[RequireComponent(typeof (Image))]
public class HotKeyDisplay : MonoBehaviour
{
  public Image _image;
  [SerializeField]
  public string actionName;

  public Image image => this._image ?? (this._image = this.GetComponent<Image>());

  public void OnEnable()
  {
    global::Events.OnButtonStyleChanged += new UnityAction(this.Refresh);
    this.Refresh();
  }

  public void OnDisable() => global::Events.OnButtonStyleChanged -= new UnityAction(this.Refresh);

  public void Refresh()
  {
    if (MonoBehaviourSingleton<Cursor3d>.instance.usingMouse)
    {
      this.image.enabled = false;
    }
    else
    {
      JoystickButtonStyle.ElementButton element = ControllerButtonSystem.GetElement(RewiredControllerManager.GetPlayerController(0), this.actionName);
      this.image.enabled = element != null && element.hasSprite;
      if (!this.image.enabled)
        return;
      this.image.sprite = element.buttonSprite;
    }
  }

  public void SetActionName(string value)
  {
    this.actionName = value;
    this.Refresh();
  }
}
