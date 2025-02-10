// Decompiled with JetBrains decompiler
// Type: Tooltip
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

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
  public CanvasGroup canvasGroup;
  [Header("Panel")]
  [SerializeField]
  public Image panel;
  [SerializeField]
  public Sprite defaultPanelSprite;
  [SerializeField]
  public Color defaultPanelColor;
  [Header("Animation")]
  [SerializeField]
  public Vector3 scaleFrom = Vector3.zero;
  [SerializeField]
  public AnimationCurve scaleCurve;
  [SerializeField]
  public float scaleDur = 0.5f;
  [SerializeField]
  public float fadeFrom;
  [SerializeField]
  public AnimationCurve fadeCurve;
  [SerializeField]
  public float fadeDur = 0.2f;

  public void Ping()
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
