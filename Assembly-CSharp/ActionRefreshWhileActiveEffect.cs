// Decompiled with JetBrains decompiler
// Type: ActionRefreshWhileActiveEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;

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
