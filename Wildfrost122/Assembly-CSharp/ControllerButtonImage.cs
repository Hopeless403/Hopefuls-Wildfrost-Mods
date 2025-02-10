// Decompiled with JetBrains decompiler
// Type: ControllerButtonImage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
[RequireComponent(typeof (Image))]
public class ControllerButtonImage : MonoBehaviour
{
  [SerializeField]
  private bool deactivateIfNull = true;
  [SerializeField]
  private bool disableIfNull;
  private Image image;

  public string actionName { get; private set; }

  private void OnEnable()
  {
    this.image = this.GetComponent<Image>();
    global::Events.OnButtonStyleChanged += new UnityAction(this.ButtonStyleChanged);
  }

  private void OnDisable()
  {
    global::Events.OnButtonStyleChanged -= new UnityAction(this.ButtonStyleChanged);
  }

  public void Set(string actionName)
  {
    this.actionName = actionName;
    Sprite sprite = ControllerButtonSystem.Get(actionName);
    if (this.deactivateIfNull)
      this.gameObject.SetActive((bool) (Object) sprite);
    if (this.disableIfNull)
      this.image.enabled = (bool) (Object) sprite;
    if (!(bool) (Object) sprite)
      return;
    this.image.sprite = sprite;
  }

  private void ButtonStyleChanged()
  {
    if (this.actionName.IsNullOrWhitespace())
      return;
    this.Set(this.actionName);
  }
}
