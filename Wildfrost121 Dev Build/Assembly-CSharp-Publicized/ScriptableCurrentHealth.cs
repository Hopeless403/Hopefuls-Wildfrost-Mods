// Decompiled with JetBrains decompiler
// Type: ScriptableCurrentHealth
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Scriptable Amount/Current Health", fileName = "CurrentHealth")]
public class ScriptableCurrentHealth : ScriptableAmount
{
  [SerializeField]
  public float multiplier = 1f;
  [SerializeField]
  public bool roundUp;

  public override int Get(Entity entity)
  {
    return !(bool) (Object) entity || !entity.data.hasHealth ? 0 : this.Mult(entity.hp.current);
  }

  public int Mult(int amount)
  {
    return !this.roundUp ? Mathf.FloorToInt((float) amount * this.multiplier) : Mathf.RoundToInt((float) amount * this.multiplier);
  }
}
