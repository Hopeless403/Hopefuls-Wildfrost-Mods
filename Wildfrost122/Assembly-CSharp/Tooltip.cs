// Decompiled with JetBrains decompiler
// Type: Tooltip
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public abstract class Tooltip : MonoBehaviour
{
  public bool animate = true;
  public bool ignoreTimeScale;
  public readonly HashSet<Tooltip> children = new HashSet<Tooltip>();
  [SerializeField]
  protected CanvasGroup canvasGroup;
  [Header("Panel")]
  [SerializeField]
  protected Image panel;
  [SerializeField]
  protected Sprite defaultPanelSprite;
  [SerializeField]
  protected Color defaultPanelColor;
  [Header("Animation")]
  [SerializeField]
  protected Vector3 scaleFrom = Vector3.zero;
  [SerializeField]
  protected AnimationCurve scaleCurve;
  [SerializeField]
  protected float scaleDur = 0.5f;
  [SerializeField]
  protected float fadeFrom;
  [SerializeField]
  protected AnimationCurve fadeCurve;
  [SerializeField]
  protected float fadeDur = 0.2f;

  protected void Ping()
  {
    if (!this.animate)
      return;
    LeanTween.cancel(this.gameObject);
    this.transform.localScale = this.scaleFrom;
    LeanTween.scale(this.gameObject, Vector3.one, this.scaleDur).setEase(this.scaleCurve).setIgnoreTimeScale(this.ignoreTimeScale);
    this.canvasGroup.alpha = this.fadeFrom;
    this.canvasGroup.LeanAlpha(1f, this.fadeDur).setEase(this.fadeCurve).setIgnoreTimeScale(this.ignoreTimeScale);
  }
}
