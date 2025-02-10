// Decompiled with JetBrains decompiler
// Type: StatusEffectOngoingAttack
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Ongoing/Increase Attack", fileName = "Ongoing Increase Attack")]
public class StatusEffectOngoingAttack : StatusEffectOngoing
{
  protected override IEnumerator Add(int add)
  {
    // ISSUE: reference to a compiler-generated field
    int num = this.\u003C\u003E1__state;
    StatusEffectOngoingAttack effectOngoingAttack = this;
    if (num != 0)
      return false;
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = -1;
    effectOngoingAttack.target.tempDamage += add;
    effectOngoingAttack.target.PromptUpdate();
    return false;
  }

  protected override IEnumerator Remove(int remove)
  {
    // ISSUE: reference to a compiler-generated field
    int num = this.\u003C\u003E1__state;
    StatusEffectOngoingAttack effectOngoingAttack = this;
    if (num != 0)
      return false;
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = -1;
    effectOngoingAttack.target.tempDamage -= remove;
    effectOngoingAttack.target.PromptUpdate();
    return false;
  }
}
