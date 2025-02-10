// Decompiled with JetBrains decompiler
// Type: FloatingText
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using TMPro;
using UnityEngine;

#nullable disable
public class FloatingText : MonoBehaviour
{
  [SerializeField]
  private TMP_Text textAsset;
  [SerializeField]
  private Canvas canvas;
  [SerializeField]
  private CanvasGroup canvasGroup;

  public static FloatingText Create(Vector3 position)
  {
    FloatingText fromPool = FloatingTextManager.GetFromPool();
    fromPool.transform.position = position;
    return fromPool;
  }

  public static FloatingText Create(Vector3 position, string text)
  {
    FloatingText fromPool = FloatingTextManager.GetFromPool();
    fromPool.transform.position = position;
    fromPool.SetText(text);
    return fromPool;
  }

  public FloatingText SetText(string text)
  {
    this.textAsset.text = text;
    return this;
  }

  public FloatingText Reset()
  {
    this.canvas.overrideSorting = false;
    this.canvasGroup.alpha = 1f;
    return this;
  }

  public FloatingText SetSortingLayer(string sortingLayerName, int orderInLayer)
  {
    this.canvas.overrideSorting = true;
    this.canvas.sortingLayerName = sortingLayerName;
    this.canvas.sortingOrder = orderInLayer;
    return this;
  }

  public FloatingText Animate(string animationName, float strength = 1f)
  {
    FloatingTextManager.Animation animation = FloatingTextManager.GetAnimation(animationName);
    if (animation.tweens != null && animation.tweens.Length != 0)
      this.StartCoroutine(this.AnimateRoutine(animation, strength));
    return this;
  }

  public FloatingText Fade(string fadeCurveName, float duration = 1f, float delay = 0.0f)
  {
    this.StartCoroutine(this.FadeRoutine(FloatingTextManager.GetFadeCurve(fadeCurveName).curve, duration, delay));
    return this;
  }

  public FloatingText Fade(AnimationCurve curve, float duration = 1f, float delay = 0.0f)
  {
    this.StartCoroutine(this.FadeRoutine(curve, duration, delay));
    return this;
  }

  public FloatingText DestroyAfterSeconds(float seconds)
  {
    this.StartCoroutine(this.DestroyAfterSecondsRoutine(seconds));
    return this;
  }

  private IEnumerator AnimateRoutine(FloatingTextManager.Animation animation, float strength)
  {
    // ISSUE: reference to a compiler-generated field
    int num = this.\u003C\u003E1__state;
    FloatingText floatingText = this;
    if (num != 0)
    {
      if (num != 1)
        return false;
      // ISSUE: reference to a compiler-generated field
      this.\u003C\u003E1__state = -1;
      return false;
    }
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = -1;
    animation.Fire(floatingText.gameObject, strength);
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E2__current = (object) floatingText.DestroyAfterSecondsRoutine(animation.GetDuration());
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = 1;
    return true;
  }

  private IEnumerator DestroyAfterSecondsRoutine(float seconds)
  {
    // ISSUE: reference to a compiler-generated field
    int num = this.\u003C\u003E1__state;
    FloatingText floatingText = this;
    if (num != 0)
    {
      if (num != 1)
        return false;
      // ISSUE: reference to a compiler-generated field
      this.\u003C\u003E1__state = -1;
      FloatingTextManager.ReturnToPool(floatingText);
      return false;
    }
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = -1;
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E2__current = (object) Sequences.Wait(seconds);
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = 1;
    return true;
  }

  private IEnumerator FadeRoutine(AnimationCurve curve, float duration = 1f, float delay = 0.0f)
  {
    FloatingText floatingText = this;
    if ((double) delay > 0.0)
      yield return (object) Sequences.Wait(delay);
    if (curve.length > 1)
    {
      float t1 = curve[0].time;
      float num = curve[curve.length - 1].time - t1;
      float currentTime = 0.0f;
      float scale = num / duration;
      while ((double) currentTime <= (double) duration)
      {
        floatingText.canvasGroup.alpha = curve.Evaluate(t1 + currentTime * scale);
        currentTime += Time.deltaTime;
        yield return (object) null;
      }
    }
    FloatingTextManager.ReturnToPool(floatingText);
  }
}
