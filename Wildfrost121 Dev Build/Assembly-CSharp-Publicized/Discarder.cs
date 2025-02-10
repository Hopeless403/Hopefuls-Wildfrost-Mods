// Decompiled with JetBrains decompiler
// Type: Discarder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

#nullable disable
public class Discarder : MonoBehaviour
{
  public void Discard(Entity entity)
  {
    CoroutineManager.Start(Discarder.ClearStatusEffects(entity));
    entity.counter.current = entity.counter.max;
    entity.uses.current = entity.uses.max;
    entity.PromptUpdate();
  }

  public static IEnumerator ClearStatusEffects(Entity entity)
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
