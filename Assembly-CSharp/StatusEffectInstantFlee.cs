// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantFlee
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Instant/Flee", fileName = "Flee")]
public class StatusEffectInstantFlee : StatusEffectInstant
{
  protected override IEnumerator Process()
  {
    StatusEffectInstantFlee effectInstantFlee = this;
    yield return (object) Sequences.CardRecall(effectInstantFlee.target);
    // ISSUE: reference to a compiler-generated method
    yield return (object) effectInstantFlee.\u003C\u003En__0();
  }
}
