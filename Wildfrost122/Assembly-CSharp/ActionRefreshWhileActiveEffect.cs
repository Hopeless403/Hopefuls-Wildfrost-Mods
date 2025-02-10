// Decompiled with JetBrains decompiler
// Type: ActionRefreshWhileActiveEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;

#nullable disable
public class ActionRefreshWhileActiveEffect : PlayAction
{
  private readonly StatusEffectWhileActiveX effect;
  private static ulong idCurrent;
  private readonly ulong id;

  public ActionRefreshWhileActiveEffect(StatusEffectWhileActiveX effect)
  {
    this.effect = effect;
    this.id = ActionRefreshWhileActiveEffect.idCurrent++;
  }

  public override IEnumerator Run()
  {
    yield return (object) this.effect.Deactivate();
    if (this.effect.CanActivate())
      yield return (object) this.effect.Activate();
    PlayAction[] actions = ActionQueue.GetActions();
    for (int index = actions.Length - 1; index >= 0; --index)
    {
      PlayAction action = actions[index];
      if (action is ActionRefreshWhileActiveEffect whileActiveEffect && (long) whileActiveEffect.id != (long) this.id && (long) whileActiveEffect.effect.id == (long) this.effect.id)
        ActionQueue.Remove(action);
    }
  }
}
