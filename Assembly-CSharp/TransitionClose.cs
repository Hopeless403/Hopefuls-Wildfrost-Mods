// Decompiled with JetBrains decompiler
// Type: TransitionClose
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

public class TransitionClose : TransitionType
{
  [SerializeField]
  private Transform rotator;
  [SerializeField]
  private GameObject borderTop;
  [SerializeField]
  private GameObject borderBottom;
  [SerializeField]
  private CanvasGroup fade;
  [SerializeField]
  private Vector2 angleRange = new Vector2(0.0f, 40f);
  [Header("Tweens")]
  [SerializeField]
  private LeanTweenType easeIn = LeanTweenType.easeOutBounce;
  [SerializeField]
  private float easeInDur = 0.8f;
  [SerializeField]
  private LeanTweenType easeOut = LeanTweenType.easeInQuart;
  [SerializeField]
  private float easeOutDur = 0.5f;
  private Vector3 borderTopStartPos;
  private Vector3 borderBottomStartPos;

  private void Start()
  {
    this.borderTopStartPos = this.borderTop.transform.localPosition;
    this.borderBottomStartPos = this.borderBottom.transform.localPosition;
  }

  public override IEnumerator In()
  {
    // ISSUE: reference to a compiler-generated field
    int num = this.\u003C\u003E1__state;
    TransitionClose transitionClose = this;
    if (num != 0)
    {
      if (num != 1)
        return false;
      // ISSUE: reference to a compiler-generated field
      this.\u003C\u003E1__state = -1;
      transitionClose.IsRunning = false;
      return false;
    }
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = -1;
    transitionClose.IsRunning = true;
    transitionClose.fade.blocksRaycasts = true;
    transitionClose.fade.alpha = 0.01f;
    transitionClose.rotator.SetLocalRotationZ(transitionClose.angleRange.PettyRandom().WithRandomSign());
    LeanTween.moveLocal(transitionClose.borderTop, Vector3.zero, transitionClose.easeInDur).setEase(transitionClose.easeIn);
    LeanTween.moveLocal(transitionClose.borderBottom, Vector3.zero, transitionClose.easeInDur).setEase(transitionClose.easeIn);
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E2__current = (object) new WaitForSeconds(transitionClose.easeInDur);
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = 1;
    return true;
  }

  public override IEnumerator Out()
  {
    // ISSUE: reference to a compiler-generated field
    int num = this.\u003C\u003E1__state;
    TransitionClose transitionClose = this;
    if (num != 0)
    {
      if (num != 1)
        return false;
      // ISSUE: reference to a compiler-generated field
      this.\u003C\u003E1__state = -1;
      transitionClose.IsRunning = false;
      transitionClose.gameObject.Destroy();
      return false;
    }
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = -1;
    transitionClose.IsRunning = true;
    transitionClose.fade.blocksRaycasts = false;
    transitionClose.fade.alpha = 0.0f;
    LeanTween.moveLocal(transitionClose.borderTop, transitionClose.borderTopStartPos, transitionClose.easeOutDur).setEase(transitionClose.easeOut);
    LeanTween.moveLocal(transitionClose.borderBottom, transitionClose.borderBottomStartPos, transitionClose.easeOutDur).setEase(transitionClose.easeOut);
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E2__current = (object) new WaitForSeconds(transitionClose.easeOutDur);
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = 1;
    return true;
  }
}
