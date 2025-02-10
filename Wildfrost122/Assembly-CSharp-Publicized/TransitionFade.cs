// Decompiled with JetBrains decompiler
// Type: TransitionFade
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

#nullable disable
public class TransitionFade : TransitionType
{
  public CanvasGroup fade;
  [Header("Tweens")]
  public LeanTweenType easeIn = LeanTweenType.easeInQuint;
  public float easeInDur = 0.5f;
  public LeanTweenType easeOut = LeanTweenType.easeOutQuint;
  public float easeOutDur = 0.5f;

  public override IEnumerator In()
  {
    // ISSUE: reference to a compiler-generated field
    int num = this.\u003C\u003E1__state;
    TransitionFade transitionFade = this;
    if (num != 0)
    {
      if (num != 1)
        return false;
      // ISSUE: reference to a compiler-generated field
      this.\u003C\u003E1__state = -1;
      transitionFade.IsRunning = false;
      return false;
    }
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = -1;
    transitionFade.IsRunning = true;
    transitionFade.fade.blocksRaycasts = true;
    transitionFade.fade.LeanAlpha(1f, transitionFade.easeInDur).setEase(transitionFade.easeIn);
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E2__current = (object) new WaitForSeconds(transitionFade.easeInDur);
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = 1;
    return true;
  }

  public override IEnumerator Out()
  {
    // ISSUE: reference to a compiler-generated field
    int num = this.\u003C\u003E1__state;
    TransitionFade transitionFade = this;
    if (num != 0)
    {
      if (num != 1)
        return false;
      // ISSUE: reference to a compiler-generated field
      this.\u003C\u003E1__state = -1;
      transitionFade.IsRunning = false;
      transitionFade.gameObject.Destroy();
      return false;
    }
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = -1;
    transitionFade.IsRunning = true;
    transitionFade.fade.blocksRaycasts = false;
    transitionFade.fade.LeanAlpha(0.0f, transitionFade.easeOutDur).setEase(transitionFade.easeOut);
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E2__current = (object) new WaitForSeconds(transitionFade.easeOutDur);
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = 1;
    return true;
  }
}
