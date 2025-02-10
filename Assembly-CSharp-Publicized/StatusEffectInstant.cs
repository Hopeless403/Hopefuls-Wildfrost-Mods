// Decompiled with JetBrains decompiler
// Type: StatusEffectInstant
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;

public abstract class StatusEffectInstant : StatusEffectData
{
  public override bool Instant => true;

  public override void Init() => this.OnBegin += new StatusEffectData.EffectEventHandler(this.Process);

  public override IEnumerator BeginRoutine()
  {
    StatusEffectInstant statusEffectInstant = this;
    if (statusEffectInstant.count > 0 || !statusEffectInstant.canBeBoosted || statusEffectInstant is StatusEffectInstantMultiple)
      yield return (object) statusEffectInstant.\u003C\u003En__0();
    else
      yield return (object) statusEffectInstant.Remove();
  }

  public virtual IEnumerator Process()
  {
    // ISSUE: reference to a compiler-generated field
    int num = this.\u003C\u003E1__state;
    StatusEffectInstant statusEffectInstant = this;
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
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E2__current = (object) statusEffectInstant.Remove();
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = 1;
    return true;
  }

  public override int GetAmount() => this.count;

  [CompilerGenerated]
  [DebuggerHidden]
  public IEnumerator \u003C\u003En__0() => base.BeginRoutine();
}
