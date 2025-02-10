// Decompiled with JetBrains decompiler
// Type: ScriptableCurrentStatus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Scriptable Amount/Current Status", fileName = "CurrentStatus")]
public class ScriptableCurrentStatus : ScriptableAmount
{
  [SerializeField]
  private string statusType = "shroom";
  [SerializeField]
  private int offset;
  [SerializeField]
  private float multiplier = 1f;
  [SerializeField]
  private bool roundUp;

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

  private int Mult(int amount)
  {
    return !this.roundUp ? Mathf.FloorToInt((float) amount * this.multiplier) : Mathf.RoundToInt((float) amount * this.multiplier);
  }
}
