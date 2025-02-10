// Decompiled with JetBrains decompiler
// Type: SelectScriptRandom
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Random", menuName = "Select Scripts/Random")]
public class SelectScriptRandom : SelectScript<Entity>
{
  [SerializeField]
  private int selectAmount = 1;

  public override List<Entity> Run(List<Entity> group)
  {
    return group.InRandomOrder<Entity>().Take<Entity>(this.selectAmount).ToList<Entity>();
  }
}
