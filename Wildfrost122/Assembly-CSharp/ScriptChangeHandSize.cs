// Decompiled with JetBrains decompiler
// Type: ScriptChangeHandSize
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Change Hand Size", menuName = "Scripts/Change Hand Size")]
public class ScriptChangeHandSize : Script
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
      References.PlayerData.handSize = this.value;
    else if (this.add)
    {
      References.PlayerData.handSize += this.value;
      yield break;
    }
  }
}
