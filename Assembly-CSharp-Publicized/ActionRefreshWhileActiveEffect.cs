// Decompiled with JetBrains decompiler
// Type: ActionRefreshWhileActiveEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;

public class ActionRefreshWhileActiveEffect : PlayAction
{
  public readonly StatusEffectWhileActiveX effect;
  public static ulong idCurrent;
  public readonly ulong id;

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
