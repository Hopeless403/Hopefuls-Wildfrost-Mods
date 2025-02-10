// Decompiled with JetBrains decompiler
// Type: Blink
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using DeadExtensions;
using UnityEngine;

public class Blink : MonoBehaviour
{
  public Vector2 onRange = new Vector2(5f, 6f);
  public Vector2 offRange = new Vector2(0.1f, 0.1f);
  public AnimationCurve blinkCurve;
  public AnimationCurve unblinkCurve;
  public float blinkCurveDuration = 0.1f;
  [SerializeField]
  private bool startOn = true;
  private bool on;
  private float timer;
  private float preScaleY;

  private void Awake()
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

  private void Update()
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
