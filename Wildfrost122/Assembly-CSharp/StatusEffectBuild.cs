// Decompiled with JetBrains decompiler
// Type: StatusEffectBuild
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Traits/Build", fileName = "Build")]
public class StatusEffectBuild : StatusEffectData
{
  [SerializeField]
  private int requires = 3;

  public override bool RunCardMoveEvent(Entity entity)
  {
    if ((UnityEngine.Object) this.target == (UnityEngine.Object) entity && Battle.IsOnBoard(entity.containers) && !Battle.IsOnBoard(entity.preContainers))
    {
      List<Entity> list = entity.GetAllies().Where<Entity>((Func<Entity, bool>) (ally => ally.statusEffects.Exists((Predicate<StatusEffectData>) (a => a.name == this.name)))).ToList<Entity>();
      list.Add(entity);
      if (list.Count >= this.requires)
        ActionQueue.Stack((PlayAction) new ActionCombine(list.ToArray()), true);
    }
    return false;
  }
}
