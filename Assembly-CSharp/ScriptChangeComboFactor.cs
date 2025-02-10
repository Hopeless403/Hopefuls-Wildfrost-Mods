// Decompiled with JetBrains decompiler
// Type: ScriptChangeComboFactor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

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
