// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXWhenBuilt
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Specific/Apply X When Built", fileName = "Apply X When Built")]
public class StatusEffectApplyXWhenBuilt : StatusEffectApplyX
{
  protected override void Init()
  {
    this.OnBuild += new StatusEffectData.EffectEntityEventHandler(this.Build);
  }

  public override bool RunBuildEvent(Entity entity) => (Object) entity == (Object) this.target;

  private IEnumerator Build(Entity entity)
  {
    StatusEffectApplyXWhenBuilt effectApplyXwhenBuilt = this;
    yield return (object) effectApplyXwhenBuilt.Run(effectApplyXwhenBuilt.GetTargets());
    yield return (object) effectApplyXwhenBuilt.Remove();
  }
}
