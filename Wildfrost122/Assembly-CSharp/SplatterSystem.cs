// Decompiled with JetBrains decompiler
// Type: SplatterSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using Dead;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class SplatterSystem : GameSystem
{
  private static SplatterSystem instance;
  [SerializeField]
  [Range(0.0f, 2f)]
  private float spread = 1f;
  [SerializeField]
  private Vector2 speedRange = new Vector2(1f, 10f);
  [SerializeField]
  private Vector2 upSpeedRange = new Vector2(-1f, 0.0f);
  [SerializeField]
  [Range(0.0f, 2f)]
  private float bloodAmount = 1f;
  [SerializeField]
  [Range(1f, 10f)]
  private int maxPerHit = 6;
  [SerializeField]
  private Gradient rainbow;
  [SerializeField]
  private int maxTweens = 200;
  private static int BloodType;
  private static float BloodAmount;
  private readonly List<float> tweens = new List<float>();

  private void OnEnable()
  {
    SplatterSystem.instance = this;
    global::Events.OnEntityHit += new UnityAction<Hit>(this.EntityHit);
    global::Events.OnSettingChanged += new UnityAction<string, object>(SplatterSystem.SettingChanged);
    SplatterSystem.BloodType = Settings.Load<int>("Blood", 0);
    SplatterSystem.BloodAmount = Settings.Load<float>("BloodAmount", 1f);
  }

  private void OnDisable()
  {
    global::Events.OnEntityHit -= new UnityAction<Hit>(this.EntityHit);
    global::Events.OnSettingChanged -= new UnityAction<string, object>(SplatterSystem.SettingChanged);
  }

  private void Update()
  {
    float deltaTime = Time.deltaTime;
    for (int index = this.tweens.Count - 1; index >= 0; --index)
    {
      this.tweens[index] -= deltaTime;
      if ((double) this.tweens[index] < 0.0)
      {
        this.tweens.RemoveAt(index);
        --index;
      }
    }
  }

  private static void SettingChanged(string key, object value)
  {
    switch (key)
    {
      case "BloodAmount":
        if (!(value is float num1))
          break;
        SplatterSystem.BloodAmount = num1;
        break;
      case "Blood":
        if (!(value is int num2))
          break;
        SplatterSystem.BloodType = num2;
        break;
    }
  }

  private void EntityHit(Hit hit)
  {
    if (!hit.Offensive || hit.nullified || !hit.BasicHit || !hit.countsAsHit || !(bool) (Object) hit.target)
      return;
    BloodProfile bloodProfile = hit.target.data.bloodProfile;
    if (!(bool) (Object) bloodProfile)
      return;
    int num = Mathf.RoundToInt((float) Mathf.Min(hit.damage, this.maxPerHit) * this.bloodAmount * bloodProfile.bleedFactor * SplatterSystem.BloodAmount);
    Vector3 vector3_1 = !(bool) (Object) hit.attacker || !(bool) (Object) hit.target ? new Vector3(PettyRandom.Range(-1f, 1f), PettyRandom.Range(-1f, 1f), 0.0f).normalized : (hit.target.transform.position - hit.attacker.transform.position).normalized;
    for (int index = 0; index < num; ++index)
    {
      SplatterParticle splatterParticle = Object.Instantiate<SplatterParticle>(bloodProfile.splatterParticlePrefab);
      Vector3 vector3_2 = new Vector3(PettyRandom.Range(-1f, 1f), PettyRandom.Range(-1.5f, 1.5f), 0.0f);
      splatterParticle.transform.position = hit.target.transform.position + vector3_2;
      splatterParticle.color = this.GetBloodColour(hit.target);
      splatterParticle.velocity = (vector3_1 * this.speedRange.PettyRandom() + PettyRandom.Vector3() * this.spread).WithZ(this.upSpeedRange.PettyRandom());
      splatterParticle.SetSource(hit.target.GetComponentInChildren<SplatterSurface>());
    }
  }

  public Color GetBloodColour(Entity entity)
  {
    return SplatterSystem.BloodType != 1 ? ((bool) (Object) entity.data.bloodProfile ? (entity.data.bloodProfile.variableColor ? entity.data.bloodProfile.colorRange.Evaluate(entity.data.random3.x.Mod(1f)) : entity.data.bloodProfile.color) : Color.white) : this.rainbow.Evaluate(entity.data.random3.x.Mod(1f));
  }

  public static bool CheckStartTween(float time)
  {
    if (SplatterSystem.instance.tweens.Count >= SplatterSystem.instance.maxTweens)
      return false;
    SplatterSystem.instance.tweens.Add(time);
    return true;
  }
}
