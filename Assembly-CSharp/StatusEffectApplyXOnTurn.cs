// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXOnTurn
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Specific/Apply X On Turn", fileName = "Apply X On Turn")]
public class StatusEffectApplyXOnTurn : StatusEffectApplyX
{
  [SerializeField]
  private bool trueOnTurn;
  private bool turnTaken;

  protected override void Init()
  {
    this.OnCardPlayed += new StatusEffectData.EffectCardPlayEventHandler(this.CheckCardPlay);
    this.OnTurn += new StatusEffectData.EffectEntityEventHandler(this.CheckTurn);
  }

  public override bool RunCardPlayedEvent(Entity entity, Entity[] targets)
  {
    if (this.turnTaken || !this.target.enabled || !((Object) entity == (Object) this.target) || !Battle.IsOnBoard(this.target))
      return false;
    if (!this.trueOnTurn)
      return true;
    this.turnTaken = true;
    return false;
  }

  private IEnumerator CheckCardPlay(Entity entity, Entity[] targets) => this.Run(this.GetTargets());

  public override bool RunTurnEvent(Entity entity) => this.trueOnTurn && this.turnTaken && (Object) entity == (Object) this.target && Battle.IsOnBoard(this.target);

  private IEnumerator CheckTurn(Entity entity)
  {
    // ISSUE: reference to a compiler-generated field
    int num = this.\u003C\u003E1__state;
    StatusEffectApplyXOnTurn effectApplyXonTurn = this;
    if (num != 0)
    {
      if (num != 1)
        return false;
      // ISSUE: reference to a compiler-generated field
      this.\u003C\u003E1__state = -1;
      effectApplyXonTurn.turnTaken = false;
      return false;
    }
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = -1;
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E2__current = (object) effectApplyXonTurn.Run(effectApplyXonTurn.GetTargets());
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = 1;
    return true;
  }
}
