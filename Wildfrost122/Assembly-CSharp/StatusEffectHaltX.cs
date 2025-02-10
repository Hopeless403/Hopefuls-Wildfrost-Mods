// Decompiled with JetBrains decompiler
// Type: StatusEffectHaltX
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Specific/Halt X", fileName = "Halt X")]
public class StatusEffectHaltX : StatusEffectData
{
  [SerializeField]
  private StatusEffectData effectToHalt;
  [SerializeField]
  private bool ignoreSilence = true;

  protected override void Init()
  {
    Debug.Log((object) string.Format("→ Halting Count Down of [{0}] for [{1}]", (object) this.effectToHalt.name, (object) this.target));
    Events.OnStatusEffectCountDown += new Events.UnityActionCheck<StatusEffectData, int>(this.StatusCountDown);
  }

  private void OnDestroy()
  {
    Debug.Log((object) string.Format("→ Resuming Count Down of [{0}] for [{1}]", (object) this.effectToHalt.name, (object) this.target));
    Events.OnStatusEffectCountDown -= new Events.UnityActionCheck<StatusEffectData, int>(this.StatusCountDown);
  }

  private void StatusCountDown(StatusEffectData status, ref int amount)
  {
    if (!(status.type == this.effectToHalt.type) || !((Object) status.target == (Object) this.target) || this.Silenced())
      return;
    amount = 0;
  }

  private bool Silenced() => this.target.silenced && !this.ignoreSilence;
}
