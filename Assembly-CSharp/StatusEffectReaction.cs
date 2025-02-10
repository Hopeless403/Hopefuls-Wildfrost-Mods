// Decompiled with JetBrains decompiler
// Type: StatusEffectReaction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections.Generic;

public class StatusEffectReaction : StatusEffectData
{
  protected override bool CanTrigger() => base.CanTrigger() && this.target.alive;

  protected bool PlayedInThisRow(Entity entity, Entity[] targets)
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
