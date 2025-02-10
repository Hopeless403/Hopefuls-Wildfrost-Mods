// Decompiled with JetBrains decompiler
// Type: ScriptableGold
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
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
