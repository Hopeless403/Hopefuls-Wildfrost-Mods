// Decompiled with JetBrains decompiler
// Type: SelectScriptEntityLowestAttack
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Entity With Lowest Attack", menuName = "Select Scripts/Entity With Lowest Attack")]
public class SelectScriptEntityLowestAttack : SelectScript<Entity>
{
  [SerializeField]
  public int selectAmount = 1;

  public override List<Entity> Run(List<Entity> group)
  {
    Entity entity = group.Where<Entity>((Func<Entity, bool>) (a => a.IsAliveAndExists() && a.HasAttackIcon())).OrderBy<Entity, int>(new Func<Entity, int>(SelectScriptEntityLowestAttack.GetAttack)).FirstOrDefault<Entity>();
    int lowestAttack = (bool) (UnityEngine.Object) entity ? SelectScriptEntityLowestAttack.GetAttack(entity) : 0;
    return group.Where<Entity>((Func<Entity, bool>) (a => a.IsAliveAndExists() && a.HasAttackIcon() && SelectScriptEntityLowestAttack.GetAttack(a) == lowestAttack)).InRandomOrder<Entity>().Take<Entity>(this.selectAmount).ToList<Entity>();
  }

  public static int GetAttack(Entity entity) => entity.damage.current + entity.tempDamage.Value;
}
