// Decompiled with JetBrains decompiler
// Type: HotKeyDisplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof (Image))]
public class HotKeyDisplay : MonoBehaviour
{
  private Image _image;
  [SerializeField]
  private string actionName;

  private Image image => this._image ?? (this._image = this.GetComponent<Image>());

  private void OnEnable()
  {
    global::Events.OnButtonStyleChanged += new UnityAction(this.Refresh);
    this.Refresh();
  }

  private void OnDisable() => global::Events.OnButtonStyleChanged -= new UnityAction(this.Refresh);

  private void Refresh()
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
