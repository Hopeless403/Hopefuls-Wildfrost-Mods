// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectWeather
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectWeather : StatusEffectData
  {
    private SnowfallParticles snowfall;
    private bool active;
    public float intensityMultiplier = 2f;
    public Color color;

    public override bool RunBeginEvent()
    {
      if ((Object) References.Battle != (Object) null && Battle.IsOnBoard(this.target))
        this.Activate();
      return false;
    }

    public void OnDestroy() => this.Deactivate();

    public override bool RunEndEvent()
    {
      this.Deactivate();
      return false;
    }

    public void Activate()
    {
      if (this.active)
        return;
      this.snowfall = GameObject.Find("Battle/Background/BackgroundSnowland(Clone)")?.GetComponentInChildren<SnowfallParticles>() ?? GameObject.Find("Battle/Background/BackgroundFrostland 5(Clone)")?.GetComponentInChildren<SnowfallParticles>() ?? GameObject.Find("Battle/Background/BackgroundFinalBoss 4(Clone)")?.GetComponentInChildren<SnowfallParticles>();
      if ((Object) this.snowfall != (Object) null)
        this.snowfall.frontSnow.startColor = this.color;
      this.active = true;
      global::Events.OnSetWeatherIntensity += new UnityAction<float, float>(this.Events_OnSetWeatherIntensity);
      global::Events.InvokeSetWeatherIntensity(0.2f, 1f);
    }

    private void Events_OnSetWeatherIntensity(float intensity, float duration)
    {
      if ((Object) this.snowfall == (Object) null)
        this.Deactivate();
      else
        this.snowfall.storminessTo = intensity * this.intensityMultiplier;
    }

    public void Deactivate()
    {
      if (!this.active)
        return;
      if ((Object) this.snowfall != (Object) null)
        this.snowfall.frontSnow.startColor = new Color(1f, 1f, 1f, 1f);
      this.active = false;
      global::Events.OnSetWeatherIntensity -= new UnityAction<float, float>(this.Events_OnSetWeatherIntensity);
      global::Events.InvokeSetWeatherIntensity(0.1f, 1f);
    }
  }
}
