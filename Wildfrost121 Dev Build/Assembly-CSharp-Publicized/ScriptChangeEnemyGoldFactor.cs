// Decompiled with JetBrains decompiler
// Type: ScriptChangeEnemyGoldFactor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
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
