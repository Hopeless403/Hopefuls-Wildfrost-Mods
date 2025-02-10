// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantIncreaseMaxHealth
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Instant/Increase Max Health", fileName = "Increase Max Health")]
public class StatusEffectInstantIncreaseMaxHealth : StatusEffectInstant
{
  [SerializeField]
  public bool alsoIncreaseCurrentHealth = true;

  public override IEnumerator Process()
  {
    StatusEffectInstantIncreaseMaxHealth increaseMaxHealth = this;
    increaseMaxHealth.target.hp.max += increaseMaxHealth.GetAmount();
    if (increaseMaxHealth.alsoIncreaseCurrentHealth)
      increaseMaxHealth.target.hp.current += increaseMaxHealth.GetAmount();
    increaseMaxHealth.target.PromptUpdate();
    yield return (object) increaseMaxHealth.\u003C\u003En__0();
  }

  [CompilerGenerated]
  [DebuggerHidden]
  public new IEnumerator \u003C\u003En__0() => base.Process();
}
