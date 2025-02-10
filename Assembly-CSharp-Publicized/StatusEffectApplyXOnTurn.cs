// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXOnTurn
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Specific/Apply X On Turn", fileName = "Apply X On Turn")]
public class StatusEffectApplyXOnTurn : StatusEffectApplyX
{
  [SerializeField]
  public bool trueOnTurn;
  public bool turnTaken;

  public override void Init()
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

  public IEnumerator CheckCardPlay(Entity entity, Entity[] targets) => this.Run(this.GetTargets());

  public override bool RunTurnEvent(Entity entity) => this.trueOnTurn && this.turnTaken && (Object) entity == (Object) this.target && Battle.IsOnBoard(this.target);

  public IEnumerator CheckTurn(Entity entity)
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
