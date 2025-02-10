// Decompiled with JetBrains decompiler
// Type: StatusEffectOngoingEffects
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Ongoing/Increase Effects", fileName = "Ongoing Increase Effects")]
public class StatusEffectOngoingEffects : StatusEffectOngoing
{
  [SerializeField]
  public bool add = true;
  [SerializeField]
  [HideIf("add")]
  public bool multiply;

  public override IEnumerator Add(int add)
  {
    StatusEffectOngoingEffects effectOngoingEffects = this;
    if (effectOngoingEffects.add)
      effectOngoingEffects.target.effectBonus += add;
    else if (effectOngoingEffects.multiply)
      effectOngoingEffects.target.effectFactor += (float) add;
    effectOngoingEffects.target.PromptUpdate();
    yield return (object) Sequences.Null();
  }

  public override IEnumerator Remove(int remove)
  {
    StatusEffectOngoingEffects effectOngoingEffects = this;
    if (effectOngoingEffects.add)
      effectOngoingEffects.target.effectBonus -= remove;
    else if (effectOngoingEffects.multiply)
      effectOngoingEffects.target.effectFactor -= (float) remove;
    effectOngoingEffects.target.PromptUpdate();
    yield return (object) Sequences.Null();
  }
}
