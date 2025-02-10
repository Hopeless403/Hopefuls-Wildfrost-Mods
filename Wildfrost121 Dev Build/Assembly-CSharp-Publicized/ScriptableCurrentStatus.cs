// Decompiled with JetBrains decompiler
// Type: ScriptableCurrentStatus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Scriptable Amount/Current Status", fileName = "CurrentStatus")]
public class ScriptableCurrentStatus : ScriptableAmount
{
  [SerializeField]
  public string statusType = "shroom";
  [SerializeField]
  public int offset;
  [SerializeField]
  public float multiplier = 1f;
  [SerializeField]
  public bool roundUp;

  public override int Get(Entity entity)
  {
    int amount;
    if (!(bool) (Object) entity)
    {
      amount = this.offset;
    }
    else
    {
      StatusEffectData status = entity.FindStatus(this.statusType);
      amount = status != null ? status.count + this.offset : this.offset;
    }
    return this.Mult(amount);
  }

  public int Mult(int amount)
  {
    return !this.roundUp ? Mathf.FloorToInt((float) amount * this.multiplier) : Mathf.RoundToInt((float) amount * this.multiplier);
  }
}
