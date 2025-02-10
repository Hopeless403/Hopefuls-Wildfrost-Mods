// Decompiled with JetBrains decompiler
// Type: CameraRumbleSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using Dead;
using NaughtyAttributes;
using UnityEngine;

#nullable disable
public class CameraRumbleSystem : GameSystem
{
  public Transform target;
  [HorizontalLine(2f, EColor.Gray)]
  public float strength = 1f;
  public Vector3 positionInfluence = new Vector3(1f, 1f, 1f);
  public Vector3 rotationInfluence = new Vector3(1f, 1f, 1f);
  public float t;
  public float d;
  [SerializeField]
  public AnimationCurve curve;
  public bool active;
  public float delay;

  public void OnEnable()
  {
    Events.OnScreenRumble += new Events.UnityAction<float, float, float, float, float, float>(this.Rumble);
  }

  public void OnDisable()
  {
    Events.OnScreenRumble -= new Events.UnityAction<float, float, float, float, float, float>(this.Rumble);
  }

  public void Update()
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

  public void Rumble(
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
