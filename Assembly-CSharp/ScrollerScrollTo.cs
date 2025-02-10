// Decompiled with JetBrains decompiler
// Type: ScrollerScrollTo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

public class ScrollerScrollTo : MonoBehaviour
{
  [SerializeField]
  private Scroller scroller;
  [SerializeField]
  [Range(0.0f, 1f)]
  private float scrollTo = 1f;
  [SerializeField]
  private bool onAwake;
  [SerializeField]
  private bool onEnable = true;
  [SerializeField]
  private float delay;
  [SerializeField]
  private bool instant;

  private void Awake()
  {
    if (!this.onAwake)
      return;
    this.StartCoroutine(this.Run());
  }

  private void OnEnable()
  {
    if (!this.onEnable)
      return;
    this.StartCoroutine(this.Run());
  }

  private IEnumerator Run()
  {
    if ((double) this.delay > 0.0)
      yield return (object) new WaitForSeconds(this.delay);
    this.scroller.ScrollTo(this.scrollTo);
    if (this.instant)
      this.scroller.rectTransform.anchoredPosition = this.scroller.targetPos;
  }
}
