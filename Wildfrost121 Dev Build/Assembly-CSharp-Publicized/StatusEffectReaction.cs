// Decompiled with JetBrains decompiler
// Type: StatusEffectReaction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections.Generic;

#nullable disable
public class StatusEffectReaction : StatusEffectData
{
  public override bool CanTrigger() => base.CanTrigger() && this.target.alive;

  public bool PlayedInThisRow(Entity entity, Entity[] targets)
  {
    bool flag = false;
    int[] rowIndices1 = Battle.instance.GetRowIndices(this.target);
    foreach (Entity target in targets)
    {
      int[] rowIndices2 = Battle.instance.GetRowIndices(target);
      if (((IList<int>) rowIndices1).ContainsAny<int>((IEnumerable<int>) rowIndices2))
      {
        flag = true;
        break;
      }
    }
    return flag;
  }
}
