// Decompiled with JetBrains decompiler
// Type: SelectScriptEntityHighestAttack
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Entity With Highest Attack", menuName = "Select Scripts/Entity With Highest Attack")]
public class SelectScriptEntityHighestAttack : SelectScript<Entity>
{
  [SerializeField]
  private int selectAmount = 1;

  public override List<Entity> Run(List<Entity> group)
  {
    Entity entity = group.Where<Entity>((Func<Entity, bool>) (a => a.IsAliveAndExists() && a.HasAttackIcon())).OrderByDescending<Entity, int>(new Func<Entity, int>(SelectScriptEntityHighestAttack.GetAttack)).FirstOrDefault<Entity>();
    int highestAttack = (bool) (UnityEngine.Object) entity ? SelectScriptEntityHighestAttack.GetAttack(entity) : 0;
    return group.Where<Entity>((Func<Entity, bool>) (a => a.IsAliveAndExists() && a.HasAttackIcon() && SelectScriptEntityHighestAttack.GetAttack(a) == highestAttack)).InRandomOrder<Entity>().Take<Entity>(this.selectAmount).ToList<Entity>();
  }

  private static int GetAttack(Entity entity) => entity.damage.current + entity.tempDamage.Value;
}
