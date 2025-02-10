// Decompiled with JetBrains decompiler
// Type: StatusEffectBuild
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Traits/Build", fileName = "Build")]
public class StatusEffectBuild : StatusEffectData
{
  [SerializeField]
  public int requires = 3;

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

  [CompilerGenerated]
  public bool \u003CRunCardMoveEvent\u003Eb__1_0(Entity ally) => ally.statusEffects.Exists((Predicate<StatusEffectData>) (a => a.name == this.name));

  [CompilerGenerated]
  public bool \u003CRunCardMoveEvent\u003Eb__1_1(StatusEffectData a) => a.name == this.name;
}
