// Decompiled with JetBrains decompiler
// Type: Discarder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

public class Discarder : MonoBehaviour
{
  public void Discard(Entity entity)
  {
    CoroutineManager.Start(Discarder.ClearStatusEffects(entity));
    entity.counter.current = entity.counter.max;
    entity.uses.current = entity.uses.max;
    entity.PromptUpdate();
  }

  private static IEnumerator ClearStatusEffects(Entity entity)
  {
    Debug.Log((object) string.Format("DISCARDER → Clearing Status Effects [{0}]", (object) entity));
    for (int i = entity.statusEffects.Count - 1; i >= 0; --i)
    {
      StatusEffectData statusEffect = entity.statusEffects[i];
      if ((bool) (Object) statusEffect && statusEffect.removeOnDiscard)
        yield return (object) statusEffect.Remove();
    }
  }
}
