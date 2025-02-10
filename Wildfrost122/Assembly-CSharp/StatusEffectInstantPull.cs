// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantPull
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Instant/Pull", fileName = "Pull")]
public class StatusEffectInstantPull : StatusEffectInstant
{
  private const int insertPos = 0;

  protected override IEnumerator Process()
  {
    StatusEffectInstantPull effectInstantPull = this;
    int[] rowIndices = Battle.instance.GetRowIndices(effectInstantPull.target);
    if (rowIndices.Length == 1)
    {
      CardContainer row1 = Battle.instance.GetRow(effectInstantPull.target.owner, rowIndices[0]);
      int index = row1.IndexOf(effectInstantPull.target);
      if (index != 0)
      {
        row1.RemoveAt(index);
        bool flag = false;
        if (row1 is CardSlotLane)
        {
          flag = (Object) row1[0] == (Object) null;
          if (!flag)
          {
            flag = row1.PushBackwards(0);
            if (!flag)
              flag = row1.PushForwards(0);
          }
        }
        row1.Insert(flag ? 0 : index, effectInstantPull.target);
        if (flag)
        {
          foreach (CardContainer row2 in References.Battle.GetRows(effectInstantPull.target.owner))
            row2.TweenChildPositions();
        }
      }
    }
    // ISSUE: reference to a compiler-generated method
    yield return (object) effectInstantPull.\u003C\u003En__0();
  }
}
