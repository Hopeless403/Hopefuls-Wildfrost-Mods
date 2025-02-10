// Decompiled with JetBrains decompiler
// Type: StatusEffectReaction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections.Generic;

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
