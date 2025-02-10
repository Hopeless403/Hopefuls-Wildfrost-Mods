// Decompiled with JetBrains decompiler
// Type: StatusEffectChangeRecycleRequirement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Specific/Change Recycle Requirement", fileName = "Change Recycle Requirement")]
public class StatusEffectChangeRecycleRequirement : StatusEffectData
{
  [SerializeField]
  public bool lower = true;

  public override void Init()
  {
    Events.OnCheckRecycleAmount += new Events.UnityActionRef<Entity, int>(this.CheckRecycleAmount);
  }

  public void OnDestroy()
  {
    Events.OnCheckRecycleAmount -= new Events.UnityActionRef<Entity, int>(this.CheckRecycleAmount);
  }

  public void CheckRecycleAmount(ref Entity entity, ref int amount)
  {
    if ((Object) entity != (Object) this.target)
      return;
    int amount1 = this.GetAmount();
    amount = Mathf.Max(0, this.lower ? amount - amount1 : amount + amount1);
  }
}
