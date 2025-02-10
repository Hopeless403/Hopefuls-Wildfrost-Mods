// Decompiled with JetBrains decompiler
// Type: SnowfallParticles
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class SnowfallParticles : MonoBehaviour
{
  [SerializeField]
  [Range(0.0f, 1f)]
  [OnValueChanged("Evaluate")]
  public float storminess;
  [SerializeField]
  public AnimationCurve updateCurve;
  [Header("References")]
  [SerializeField]
  public ParticleSystem backSnow;
  [SerializeField]
  public ParticleSystem midSnow;
  [SerializeField]
  public ParticleSystem frontSnow;
  [SerializeField]
  public ParticleSystem bloops;
  [SerializeField]
  public SpriteRenderer fade;
  [Header("Values To Adjust")]
  [SerializeField]
  public AnimationCurve angleRange;
  [SerializeField]
  public AnimationCurve backEmissionRange;
  [SerializeField]
  public AnimationCurve midEmissionRange;
  [SerializeField]
  public AnimationCurve frontEmissionRange;
  [SerializeField]
  public AnimationCurve bloopsEmissionRange;
  [SerializeField]
  public AnimationCurve fadeAlphaRange;
  [SerializeField]
  public AnimationCurve simulationSpeedRange;
  [SerializeField]
  public AnimationCurve backSnowGravityRange;
  [SerializeField]
  public AnimationCurve midSnowGravityRange;
  [SerializeField]
  public AnimationCurve frontSnowGravityRange;
  [SerializeField]
  public AnimationCurve bloopsGravityRange;
  [SerializeField]
  public AnimationCurve xRange;
  [SerializeField]
  public AnimationCurve backSnowXSpeedRange;
  [SerializeField]
  public AnimationCurve midSnowXSpeedRange;
  [SerializeField]
  public AnimationCurve frontSnowXSpeedRange;
  [SerializeField]
  public AnimationCurve bloopsXSpeedRange;
  public ParticleSystem.MainModule backSnowMain;
  public ParticleSystem.MainModule midSnowMain;
  public ParticleSystem.MainModule frontSnowMain;
  public ParticleSystem.MainModule bloopsMain;
  public ParticleSystem.EmissionModule backSnowEmission;
  public ParticleSystem.EmissionModule midSnowEmission;
  public ParticleSystem.EmissionModule frontSnowEmission;
  public ParticleSystem.EmissionModule bloopsEmission;
  public ParticleSystem.VelocityOverLifetimeModule backSnowVel;
  public ParticleSystem.VelocityOverLifetimeModule midSnowVel;
  public ParticleSystem.VelocityOverLifetimeModule frontSnowVel;
  public ParticleSystem.VelocityOverLifetimeModule bloopsVel;
  public float t = 1f;
  public float storminessFrom;
  public float storminessTo;
  public float d = 1f;

  public void Awake()
  {
    this.backSnowMain = this.backSnow.main;
    this.midSnowMain = this.midSnow.main;
    this.frontSnowMain = this.frontSnow.main;
    this.bloopsMain = this.bloops.main;
    this.backSnowEmission = this.backSnow.emission;
    this.midSnowEmission = this.midSnow.emission;
    this.frontSnowEmission = this.frontSnow.emission;
    this.bloopsEmission = this.bloops.emission;
    this.backSnowVel = this.backSnow.velocityOverLifetime;
    this.midSnowVel = this.midSnow.velocityOverLifetime;
    this.frontSnowVel = this.frontSnow.velocityOverLifetime;
    this.bloopsVel = this.bloops.velocityOverLifetime;
  }

  public void OnEnable()
  {
    global::Events.OnSetWeatherIntensity += new UnityAction<float, float>(this.SetStorminess);
    this.Evaluate();
  }

  public void OnDisable()
  {
    global::Events.OnSetWeatherIntensity -= new UnityAction<float, float>(this.SetStorminess);
  }

  public void SetStorminess(float amount, float duration)
  {
    this.storminessFrom = this.storminess;
    this.storminessTo = amount;
    this.t = 0.0f;
    this.d = duration;
  }

  public void Update()
  {
    if ((double) this.t >= 1.0)
      return;
    this.t += Time.deltaTime / this.d;
    this.storminess = this.storminessFrom + (this.storminessTo - this.storminessFrom) * this.updateCurve.Evaluate(this.t);
    this.Evaluate();
  }

  public void Evaluate()
  {
    this.transform.localEulerAngles = new Vector3(0.0f, 0.0f, this.angleRange.Evaluate(this.storminess));
    this.backSnowEmission.rateOverTime = (ParticleSystem.MinMaxCurve) this.backEmissionRange.Evaluate(this.storminess);
    this.midSnowEmission.rateOverTime = (ParticleSystem.MinMaxCurve) this.midEmissionRange.Evaluate(this.storminess);
    this.frontSnowEmission.rateOverTime = (ParticleSystem.MinMaxCurve) this.frontEmissionRange.Evaluate(this.storminess);
    this.bloopsEmission.rateOverTime = (ParticleSystem.MinMaxCurve) this.bloopsEmissionRange.Evaluate(this.storminess);
    this.fade.color = this.fade.color.With(alpha: this.fadeAlphaRange.Evaluate(this.storminess));
    float num = this.simulationSpeedRange.Evaluate(this.storminess);
    this.backSnowMain.simulationSpeed = num;
    this.midSnowMain.simulationSpeed = num;
    this.frontSnowMain.simulationSpeed = num;
    this.bloopsMain.simulationSpeed = num;
    float max1 = this.backSnowGravityRange.Evaluate(this.storminess);
    this.backSnowMain.gravityModifier = new ParticleSystem.MinMaxCurve(-max1, max1);
    float max2 = this.midSnowGravityRange.Evaluate(this.storminess);
    this.midSnowMain.gravityModifier = new ParticleSystem.MinMaxCurve(-max2, max2);
    float max3 = this.frontSnowGravityRange.Evaluate(this.storminess);
    this.frontSnowMain.gravityModifier = new ParticleSystem.MinMaxCurve(-max3, max3);
    float max4 = this.bloopsGravityRange.Evaluate(this.storminess);
    this.bloopsMain.gravityModifier = new ParticleSystem.MinMaxCurve(-max4, max4);
    this.transform.SetLocalX(this.xRange.Evaluate(this.storminess));
    this.backSnowVel.xMultiplier = this.backSnowXSpeedRange.Evaluate(this.storminess);
    this.midSnowVel.xMultiplier = this.midSnowXSpeedRange.Evaluate(this.storminess);
    this.frontSnowVel.xMultiplier = this.frontSnowXSpeedRange.Evaluate(this.storminess);
    this.bloopsVel.xMultiplier = this.bloopsXSpeedRange.Evaluate(this.storminess);
  }
}
