// Decompiled with JetBrains decompiler
// Type: ScriptableGold
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Scriptable Amount/Gold", fileName = "Gold")]
public class ScriptableGold : ScriptableAmount
{
  [SerializeField]
  public float factor;

  public override int Get(Entity entity)
  {
    return Mathf.FloorToInt((float) (References.PlayerData.inventory.gold + References.PlayerData.inventory.goldOwed).Value * this.factor);
  }
}
