// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantPull
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Instant/Pull", fileName = "Pull")]
public class StatusEffectInstantPull : StatusEffectInstant
{
  public const int insertPos = 0;

  public override IEnumerator Process()
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
    yield return (object) effectInstantPull.\u003C\u003En__0();
  }

  [CompilerGenerated]
  [DebuggerHidden]
  public new IEnumerator \u003C\u003En__0() => base.Process();
}
