// Decompiled with JetBrains decompiler
// Type: ScriptChangeEnemyGoldFactor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Change Enemy Gold Factor", menuName = "Scripts/Change Enemy Gold Factor")]
public class ScriptChangeEnemyGoldFactor : Script
{
  [SerializeField]
  public float value = 1f;

  public override IEnumerator Run()
  {
    References.PlayerData.enemyGoldFactor = this.value;
    yield break;
  }
}
