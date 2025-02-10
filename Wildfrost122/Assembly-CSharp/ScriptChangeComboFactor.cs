// Decompiled with JetBrains decompiler
// Type: ScriptChangeComboFactor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Change Combo Factor", menuName = "Scripts/Change Combo Factor")]
public class ScriptChangeComboFactor : Script
{
  [SerializeField]
  private float value = 1f;

  public override IEnumerator Run()
  {
    References.PlayerData.comboGoldFactor = this.value;
    yield break;
  }
}
