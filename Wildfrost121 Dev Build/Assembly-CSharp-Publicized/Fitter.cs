// Decompiled with JetBrains decompiler
// Type: Fitter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using System.Collections;
using UnityEngine;

#nullable disable
public class Fitter : MonoBehaviourRect
{
  [SerializeField]
  public Fitter[] linkedFitters;
  public Vector2 padding;
  public bool widthFixed = true;
  [ShowIf("widthFixed")]
  public float fixedWidth = 2.4f;
  [HideIf("widthFixed")]
  public float minWidth = 2.4f;
  public bool heightFixed;
  [ShowIf("heightFixed")]
  public float fixedHeight = 0.5f;
  [HideIf("heightFixed")]
  public float minHeight = 0.5f;

  public void Fit(System.Action onComplete) => this.StartCoroutine(this.FitRoutine(onComplete));

  public void SetSize(float w, float h)
  {
    this.rectTransform.sizeDelta = new Vector2(w, h) + this.padding;
  }

  public virtual IEnumerator FitRoutine(System.Action onComplete)
  {
    Fitter fitter = this;
    float w = fitter.fixedWidth;
    float h = fitter.fixedHeight;
    if (!fitter.widthFixed && !fitter.heightFixed)
    {
      float a1;
      float a2 = a1 = fitter.rectTransform.localPosition.x;
      float a3;
      float a4 = a3 = fitter.rectTransform.localPosition.y;
      foreach (RectTransform rectTransform in (Transform) fitter.rectTransform)
      {
        Vector2 vector2 = rectTransform.sizeDelta * 0.5f;
        Vector3 localPosition = rectTransform.localPosition;
        a2 = Mathf.Min(a2, localPosition.x - vector2.x);
        a4 = Mathf.Min(a4, localPosition.y - vector2.y);
        a1 = Mathf.Max(a1, localPosition.x + vector2.x);
        a3 = Mathf.Max(a3, localPosition.y + vector2.y);
      }
      w = a1 - a2;
      h = a3 - a4;
    }
    else
    {
      if (!fitter.widthFixed)
      {
        float a5;
        float a6 = a5 = 0.0f;
        foreach (RectTransform rectTransform in (Transform) fitter.rectTransform)
        {
          Vector2 vector2 = rectTransform.sizeDelta * 0.5f;
          Vector3 localPosition = rectTransform.localPosition;
          a6 = Mathf.Min(a6, localPosition.x - vector2.x);
          a5 = Mathf.Max(a5, localPosition.x + vector2.x);
        }
        w = Mathf.Max(fitter.minWidth, a5 - a6);
      }
      if (!fitter.heightFixed)
      {
        float a7;
        float a8 = a7 = 0.0f;
        foreach (RectTransform rectTransform in (Transform) fitter.rectTransform)
        {
          Vector2 vector2 = rectTransform.sizeDelta * 0.5f;
          Vector3 localPosition = rectTransform.localPosition;
          a8 = Mathf.Min(a8, localPosition.y - vector2.y);
          a7 = Mathf.Max(a7, localPosition.y + vector2.y);
        }
        h = Mathf.Max(fitter.minHeight, a7 - a8);
      }
    }
    fitter.SetSize(w, h);
    yield return (object) fitter.UpdateLinkedFitters();
    System.Action action = onComplete;
    if (action != null)
      action();
  }

  public IEnumerator UpdateLinkedFitters()
  {
    Fitter[] fitterArray = this.linkedFitters;
    for (int index = 0; index < fitterArray.Length; ++index)
      yield return (object) fitterArray[index].FitRoutine((System.Action) null);
    fitterArray = (Fitter[]) null;
  }
}
