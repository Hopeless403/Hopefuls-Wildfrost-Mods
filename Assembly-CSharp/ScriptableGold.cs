// Decompiled with JetBrains decompiler
// Type: ScriptableGold
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable Amount/Gold", fileName = "Gold")]
public class ScriptableGold : ScriptableAmount
{
  [SerializeField]
  private float factor;

  public override int Get(Entity entity) => Mathf.FloorToInt((float) (References.PlayerData.inventory.gold + References.PlayerData.inventory.goldOwed).Value * this.factor);
}
