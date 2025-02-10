// Decompiled with JetBrains decompiler
// Type: Blink
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using DeadExtensions;
using UnityEngine;

#nullable disable
public class Blink : MonoBehaviour
{
  public Vector2 onRange = new Vector2(5f, 6f);
  public Vector2 offRange = new Vector2(0.1f, 0.1f);
  public AnimationCurve blinkCurve;
  public AnimationCurve unblinkCurve;
  public float blinkCurveDuration = 0.1f;
  [SerializeField]
  public bool startOn = true;
  public bool on;
  public float timer;
  public float preScaleY;

  public void Awake()
  {
    this.on = this.startOn;
    if (this.on)
    {
      this.timer = this.onRange.PettyRandom() * PettyRandom.value;
    }
    else
    {
      Transform transform = this.transform;
      Vector3 localScale = transform.localScale;
      this.preScaleY = localScale.y;
      localScale.y = 0.0f;
      transform.localScale = localScale;
      this.timer = this.offRange.PettyRandom() * PettyRandom.value;
    }
  }

  public void Update()
  {
    this.timer -= Time.deltaTime;
    if ((double) this.timer > 0.0)
      return;
    this.Toggle();
  }

  public void Toggle()
  {
    this.on = !this.on;
    LeanTween.cancel(this.gameObject);
    if (this.on)
    {
      LeanTween.scaleY(this.gameObject, this.preScaleY, this.blinkCurveDuration).setEase(this.unblinkCurve);
    }
    else
    {
      this.preScaleY = this.transform.localScale.y;
      LeanTween.scaleY(this.gameObject, 0.0f, this.blinkCurveDuration).setEase(this.blinkCurve);
    }
    if (this.on)
      this.timer = this.onRange.PettyRandom();
    else
      this.timer = this.offRange.PettyRandom();
  }
}
