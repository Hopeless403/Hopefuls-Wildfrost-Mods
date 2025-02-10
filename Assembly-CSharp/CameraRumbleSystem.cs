// Decompiled with JetBrains decompiler
// Type: CameraRumbleSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using Dead;
using NaughtyAttributes;
using UnityEngine;

public class CameraRumbleSystem : GameSystem
{
  public Transform target;
  [HorizontalLine(2f, EColor.Gray)]
  public float strength = 1f;
  public Vector3 positionInfluence = new Vector3(1f, 1f, 1f);
  public Vector3 rotationInfluence = new Vector3(1f, 1f, 1f);
  private float t;
  private float d;
  [SerializeField]
  private AnimationCurve curve;
  private bool active;
  private float delay;

  private void OnEnable() => Events.OnScreenRumble += new Events.UnityAction<float, float, float, float, float, float>(this.Rumble);

  private void OnDisable() => Events.OnScreenRumble -= new Events.UnityAction<float, float, float, float, float, float>(this.Rumble);

  private void Update()
  {
    if (!this.active)
      return;
    if ((double) this.delay > 0.0)
    {
      this.delay -= Time.deltaTime;
    }
    else
    {
      this.t += Time.deltaTime;
      float num = ((double) this.t <= (double) this.d ? this.curve.Evaluate(this.t) : 0.0f) * this.strength * CameraShakerSystem.ShakeAmount;
      if ((double) num > 0.0)
      {
        this.target.localPosition = Vector3.Cross(this.positionInfluence, PettyRandom.Vector3()) * num;
        this.target.localEulerAngles = Vector3.Cross(this.rotationInfluence, PettyRandom.Vector3()) * num;
      }
      else
      {
        this.target.localPosition = Vector3.zero;
        this.target.localEulerAngles = Vector3.zero;
      }
      if ((double) this.t <= (double) this.d)
        return;
      this.active = false;
    }
  }

  private void Rumble(
    float startStrength,
    float endStrength,
    float delay,
    float fadeInTime,
    float holdTime,
    float fadeOutTime)
  {
    this.delay = delay;
    this.t = 0.0f;
    this.d = fadeInTime + holdTime + fadeOutTime;
    this.curve = new AnimationCurve(new Keyframe[4]
    {
      new Keyframe(0.0f, startStrength, 0.0f, 0.0f),
      new Keyframe(fadeInTime, endStrength, 0.0f, 0.0f),
      new Keyframe(fadeInTime + holdTime, endStrength, 0.0f, 0.0f),
      new Keyframe(this.d, 0.0f, 0.0f, 0.0f)
    });
    this.active = true;
    this.target.localPosition = Vector3.zero;
    this.target.localEulerAngles = Vector3.zero;
  }
}
