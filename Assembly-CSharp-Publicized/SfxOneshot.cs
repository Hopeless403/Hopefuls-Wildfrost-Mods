// Decompiled with JetBrains decompiler
// Type: SfxOneshot
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using FMODUnity;
using NaughtyAttributes;
using System.Collections;
using UnityEngine;

public class SfxOneshot : MonoBehaviour
{
  [SerializeField]
  public EventReference eventRef;
  [SerializeField]
  [HideIf("onEnable")]
  public bool onAwake;
  [SerializeField]
  [HideIf("onAwake")]
  public bool onEnable = true;
  [SerializeField]
  public float pitch = 1f;
  [SerializeField]
  public float delay;

  public void Awake()
  {
    if (!this.onAwake || this.onEnable)
      return;
    if ((double) this.delay > 0.0)
      this.StartCoroutine(this.FireAfterDelay());
    else
      this.Fire();
  }

  public void OnEnable()
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

  public IEnumerator FireAfterDelay()
  {
    yield return (object) new WaitForSeconds(this.delay);
    this.Fire();
  }
}
