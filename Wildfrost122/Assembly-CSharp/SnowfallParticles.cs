// Decompiled with JetBrains decompiler
// Type: SnowfallParticles
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class SnowfallParticles : MonoBehaviour
{
  [SerializeField]
  [Range(0.0f, 1f)]
  [OnValueChanged("Evaluate")]
  private float storminess;
  [SerializeField]
  private AnimationCurve updateCurve;
  [Header("References")]
  [SerializeField]
  private ParticleSystem backSnow;
  [SerializeField]
  private ParticleSystem midSnow;
  [SerializeField]
  private ParticleSystem frontSnow;
  [SerializeField]
  private ParticleSystem bloops;
  [SerializeField]
  private SpriteRenderer fade;
  [Header("Values To Adjust")]
  [SerializeField]
  private AnimationCurve angleRange;
  [SerializeField]
  private AnimationCurve backEmissionRange;
  [SerializeField]
  private AnimationCurve midEmissionRange;
  [SerializeField]
  private AnimationCurve frontEmissionRange;
  [SerializeField]
  private AnimationCurve bloopsEmissionRange;
  [SerializeField]
  private AnimationCurve fadeAlphaRange;
  [SerializeField]
  private AnimationCurve simulationSpeedRange;
  [SerializeField]
  private AnimationCurve backSnowGravityRange;
  [SerializeField]
  private AnimationCurve midSnowGravityRange;
  [SerializeField]
  private AnimationCurve frontSnowGravityRange;
  [SerializeField]
  private AnimationCurve bloopsGravityRange;
  [SerializeField]
  private AnimationCurve xRange;
  [SerializeField]
  private AnimationCurve backSnowXSpeedRange;
  [SerializeField]
  private AnimationCurve midSnowXSpeedRange;
  [SerializeField]
  private AnimationCurve frontSnowXSpeedRange;
  [SerializeField]
  private AnimationCurve bloopsXSpeedRange;
  private ParticleSystem.MainModule backSnowMain;
  private ParticleSystem.MainModule midSnowMain;
  private ParticleSystem.MainModule frontSnowMain;
  private ParticleSystem.MainModule bloopsMain;
  private ParticleSystem.EmissionModule backSnowEmission;
  private ParticleSystem.EmissionModule midSnowEmission;
  private ParticleSystem.EmissionModule frontSnowEmission;
  private ParticleSystem.EmissionModule bloopsEmission;
  private ParticleSystem.VelocityOverLifetimeModule backSnowVel;
  private ParticleSystem.VelocityOverLifetimeModule midSnowVel;
  private ParticleSystem.VelocityOverLifetimeModule frontSnowVel;
  private ParticleSystem.VelocityOverLifetimeModule bloopsVel;
  private float t = 1f;
  private float storminessFrom;
  private float storminessTo;
  private float d = 1f;

  private void Awake()
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

  private void OnEnable()
  {
    global::Events.OnSetWeatherIntensity += new UnityAction<float, float>(this.SetStorminess);
    this.Evaluate();
  }

  private void OnDisable()
  {
    global::Events.OnSetWeatherIntensity -= new UnityAction<float, float>(this.SetStorminess);
  }

  private void SetStorminess(float amount, float duration)
  {
    this.storminessFrom = this.storminess;
    this.storminessTo = amount;
    this.t = 0.0f;
    this.d = duration;
  }

  private void Update()
  {
    if ((double) this.t >= 1.0)
      return;
    this.t += Time.deltaTime / this.d;
    this.storminess = this.storminessFrom + (this.storminessTo - this.storminessFrom) * this.updateCurve.Evaluate(this.t);
    this.Evaluate();
  }

  private void Evaluate()
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
