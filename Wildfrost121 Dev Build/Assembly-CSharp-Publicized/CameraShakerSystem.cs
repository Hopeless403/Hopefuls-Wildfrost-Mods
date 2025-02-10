// Decompiled with JetBrains decompiler
// Type: CameraShakerSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using System;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class CameraShakerSystem : GameSystem
{
  public Transform target;
  [HorizontalLine(2f, EColor.Gray)]
  public float magnitudeMod = 1f;
  public float angularMod = 0.67f;
  public float accelerationMod = 300f;
  [HorizontalLine(2f, EColor.Gray)]
  [SerializeField]
  public AnimationCurve hitStrengthCurve;
  [HorizontalLine(2f, EColor.Gray)]
  [Range(0.0f, 1f)]
  public float frict = 0.2f;
  [Range(0.0f, 180f)]
  public float angleRand = 20f;
  [Range(0.0f, 1f)]
  public float angularFrict = 0.1f;
  [HorizontalLine(2f, EColor.Gray)]
  public Vector3 positionInfluence = new Vector3(0.2f, 0.2f, 0.0f);
  public Vector3 rotationInfluence = new Vector3(1f, 1f, 1f);
  public Vector2 pos;
  public Vector2 velocity;
  public float angle;
  public float angularSpeed;
  public static float ShakeAmount;

  public void OnEnable()
  {
    global::Events.OnEntityHit += new UnityAction<global::Hit>(this.Hit);
    global::Events.OnScreenShake += new UnityAction<float, float?>(this.Shake);
    global::Events.OnSettingChanged += new UnityAction<string, object>(CameraShakerSystem.SettingChanged);
    CameraShakerSystem.ShakeAmount = Settings.Load<float>("ScreenShake", 1f);
  }

  public void OnDisable()
  {
    global::Events.OnEntityHit -= new UnityAction<global::Hit>(this.Hit);
    global::Events.OnScreenShake -= new UnityAction<float, float?>(this.Shake);
    global::Events.OnSettingChanged -= new UnityAction<string, object>(CameraShakerSystem.SettingChanged);
    this.Stop();
  }

  public static void SettingChanged(string key, object value)
  {
    if (!(key == "ScreenShake") || !(value is float num))
      return;
    CameraShakerSystem.ShakeAmount = num;
  }

  public void Hit(global::Hit hit)
  {
    if (!hit.Offensive || (double) hit.screenShake <= 0.0)
      return;
    float hitDirection = this.GetHitDirection(hit);
    int offensiveness = hit.GetOffensiveness();
    this.Shake(hit.screenShake * this.hitStrengthCurve.Evaluate((float) offensiveness), new float?(hitDirection));
  }

  [Button("Test Shake", EButtonEnableMode.Always)]
  public void Shake(float magnitude = 1f)
  {
    this.Shake(magnitude, new float?(DeadExtensions.PettyRandom.value * 360f));
  }

  public void Shake(float magnitude = 1f, float? direction = null)
  {
    float radians = (float) ((((double) direction ?? (double) Dead.PettyRandom.Range(0.0f, 360f)) + (double) Dead.PettyRandom.Range(-this.angleRand, this.angleRand)) * (Math.PI / 180.0));
    this.velocity = Lengthdir.ToVector2(this.velocity.magnitude + magnitude * this.magnitudeMod * CameraShakerSystem.ShakeAmount, radians);
    this.angularSpeed += magnitude * CameraShakerSystem.ShakeAmount * this.angularMod.WithRandomSign();
  }

  [Button(null, EButtonEnableMode.Always)]
  public void Stop()
  {
    this.velocity = Vector2.zero;
    this.pos = Vector2.zero;
    this.angle = 0.0f;
    this.angularSpeed = 0.0f;
    if (!((UnityEngine.Object) this.target != (UnityEngine.Object) null))
      return;
    this.target.localPosition = Vector3.zero;
    this.target.localEulerAngles = Vector3.zero;
  }

  public void Update()
  {
    float magnitude = this.pos.magnitude;
    if ((double) magnitude > 0.0099999997764825821)
    {
      float radians = this.pos.Angle();
      this.velocity -= Lengthdir.ToVector2(magnitude * this.accelerationMod, radians) * Time.deltaTime;
    }
    this.velocity = Delta.Multiply(this.velocity, 1f - this.frict, Time.deltaTime);
    this.pos += this.velocity * Time.deltaTime;
    this.angularSpeed -= this.angle * this.accelerationMod * Time.deltaTime;
    this.angularSpeed = Delta.Multiply(this.angularSpeed, 1f - this.angularFrict, Time.deltaTime);
    this.angle += this.angularSpeed * Time.deltaTime;
    this.target.localPosition = Vector3.Scale(new Vector3(-this.pos.x, this.pos.y, this.angle), this.positionInfluence);
    this.target.localEulerAngles = Vector3.Scale(new Vector3(-this.pos.x, this.pos.y, this.angle), this.rotationInfluence);
  }

  public float GetHitDirection(global::Hit hit)
  {
    return !(bool) (UnityEngine.Object) hit.attacker ? Dead.PettyRandom.Range(0.0f, 360f) : hit.attacker.transform.position.AngleTo(hit.target.transform.position);
  }
}
