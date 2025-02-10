// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXEveryTurn
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Specific/Apply X Every Turn", fileName = "Apply X Every Turn")]
public class StatusEffectApplyXEveryTurn : StatusEffectApplyX
{
  [SerializeField]
  public StatusEffectApplyXEveryTurn.Mode mode;

  public override void Init()
  {
    this.OnTurn += new StatusEffectData.EffectEntityEventHandler(this.CheckTurn);
    this.OnTurnStart += new StatusEffectData.EffectEntityEventHandler(this.CheckTurnStart);
  }

  public override bool RunTurnEvent(Entity entity) => this.mode == StatusEffectApplyXEveryTurn.Mode.AfterTurn && this.target.enabled && (Object) entity == (Object) this.target && Battle.IsOnBoard(this.target);

  public IEnumerator CheckTurn(Entity entity) => this.Run(this.GetTargets());

  public override bool RunTurnStartEvent(Entity entity) => this.mode == StatusEffectApplyXEveryTurn.Mode.TurnStart && this.target.enabled && (Object) entity == (Object) this.target && Battle.IsOnBoard(this.target);

  public IEnumerator CheckTurnStart(Entity entity) => this.Run(this.GetTargets());

  public enum Mode
  {
    AfterTurn,
    TurnStart,
  }
}
