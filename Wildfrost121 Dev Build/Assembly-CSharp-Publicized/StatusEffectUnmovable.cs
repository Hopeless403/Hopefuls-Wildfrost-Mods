// Decompiled with JetBrains decompiler
// Type: StatusEffectUnmovable
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Traits/Unmovable", fileName = "Unmovable")]
public class StatusEffectUnmovable : StatusEffectData
{
  public override void Init()
  {
    Events.OnCheckAction += new Events.UnityActionRef<PlayAction, bool>(this.CheckAction);
  }

  public void OnDestroy()
  {
    Events.OnCheckAction -= new Events.UnityActionRef<PlayAction, bool>(this.CheckAction);
  }

  public void CheckAction(ref PlayAction action, ref bool allow)
  {
    if (!allow || this.target.silenced || !(action is ActionMove actionMove) || !((Object) actionMove.entity == (Object) this.target) || !Battle.IsOnBoard(this.target) || !Battle.IsOnBoard(actionMove.toContainers))
      return;
    allow = false;
    if (!NoTargetTextSystem.Exists())
      return;
    Routine routine = new Routine(NoTargetTextSystem.Run(this.target, NoTargetType.CantMove));
  }
}
