// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantBudge
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Instant/Budge", fileName = "Budge")]
public class StatusEffectInstantBudge : StatusEffectInstant
{
  public override IEnumerator Process()
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
    yield return (object) effectInstantBudge.\u003C\u003En__0();
  }

  [CompilerGenerated]
  [DebuggerHidden]
  public new IEnumerator \u003C\u003En__0() => base.Process();
}
