// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXWhenBuilt
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Specific/Apply X When Built", fileName = "Apply X When Built")]
public class StatusEffectApplyXWhenBuilt : StatusEffectApplyX
{
  protected override void Init() => this.OnBuild += new StatusEffectData.EffectEntityEventHandler(this.Build);

  public override bool RunBuildEvent(Entity entity) => (Object) entity == (Object) this.target;

  private IEnumerator Build(Entity entity)
  {
    StatusEffectApplyXWhenBuilt effectApplyXwhenBuilt = this;
    yield return (object) effectApplyXwhenBuilt.Run(effectApplyXwhenBuilt.GetTargets());
    yield return (object) effectApplyXwhenBuilt.Remove();
  }
}
