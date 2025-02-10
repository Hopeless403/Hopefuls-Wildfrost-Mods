// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXOnCardPlayed
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Specific/Apply X On Card Played", fileName = "Apply X On Card Played")]
public class StatusEffectApplyXOnCardPlayed : StatusEffectApplyX
{
  public override void Init()
  {
    this.OnCardPlayed += new StatusEffectData.EffectCardPlayEventHandler(this.Check);
  }

  public static CardContainer[] GetWasInRows(Entity entity, IEnumerable<Entity> targets)
  {
    if (entity.data.playType != Card.PlayType.Play || !entity.NeedsTarget)
      return entity.containers;
    HashSet<CardContainer> list = new HashSet<CardContainer>();
    foreach (Entity target in targets)
    {
      if (target.containers != null && target.containers.Length != 0)
        list.AddRange<CardContainer>((IEnumerable<CardContainer>) target.containers);
      else
        list.AddRange<CardContainer>((IEnumerable<CardContainer>) target.preContainers);
    }
    return list.ToArray<CardContainer>();
  }

  public override bool RunCardPlayedEvent(Entity entity, Entity[] targets)
  {
    return this.target.enabled && (Object) entity == (Object) this.target;
  }

  public IEnumerator Check(Entity entity, Entity[] targets)
  {
    return this.Run(this.GetTargets(wasInRows: StatusEffectApplyXOnCardPlayed.GetWasInRows(entity, (IEnumerable<Entity>) targets), targets: targets));
  }
}
