// Decompiled with JetBrains decompiler
// Type: ScriptableCurrentHealth
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Scriptable Amount/Current Health", fileName = "CurrentHealth")]
public class ScriptableCurrentHealth : ScriptableAmount
{
  [SerializeField]
  private float multiplier = 1f;
  [SerializeField]
  private bool roundUp;

  public override int Get(Entity entity)
  {
    return !(bool) (Object) entity || !entity.data.hasHealth ? 0 : this.Mult(entity.hp.current);
  }

  private int Mult(int amount)
  {
    return !this.roundUp ? Mathf.FloorToInt((float) amount * this.multiplier) : Mathf.RoundToInt((float) amount * this.multiplier);
  }
}
