// Decompiled with JetBrains decompiler
// Type: CanvasGroupFader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using System.Collections;
using UnityEngine;

#nullable disable
[RequireComponent(typeof (CanvasGroup))]
public class CanvasGroupFader : MonoBehaviour
{
  private CanvasGroup _canvasGroup;
  [SerializeField]
  private float fadeOutTime = 0.5f;
  [SerializeField]
  private LeanTweenType fadeOutEase = LeanTweenType.easeInOutQuad;
  [SerializeField]
  private bool removeInteractable = true;
  [SerializeField]
  private bool removeBlocksRaycast = true;
  [SerializeField]
  private bool disableAfter;
  [Header("Fade Out After Delay")]
  [SerializeField]
  private bool fadeOutAfter;
  [SerializeField]
  [ShowIf("fadeOutAfter")]
  private bool afterEnable;
  [SerializeField]
  [ShowIf("fadeOutAfter")]
  private float delay;

  private CanvasGroup canvasGroup
  {
    get => this._canvasGroup ?? (this._canvasGroup = this.GetComponent<CanvasGroup>());
  }

  private void OnEnable()
  {
    if (!this.fadeOutAfter || !this.afterEnable)
      return;
    this.StartCoroutine(this.FadeOutAfter(this.delay));
  }

  private void OnDisable() => this.StopAllCoroutines();

  private IEnumerator FadeOutAfter(float delay)
  {
    yield return (object) new WaitForSeconds(delay);
    this.FadeOut();
  }

  public void FadeOut()
  {
    LeanTween.cancel(this.gameObject);
    LeanTween.alphaCanvas(this.canvasGroup, 0.0f, this.fadeOutTime).setEase(this.fadeOutEase);
    if (this.removeInteractable)
      this.canvasGroup.interactable = false;
    if (this.removeBlocksRaycast)
      this.canvasGroup.blocksRaycasts = false;
    if (!this.disableAfter)
      return;
    this.StartCoroutine(this.DisableAfter(this.fadeOutTime));
  }

  private IEnumerator DisableAfter(float delay)
  {
    // ISSUE: reference to a compiler-generated field
    int num = this.\u003C\u003E1__state;
    CanvasGroupFader canvasGroupFader = this;
    if (num != 0)
    {
      if (num != 1)
        return false;
      // ISSUE: reference to a compiler-generated field
      this.\u003C\u003E1__state = -1;
      canvasGroupFader.gameObject.SetActive(false);
      return false;
    }
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = -1;
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E2__current = (object) new WaitForSeconds(delay);
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = 1;
    return true;
  }
}
