// Decompiled with JetBrains decompiler
// Type: ScriptChangeComboFactor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Change Combo Factor", menuName = "Scripts/Change Combo Factor")]
public class ScriptChangeComboFactor : Script
{
  [SerializeField]
  public float value = 1f;

  public override IEnumerator Run()
  {
    References.PlayerData.comboGoldFactor = this.value;
    yield break;
  }
}
