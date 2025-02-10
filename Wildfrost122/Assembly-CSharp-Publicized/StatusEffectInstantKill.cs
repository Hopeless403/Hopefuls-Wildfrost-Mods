// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantKill
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Instant/Kill", fileName = "Kill")]
public class StatusEffectInstantKill : StatusEffectInstant
{
  [SerializeField]
  public TargetConstraint[] killConstraints;
  [SerializeField]
  public string[] statusesToClear = new string[3]
  {
    "block",
    "shell",
    "scrap"
  };

  public override IEnumerator Process()
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
    if (effectInstantKill.killConstraints == null || effectInstantKill.killConstraints.Length == 0 || ((IEnumerable<TargetConstraint>) effectInstantKill.killConstraints).Any<TargetConstraint>(new Func<TargetConstraint, bool>(effectInstantKill.\u003CProcess\u003Eb__2_0)))
      effectInstantKill.target.forceKill = true;
    yield return (object) effectInstantKill.\u003C\u003En__0();
  }

  [CompilerGenerated]
  public bool \u003CProcess\u003Eb__2_0(TargetConstraint a) => a.Check(this.target);

  [CompilerGenerated]
  [DebuggerHidden]
  public new IEnumerator \u003C\u003En__0() => base.Process();
}
