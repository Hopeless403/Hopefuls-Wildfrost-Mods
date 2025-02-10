// Decompiled with JetBrains decompiler
// Type: ModifierToggle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class ModifierToggle : MonoBehaviour
{
  [SerializeField]
  public bool active = true;
  public bool canToggle = true;
  [SerializeField]
  [HideIf("canToggle")]
  public bool stillRing;
  public UnityEvent onToggle;
  [SerializeField]
  public UnityEngine.Animator animator;

  public bool IsActive => this.active;

  public void OnEnable() => this.UpdateAnimator();

  public void UpdateAnimator()
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
