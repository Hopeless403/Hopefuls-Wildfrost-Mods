// Decompiled with JetBrains decompiler
// Type: StatusEffectUnmovable
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Traits/Unmovable", fileName = "Unmovable")]
public class StatusEffectUnmovable : StatusEffectData
{
  protected override void Init() => Events.OnCheckAction += new Events.UnityActionRef<PlayAction, bool>(this.CheckAction);

  private void OnDestroy() => Events.OnCheckAction -= new Events.UnityActionRef<PlayAction, bool>(this.CheckAction);

  private void CheckAction(ref PlayAction action, ref bool allow)
  {
    if (!allow || this.target.silenced || !(action is ActionMove actionMove) || !((Object) actionMove.entity == (Object) this.target) || !Battle.IsOnBoard(this.target) || !Battle.IsOnBoard(actionMove.toContainers))
      return;
    allow = false;
    if (!NoTargetTextSystem.Exists())
      return;
    Routine routine = new Routine(NoTargetTextSystem.Run(this.target, NoTargetType.CantMove));
  }
}
