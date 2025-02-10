// Decompiled with JetBrains decompiler
// Type: TribeFlagDisplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class TribeFlagDisplay : MonoBehaviour
{
  public Image flagImage;
  [SerializeField]
  private Sprite flagSprite;
  [SerializeField]
  private GameObject locked;
  [SerializeField]
  private ButtonAnimator button;
  [SerializeField]
  private InputAction inputAction;

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
