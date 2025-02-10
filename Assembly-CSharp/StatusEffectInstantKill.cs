// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantKill
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Instant/Kill", fileName = "Kill")]
public class StatusEffectInstantKill : StatusEffectInstant
{
  [SerializeField]
  private TargetConstraint[] killConstraints;
  [SerializeField]
  private string[] statusesToClear = new string[3]
  {
    "block",
    "shell",
    "scrap"
  };

  protected override IEnumerator Process()
  {
    StatusEffectInstantKill effectInstantKill = this;
    Routine.Clump clump = new Routine.Clump();
    foreach (string type in effectInstantKill.statusesToClear)
    {
      StatusEffectData status = effectInstantKill.target.FindStatus(type);
      if ((UnityEngine.Object) status != (UnityEngine.Object) null)
        clump.Add(status.Remove());
    }
    yield return (object) clump.WaitForEnd();
    // ISSUE: reference to a compiler-generated method
    if (effectInstantKill.killConstraints == null || effectInstantKill.killConstraints.Length == 0 || ((IEnumerable<TargetConstraint>) effectInstantKill.killConstraints).Any<TargetConstraint>(new Func<TargetConstraint, bool>(effectInstantKill.\u003CProcess\u003Eb__2_0)))
      effectInstantKill.target.forceKill = true;
    // ISSUE: reference to a compiler-generated method
    yield return (object) effectInstantKill.\u003C\u003En__0();
  }
}
