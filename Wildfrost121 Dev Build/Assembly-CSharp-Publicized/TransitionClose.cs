// Decompiled with JetBrains decompiler
// Type: TransitionClose
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

#nullable disable
public class TransitionClose : TransitionType
{
  [SerializeField]
  public Transform rotator;
  [SerializeField]
  public GameObject borderTop;
  [SerializeField]
  public GameObject borderBottom;
  [SerializeField]
  public CanvasGroup fade;
  [SerializeField]
  public Vector2 angleRange = new Vector2(0.0f, 40f);
  [Header("Tweens")]
  [SerializeField]
  public LeanTweenType easeIn = LeanTweenType.easeOutBounce;
  [SerializeField]
  public float easeInDur = 0.8f;
  [SerializeField]
  public LeanTweenType easeOut = LeanTweenType.easeInQuart;
  [SerializeField]
  public float easeOutDur = 0.5f;
  public Vector3 borderTopStartPos;
  public Vector3 borderBottomStartPos;

  public void Start()
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
