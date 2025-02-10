// Decompiled with JetBrains decompiler
// Type: StatusEffectChangeRecycleRequirement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Specific/Change Recycle Requirement", fileName = "Change Recycle Requirement")]
public class StatusEffectChangeRecycleRequirement : StatusEffectData
{
  [SerializeField]
  private bool lower = true;

  protected override void Init() => Events.OnCheckRecycleAmount += new Events.UnityActionRef<Entity, int>(this.CheckRecycleAmount);

  private void OnDestroy() => Events.OnCheckRecycleAmount -= new Events.UnityActionRef<Entity, int>(this.CheckRecycleAmount);

  private void CheckRecycleAmount(ref Entity entity, ref int amount)
  {
    if ((Object) entity != (Object) this.target)
      return;
    int amount1 = this.GetAmount();
    amount = Mathf.Max(0, this.lower ? amount - amount1 : amount + amount1);
  }
}
