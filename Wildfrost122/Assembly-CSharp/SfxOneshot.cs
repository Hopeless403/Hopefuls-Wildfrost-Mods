// Decompiled with JetBrains decompiler
// Type: SfxOneshot
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using FMODUnity;
using NaughtyAttributes;
using System.Collections;
using UnityEngine;

#nullable disable
public class SfxOneshot : MonoBehaviour
{
  [SerializeField]
  private EventReference eventRef;
  [SerializeField]
  [HideIf("onEnable")]
  private bool onAwake;
  [SerializeField]
  [HideIf("onAwake")]
  private bool onEnable = true;
  [SerializeField]
  private float pitch = 1f;
  [SerializeField]
  private float delay;

  private void Awake()
  {
    if (!this.onAwake || this.onEnable)
      return;
    if ((double) this.delay > 0.0)
      this.StartCoroutine(this.FireAfterDelay());
    else
      this.Fire();
  }

  private void OnEnable()
  {
    if (!this.onEnable)
      return;
    if ((double) this.delay > 0.0)
      this.StartCoroutine(this.FireAfterDelay());
    else
      this.Fire();
  }

  public void Fire()
  {
    int num = (int) SfxSystem.OneShot(this.eventRef).setPitch(this.pitch);
  }

  private IEnumerator FireAfterDelay()
  {
    yield return (object) new WaitForSeconds(this.delay);
    this.Fire();
  }
}
