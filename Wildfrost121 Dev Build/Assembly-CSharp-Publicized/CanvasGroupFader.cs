// Decompiled with JetBrains decompiler
// Type: CanvasGroupFader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using System.Collections;
using UnityEngine;

#nullable disable
[RequireComponent(typeof (CanvasGroup))]
public class CanvasGroupFader : MonoBehaviour
{
  public CanvasGroup _canvasGroup;
  [SerializeField]
  public float fadeOutTime = 0.5f;
  [SerializeField]
  public LeanTweenType fadeOutEase = LeanTweenType.easeInOutQuad;
  [SerializeField]
  public bool removeInteractable = true;
  [SerializeField]
  public bool removeBlocksRaycast = true;
  [SerializeField]
  public bool disableAfter;
  [Header("Fade Out After Delay")]
  [SerializeField]
  public bool fadeOutAfter;
  [SerializeField]
  [ShowIf("fadeOutAfter")]
  public bool afterEnable;
  [SerializeField]
  [ShowIf("fadeOutAfter")]
  public float delay;

  public CanvasGroup canvasGroup
  {
    get => this._canvasGroup ?? (this._canvasGroup = this.GetComponent<CanvasGroup>());
  }

  public void OnEnable()
  {
    if (!this.fadeOutAfter || !this.afterEnable)
      return;
    this.StartCoroutine(this.FadeOutAfter(this.delay));
  }

  public void OnDisable() => this.StopAllCoroutines();

  public IEnumerator FadeOutAfter(float delay)
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

  public IEnumerator DisableAfter(float delay)
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
