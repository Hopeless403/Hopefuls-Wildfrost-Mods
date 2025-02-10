// Decompiled with JetBrains decompiler
// Type: Progression
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using UnityEngine;

#nullable disable
[Serializable]
public class Progression
{
  public float current;
  public float previousRequired;
  public float required = 1f;
  [SerializeField]
  public float randomness = 0.1f;
  [SerializeField]
  public float minProgressAdd = 2f;
  [SerializeField]
  public float maxProgressAdd = 4f;

  public Progression()
  {
  }

  public Progression(float startAmount, float startRequirement, float randomness)
  {
    this.current = startAmount;
    this.previousRequired = 0.0f;
    this.required = startRequirement;
    this.randomness = randomness;
  }

  public bool Add(float amount)
  {
    if (this.RequirementMet())
      return false;
    this.current += amount + UnityEngine.Random.Range(-this.randomness, this.randomness);
    return true;
  }

  public bool RequirementMet() => (double) this.current >= (double) this.required;

  public void SetNextRequirement()
  {
    this.previousRequired = this.required;
    this.required += Mathf.Clamp(this.required, this.minProgressAdd, this.maxProgressAdd);
  }

  public float ProgressToNextUnlock()
  {
    return (float) (((double) this.current - (double) this.previousRequired) / ((double) this.required - (double) this.previousRequired));
  }
}
