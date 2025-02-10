// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantPush
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Instant/Push", fileName = "Push")]
public class StatusEffectInstantPush : StatusEffectInstant
{
  public override IEnumerator Process()
  {
    StatusEffectInstantPush effectInstantPush = this;
    int[] rowIndices = Battle.instance.GetRowIndices(effectInstantPush.target);
    if (rowIndices.Length == 1)
    {
      CardContainer row = Battle.instance.GetRow(effectInstantPush.target.owner, rowIndices[0]);
      int index1 = row.IndexOf(effectInstantPush.target);
      int index2 = Mathf.Min(index1 + effectInstantPush.GetAmount(), row.max - 1);
      if (index1 != index2)
      {
        row.RemoveAt(index1);
        row.Insert(index2, effectInstantPush.target);
        foreach (Entity child in row)
          row.TweenChildPosition(child);
      }
    }
    yield return (object) effectInstantPush.\u003C\u003En__0();
  }

  [CompilerGenerated]
  [DebuggerHidden]
  public new IEnumerator \u003C\u003En__0() => base.Process();
}
