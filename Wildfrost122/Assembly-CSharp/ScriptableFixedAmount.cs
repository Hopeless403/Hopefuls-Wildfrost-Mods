// Decompiled with JetBrains decompiler
// Type: ScriptableFixedAmount
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Scriptable Amount/Fixed Amount", fileName = "One")]
public class ScriptableFixedAmount : ScriptableAmount
{
  [SerializeField]
  private int amount = 1;

  public override int Get(Entity entity) => this.amount;
}
