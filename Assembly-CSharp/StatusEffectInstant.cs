// Decompiled with JetBrains decompiler
// Type: StatusEffectInstant
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;

public abstract class StatusEffectInstant : StatusEffectData
{
  public override bool Instant => true;

  protected override void Init() => this.OnBegin += new StatusEffectData.EffectEventHandler(this.Process);

  public override IEnumerator BeginRoutine()
  {
    StatusEffectInstant statusEffectInstant = this;
    if (statusEffectInstant.count > 0 || !statusEffectInstant.canBeBoosted || statusEffectInstant is StatusEffectInstantMultiple)
    {
      // ISSUE: reference to a compiler-generated method
      yield return (object) statusEffectInstant.\u003C\u003En__0();
    }
    else
      yield return (object) statusEffectInstant.Remove();
  }

  protected virtual IEnumerator Process()
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

  protected override int GetAmount() => this.count;
}
