// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXWhenDrawn
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Specific/Apply X When Drawn", fileName = "Apply X When Drawn")]
public class StatusEffectApplyXWhenDrawn : StatusEffectApplyX
{
  public override void Init()
  {
    this.OnEnable += new StatusEffectData.EffectEntityEventHandler(this.CheckEnable);
    this.OnCardMove += new StatusEffectData.EffectEntityEventHandler(this.CheckCardMove);
  }

  public override bool RunEnableEvent(Entity entity)
  {
    return (Object) entity == (Object) this.target && this.target.InHand();
  }

  public IEnumerator CheckEnable(Entity entity) => this.Run(this.GetTargets());

  public override bool RunCardMoveEvent(Entity entity)
  {
    return this.target.enabled && (Object) entity == (Object) this.target && this.target.InHand();
  }

  public IEnumerator CheckCardMove(Entity entity) => this.Run(this.GetTargets());
}
