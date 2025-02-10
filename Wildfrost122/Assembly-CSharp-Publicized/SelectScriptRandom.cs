// Decompiled with JetBrains decompiler
// Type: SelectScriptRandom
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Random", menuName = "Select Scripts/Random")]
public class SelectScriptRandom : SelectScript<Entity>
{
  [SerializeField]
  public int selectAmount = 1;

  public override List<Entity> Run(List<Entity> group)
  {
    return group.InRandomOrder<Entity>().Take<Entity>(this.selectAmount).ToList<Entity>();
  }
}
