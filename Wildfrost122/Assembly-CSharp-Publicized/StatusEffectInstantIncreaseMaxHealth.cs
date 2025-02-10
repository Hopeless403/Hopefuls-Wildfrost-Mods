// Decompiled with JetBrains decompiler
// Type: StatusEffectInstantIncreaseMaxHealth
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
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
