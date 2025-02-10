// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantBudge
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Instant/Budge", fileName = "Budge")]
public class StatusEffectInstantBudge : StatusEffectInstant
{
  protected override IEnumerator Process()
  {
    StatusEffectInstantBudge effectInstantBudge = this;
    int[] rowIndices = Battle.instance.GetRowIndices(effectInstantBudge.target);
    if (rowIndices.Length == 1)
    {
      int rowIndex1 = rowIndices[0];
      int rowIndex2 = (rowIndex1 + 1) % Battle.instance.rowCount;
      if (rowIndex2 != rowIndex1)
      {
        CardContainer row = Battle.instance.GetRow(effectInstantBudge.target.owner, rowIndex2);
        if (row.Count < row.max)
        {
          Battle.instance.GetRow(effectInstantBudge.target.owner, rowIndex1);
          yield return (object) Sequences.CardMove(effectInstantBudge.target, new CardContainer[1]
          {
            row
          });
        }
      }
    }
    // ISSUE: reference to a compiler-generated method
    yield return (object) effectInstantBudge.\u003C\u003En__0();
  }
}
