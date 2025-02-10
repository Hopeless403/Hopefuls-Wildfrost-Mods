// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantRandomizeStats
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Instant/Randomize Stats", fileName = "Randomize Stats")]
public class StatusEffectInstantRandomizeStats : StatusEffectInstant
{
  [SerializeField]
  public int min = 2;
  [SerializeField]
  public int max = 5;

  public override IEnumerator Process()
  {
    // ISSUE: reference to a compiler-generated field
    int num = this.\u003C\u003E1__state;
    StatusEffectInstantRandomizeStats instantRandomizeStats = this;
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
    instantRandomizeStats.target.hp.max = Dead.Random.Range(instantRandomizeStats.min, instantRandomizeStats.max);
    instantRandomizeStats.target.damage.max = Dead.Random.Range(instantRandomizeStats.min, instantRandomizeStats.max);
    instantRandomizeStats.target.counter.max = Dead.Random.Range(instantRandomizeStats.min, instantRandomizeStats.max);
    instantRandomizeStats.target.hp.current = instantRandomizeStats.target.hp.max;
    instantRandomizeStats.target.damage.current = instantRandomizeStats.target.damage.max;
    instantRandomizeStats.target.counter.current = instantRandomizeStats.target.counter.max;
    instantRandomizeStats.target.ResetWhenHealthLostEffects();
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E2__current = (object) instantRandomizeStats.\u003C\u003En__0();
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = 1;
    return true;
  }

  [CompilerGenerated]
  [DebuggerHidden]
  public new IEnumerator \u003C\u003En__0() => base.Process();
}
