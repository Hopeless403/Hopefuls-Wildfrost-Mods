// Decompiled with JetBrains decompiler
// Type: ModifierToggle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using UnityEngine;
using UnityEngine.Events;

public class ModifierToggle : MonoBehaviour
{
  [SerializeField]
  private bool active = true;
  public bool canToggle = true;
  [SerializeField]
  [HideIf("canToggle")]
  private bool stillRing;
  public UnityEvent onToggle;
  [SerializeField]
  private UnityEngine.Animator animator;

  public bool IsActive => this.active;

  private void OnEnable() => this.UpdateAnimator();

  private void UpdateAnimator()
  {
    if (!(bool) (Object) this.animator || !this.animator.isActiveAndEnabled)
      return;
    this.animator.SetBool("Active", this.active);
    this.animator.SetBool("CanToggle", this.canToggle);
  }

  public void Toggle()
  {
    if (this.canToggle)
    {
      this.SetActive(!this.active);
      this.onToggle?.Invoke();
    }
    else
    {
      if (!this.stillRing)
        return;
      this.GetComponent<ModifierIcon>()?.Ding();
    }
  }

  public void SetActive(bool value)
  {
    this.active = value;
    this.UpdateArt();
  }

  public void UpdateArt()
  {
    if (this.active)
      this.GetComponent<ModifierIcon>()?.Ding();
    this.UpdateAnimator();
  }
}
