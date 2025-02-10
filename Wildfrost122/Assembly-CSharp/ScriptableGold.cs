// Decompiled with JetBrains decompiler
// Type: ScriptableGold
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Scriptable Amount/Gold", fileName = "Gold")]
public class ScriptableGold : ScriptableAmount
{
  [SerializeField]
  private float factor;

  public override int Get(Entity entity)
  {
    return Mathf.FloorToInt((float) (References.PlayerData.inventory.gold + References.PlayerData.inventory.goldOwed).Value * this.factor);
  }
}
