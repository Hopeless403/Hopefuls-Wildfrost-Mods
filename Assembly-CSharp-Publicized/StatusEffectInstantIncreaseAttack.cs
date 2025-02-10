// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantIncreaseAttack
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Instant/Increase Attack", fileName = "Increase Attack")]
public class StatusEffectInstantIncreaseAttack : StatusEffectInstant
{
  [SerializeField]
  public ScriptableAmount scriptableAmount;

  public override IEnumerator Process()
  {
    StatusEffectInstantIncreaseAttack instantIncreaseAttack = this;
    instantIncreaseAttack.target.damage.current += (bool) (Object) instantIncreaseAttack.scriptableAmount ? instantIncreaseAttack.scriptableAmount.Get(instantIncreaseAttack.target) : instantIncreaseAttack.GetAmount();
    instantIncreaseAttack.target.PromptUpdate();
    yield return (object) instantIncreaseAttack.\u003C\u003En__0();
  }

  [CompilerGenerated]
  [DebuggerHidden]
  public new IEnumerator \u003C\u003En__0() => base.Process();
}
