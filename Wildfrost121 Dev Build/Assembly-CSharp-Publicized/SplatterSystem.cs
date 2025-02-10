// Decompiled with JetBrains decompiler
// Type: SplatterSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using Dead;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class SplatterSystem : GameSystem
{
  [SerializeField]
  [Range(0.0f, 2f)]
  public float spread = 1f;
  [SerializeField]
  public Vector2 speedRange = new Vector2(1f, 10f);
  [SerializeField]
  public Vector2 upSpeedRange = new Vector2(-1f, 0.0f);
  [SerializeField]
  [Range(0.0f, 2f)]
  public float bloodAmount = 1f;
  [SerializeField]
  [Range(1f, 10f)]
  public int maxPerHit = 6;
  [SerializeField]
  public Gradient rainbow;
  public static int BloodType;
  public static float BloodAmount;

  public void OnEnable()
  {
    global::Events.OnEntityHit += new UnityAction<Hit>(this.EntityHit);
    global::Events.OnSettingChanged += new UnityAction<string, object>(SplatterSystem.SettingChanged);
    SplatterSystem.BloodType = Settings.Load<int>("Blood", 0);
    SplatterSystem.BloodAmount = Settings.Load<float>("BloodAmount", 1f);
  }

  public void OnDisable()
  {
    global::Events.OnEntityHit -= new UnityAction<Hit>(this.EntityHit);
    global::Events.OnSettingChanged -= new UnityAction<string, object>(SplatterSystem.SettingChanged);
  }

  public static void SettingChanged(string key, object value)
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

  public void EntityHit(Hit hit)
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
}
