// Decompiled with JetBrains decompiler
// Type: ScrollerScrollTo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

#nullable disable
public class ScrollerScrollTo : MonoBehaviour
{
  [SerializeField]
  public Scroller scroller;
  [SerializeField]
  [Range(0.0f, 1f)]
  public float scrollTo = 1f;
  [SerializeField]
  public bool onAwake;
  [SerializeField]
  public bool onEnable = true;
  [SerializeField]
  public float delay;
  [SerializeField]
  public bool instant;

  public void Awake()
  {
    if (!this.onAwake)
      return;
    this.StartCoroutine(this.Run());
  }

  public void OnEnable()
  {
    if (!this.onEnable)
      return;
    this.StartCoroutine(this.Run());
  }

  public IEnumerator Run()
  {
    if ((double) this.delay > 0.0)
      yield return (object) new WaitForSeconds(this.delay);
    this.scroller.ScrollTo(this.scrollTo);
    if (this.instant)
      this.scroller.rectTransform.anchoredPosition = this.scroller.targetPos;
  }
}
