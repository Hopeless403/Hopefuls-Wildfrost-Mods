// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantPush
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Instant/Push", fileName = "Push")]
public class StatusEffectInstantPush : StatusEffectInstant
{
  protected override IEnumerator Process()
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
    // ISSUE: reference to a compiler-generated method
    yield return (object) effectInstantPush.\u003C\u003En__0();
  }
}
