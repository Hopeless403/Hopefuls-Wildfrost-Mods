// Decompiled with JetBrains decompiler
// Type: CharmMachine
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

public class CharmMachine : MonoBehaviour
{
  [SerializeField]
  private UnityEngine.Animator animator;
  [SerializeField]
  private CardPopUpTarget pop;
  private bool running;
  private bool hover;

  public bool CanRun() => !this.running && this.enabled;

  public IEnumerator Run()
  {
    this.running = true;
    this.UnHover();
    this.animator.SetBool("EyesOpen", true);
    Events.InvokeScreenShake(0.2f);
    this.animator.SetTrigger("Rumble");
    SfxSystem.OneShot("event:/sfx/location/shop/charm_rumble");
    yield return (object) Sequences.Wait(0.1f);
    this.animator.SetBool("OpenMouth", true);
    yield return (object) Sequences.Wait(0.35f);
    this.animator.SetTrigger("DropCharm");
    SfxSystem.OneShot("event:/sfx/location/shop/charm_drop");
    yield return (object) Sequences.Wait(1f);
    this.animator.SetBool("OpenMouth", false);
    this.animator.SetBool("EyesOpen", false);
    this.running = false;
  }

  public void Hover()
  {
    if (this.hover || !this.enabled || this.running)
      return;
    this.hover = true;
    this.animator.SetBool(nameof (Hover), this.hover);
    this.animator.SetBool("EyesOpen", this.hover);
    this.pop.Pop();
  }

  public void UnHover()
  {
    if (!this.hover)
      return;
    this.hover = false;
    this.animator.SetBool("Hover", this.hover);
    this.animator.SetBool("EyesOpen", this.hover);
    this.pop.UnPop();
  }
}
