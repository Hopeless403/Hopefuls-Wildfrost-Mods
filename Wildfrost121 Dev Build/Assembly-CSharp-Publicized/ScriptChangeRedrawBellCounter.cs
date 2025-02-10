// Decompiled with JetBrains decompiler
// Type: ScriptChangeRedrawBellCounter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Change Redraw Bell Counter", menuName = "Scripts/Change Redraw Bell Counter")]
public class ScriptChangeRedrawBellCounter : Script
{
  [SerializeField]
  public bool set;
  [SerializeField]
  [HideIf("set")]
  public bool add = true;
  [SerializeField]
  public int value = 1;

  public override IEnumerator Run()
  {
    if (this.set)
      References.PlayerData.redrawBell = this.value;
    else if (this.add)
    {
      References.PlayerData.redrawBell += this.value;
      yield break;
    }
  }
}
