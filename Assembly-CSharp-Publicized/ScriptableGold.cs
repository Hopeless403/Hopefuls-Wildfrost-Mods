// Decompiled with JetBrains decompiler
// Type: ScriptableGold
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable Amount/Gold", fileName = "Gold")]
public class ScriptableGold : ScriptableAmount
{
  [SerializeField]
  public float factor;

  public override int Get(Entity entity) => Mathf.FloorToInt((float) (References.PlayerData.inventory.gold + References.PlayerData.inventory.goldOwed).Value * this.factor);
}
