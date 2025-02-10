// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXEveryTurn
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Specific/Apply X Every Turn", fileName = "Apply X Every Turn")]
public class StatusEffectApplyXEveryTurn : StatusEffectApplyX
{
  [SerializeField]
  private StatusEffectApplyXEveryTurn.Mode mode;

  protected override void Init()
  {
    this.OnTurn += new StatusEffectData.EffectEntityEventHandler(this.CheckTurn);
    this.OnTurnStart += new StatusEffectData.EffectEntityEventHandler(this.CheckTurnStart);
  }

  public override bool RunTurnEvent(Entity entity) => this.mode == StatusEffectApplyXEveryTurn.Mode.AfterTurn && this.target.enabled && (Object) entity == (Object) this.target && Battle.IsOnBoard(this.target);

  private IEnumerator CheckTurn(Entity entity) => this.Run(this.GetTargets());

  public override bool RunTurnStartEvent(Entity entity) => this.mode == StatusEffectApplyXEveryTurn.Mode.TurnStart && this.target.enabled && (Object) entity == (Object) this.target && Battle.IsOnBoard(this.target);

  private IEnumerator CheckTurnStart(Entity entity) => this.Run(this.GetTargets());

  private enum Mode
  {
    AfterTurn,
    TurnStart,
  }
}
