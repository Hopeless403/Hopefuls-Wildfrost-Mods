// Decompiled with JetBrains decompiler
// Type: UISequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

#nullable disable
public class UISequence : MonoBehaviour
{
  public bool promptEnd;
  public float startDelay = 0.25f;
  public float delayBetween = 0.2f;
  [Header("Tween In")]
  public float tweenInDur = 0.75f;
  public LeanTweenType tweenInEase = LeanTweenType.easeOutBack;
  [Header("Tween Out")]
  public float tweenOutDur = 0.25f;
  public LeanTweenType tweenOutEase = LeanTweenType.easeInBack;
  public Routine routine;

  public bool IsRunning
  {
    get
    {
      Routine routine = this.routine;
      return routine != null && routine.IsRunning;
    }
  }

  public void Begin()
  {
    if (this.IsRunning)
      this.routine.Stop();
    this.routine = new Routine(this.Run());
  }

  public virtual void End() => this.promptEnd = true;

  public void EndIfRunning()
  {
    if (!this.IsRunning)
      return;
    this.End();
  }

  public virtual IEnumerator Run() => (IEnumerator) null;
}
