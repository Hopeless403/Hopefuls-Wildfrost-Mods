// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXWhenBuilt
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Specific/Apply X When Built", fileName = "Apply X When Built")]
public class StatusEffectApplyXWhenBuilt : StatusEffectApplyX
{
  public override void Init() => this.OnBuild += new StatusEffectData.EffectEntityEventHandler(this.Build);

  public override bool RunBuildEvent(Entity entity) => (Object) entity == (Object) this.target;

  public IEnumerator Build(Entity entity)
  {
    StatusEffectApplyXWhenBuilt effectApplyXwhenBuilt = this;
    yield return (object) effectApplyXwhenBuilt.Run(effectApplyXwhenBuilt.GetTargets());
    yield return (object) effectApplyXwhenBuilt.Remove();
  }
}
