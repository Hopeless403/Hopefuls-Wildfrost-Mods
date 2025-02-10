// Decompiled with JetBrains decompiler
// Type: MapStamp
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Runtime.CompilerServices;
using UnityEngine;

#nullable disable
[RequireComponent(typeof (SpriteRenderer))]
public class MapStamp : MonoBehaviour
{
  public SpriteRenderer spriteRenderer;

  public void Awake() => this.spriteRenderer = this.GetComponent<SpriteRenderer>();

  public void Stamp(Vector3 position)
  {
    this.gameObject.SetActive(true);
    this.transform.position = position;
    this.transform.localEulerAngles = new Vector3(0.0f, 0.0f, (float) UnityEngine.Random.Range(-20, 20));
    LeanTween.cancel(this.gameObject);
    this.transform.localScale = Vector3.one * 2f;
    LeanTween.scale(this.gameObject, Vector3.one, 0.5f).setEase(LeanTweenType.easeOutBounce);
    this.spriteRenderer.color = new Color(1f, 1f, 1f, 0.0f);
    LeanTween.color(this.gameObject, Color.white, 0.33f).setEase(LeanTweenType.easeOutQuad);
  }

  public void FadeOut()
  {
    LeanTween.cancel(this.gameObject);
    LeanTween.color(this.gameObject, new Color(1f, 1f, 1f, 0.0f), 0.33f).setEase(LeanTweenType.easeOutQuad).setOnComplete((System.Action) (() => this.gameObject.SetActive(false)));
  }

  [CompilerGenerated]
  public void \u003CFadeOut\u003Eb__3_0() => this.gameObject.SetActive(false);
}
