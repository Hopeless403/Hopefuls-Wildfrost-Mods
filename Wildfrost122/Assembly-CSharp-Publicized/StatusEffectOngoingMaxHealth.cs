﻿// Decompiled with JetBrains decompiler
// Type: StatusEffectOngoingMaxHealth
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Ongoing/Increase Max Health", fileName = "Ongoing Increase Max Health")]
public class StatusEffectOngoingMaxHealth : StatusEffectOngoing
{
  public override IEnumerator Add(int add)
  {
    // ISSUE: reference to a compiler-generated field
    int num = this.\u003C\u003E1__state;
    StatusEffectOngoingMaxHealth ongoingMaxHealth = this;
    if (num != 0)
    {
      if (num != 1)
        return false;
      // ISSUE: reference to a compiler-generated field
      this.\u003C\u003E1__state = -1;
      return false;
    }
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = -1;
    ongoingMaxHealth.target.hp.max += add;
    ongoingMaxHealth.target.hp.current += add;
    ongoingMaxHealth.target.PromptUpdate();
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E2__current = (object) Sequences.Null();
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = 1;
    return true;
  }

  public override IEnumerator Remove(int remove)
  {
    // ISSUE: reference to a compiler-generated field
    int num = this.\u003C\u003E1__state;
    StatusEffectOngoingMaxHealth ongoingMaxHealth = this;
    if (num != 0)
    {
      if (num != 1)
        return false;
      // ISSUE: reference to a compiler-generated field
      this.\u003C\u003E1__state = -1;
      return false;
    }
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = -1;
    ongoingMaxHealth.target.hp.max -= remove;
    ongoingMaxHealth.target.hp.current -= remove;
    ongoingMaxHealth.target.PromptUpdate();
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E2__current = (object) Sequences.Null();
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = 1;
    return true;
  }
}
