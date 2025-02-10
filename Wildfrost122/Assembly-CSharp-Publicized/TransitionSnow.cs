// Decompiled with JetBrains decompiler
// Type: TransitionSnow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

#nullable disable
public class TransitionSnow : TransitionType
{
  [SerializeField]
  public ParticleSystem inParticles;
  [SerializeField]
  public ParticleSystem outParticles;
  [Header("Fade Image")]
  [SerializeField]
  public CanvasGroup fade;
  [Header("Tweens")]
  [SerializeField]
  public LeanTweenType easeIn = LeanTweenType.easeInCubic;
  [SerializeField]
  public float easeInDur = 0.6f;
  [SerializeField]
  public LeanTweenType easeOut = LeanTweenType.easeOutCubic;
  [SerializeField]
  public float easeOutDur = 0.1f;

  [Button("In", EButtonEnableMode.Always)]
  public void SnowIn()
  {
    if (this.IsRunning)
      return;
    this.StopAllCoroutines();
    this.StartCoroutine(this.In());
  }

  [Button("Out", EButtonEnableMode.Always)]
  public void SnowOut()
  {
    if (this.IsRunning)
      return;
    this.StopAllCoroutines();
    this.StartCoroutine(this.Out());
  }

  public override IEnumerator In()
  {
    // ISSUE: reference to a compiler-generated field
    int num = this.\u003C\u003E1__state;
    TransitionSnow transitionSnow = this;
    if (num != 0)
    {
      if (num != 1)
        return false;
      // ISSUE: reference to a compiler-generated field
      this.\u003C\u003E1__state = -1;
      transitionSnow.IsRunning = false;
      return false;
    }
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = -1;
    transitionSnow.inParticles.Play();
    transitionSnow.IsRunning = true;
    transitionSnow.fade.blocksRaycasts = true;
    transitionSnow.fade.LeanAlpha(1f, transitionSnow.easeInDur).setEase(transitionSnow.easeIn);
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E2__current = (object) new WaitForSeconds(transitionSnow.easeInDur);
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = 1;
    return true;
  }

  public override IEnumerator Out()
  {
    TransitionSnow transitionSnow = this;
    transitionSnow.outParticles.Play();
    transitionSnow.IsRunning = true;
    transitionSnow.fade.blocksRaycasts = false;
    transitionSnow.fade.LeanAlpha(0.0f, transitionSnow.easeOutDur).setEase(transitionSnow.easeOut);
    yield return (object) new WaitForSeconds(transitionSnow.easeOutDur);
    transitionSnow.IsRunning = false;
    yield return (object) new WaitUntil(new Func<bool>(transitionSnow.\u003COut\u003Eb__10_0));
    transitionSnow.gameObject.Destroy();
  }

  [CompilerGenerated]
  public bool \u003COut\u003Eb__10_0() => !this.outParticles.isPlaying;
}
