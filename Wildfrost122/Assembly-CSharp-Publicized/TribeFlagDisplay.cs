// Decompiled with JetBrains decompiler
// Type: TribeFlagDisplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
public class TribeFlagDisplay : MonoBehaviour
{
  public Image flagImage;
  [SerializeField]
  public Sprite flagSprite;
  [SerializeField]
  public GameObject locked;
  [SerializeField]
  public ButtonAnimator button;
  [SerializeField]
  public InputAction inputAction;

  public void SetFlagSprite(Sprite sprite)
  {
    this.flagSprite = sprite;
    this.flagImage.sprite = sprite;
  }

  public void AddPressAction(UnityAction action) => this.inputAction.action.AddListener(action);

  public void ClearPressActions() => this.inputAction.action.RemoveAllListeners();

  public void SetInteractable(bool interactable) => this.button.interactable = interactable;

  public void SetUnlocked()
  {
    this.flagImage.sprite = this.flagSprite;
    this.button.interactable = true;
  }

  public void SetAvailable() => this.locked.SetActive(false);
}
