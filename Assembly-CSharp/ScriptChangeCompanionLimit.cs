// Decompiled with JetBrains decompiler
// Type: ScriptChangeCompanionLimit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using System.Collections;
using UnityEngine;

[CreateAssetMenu(fileName = "Change Companion Limit", menuName = "Scripts/Change Companion Limit")]
public class ScriptChangeCompanionLimit : Script
{
  [SerializeField]
  private bool set;
  [SerializeField]
  [HideIf("set")]
  private bool add = true;
  [SerializeField]
  private int value = 1;

  public override IEnumerator Run()
  {
    if (this.set)
      References.PlayerData.companionLimit = this.value;
    else if (this.add)
    {
      References.PlayerData.companionLimit += this.value;
      yield break;
    }
  }
}
