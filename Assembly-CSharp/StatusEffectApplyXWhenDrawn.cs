// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXWhenDrawn
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Specific/Apply X When Drawn", fileName = "Apply X When Drawn")]
public class StatusEffectApplyXWhenDrawn : StatusEffectApplyX
{
  protected override void Init()
  {
    this.OnEnable += new StatusEffectData.EffectEntityEventHandler(this.CheckEnable);
    this.OnCardMove += new StatusEffectData.EffectEntityEventHandler(this.CheckCardMove);
  }

  public override bool RunEnableEvent(Entity entity) => (Object) entity == (Object) this.target && this.target.InHand();

  private IEnumerator CheckEnable(Entity entity) => this.Run(this.GetTargets());

  public override bool RunCardMoveEvent(Entity entity) => this.target.enabled && (Object) entity == (Object) this.target && this.target.InHand();

  private IEnumerator CheckCardMove(Entity entity) => this.Run(this.GetTargets());
}
