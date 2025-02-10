// Decompiled with JetBrains decompiler
// Type: StatusEffectOngoingAttack
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Ongoing/Increase Attack", fileName = "Ongoing Increase Attack")]
public class StatusEffectOngoingAttack : StatusEffectOngoing
{
  public override IEnumerator Add(int add)
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

  public override IEnumerator Remove(int remove)
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
