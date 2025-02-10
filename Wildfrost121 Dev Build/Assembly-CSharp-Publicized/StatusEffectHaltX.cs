// Decompiled with JetBrains decompiler
// Type: StatusEffectHaltX
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Specific/Halt X", fileName = "Halt X")]
public class StatusEffectHaltX : StatusEffectData
{
  [SerializeField]
  public StatusEffectData effectToHalt;
  [SerializeField]
  public bool ignoreSilence = true;

  public override void Init()
  {
    Debug.Log((object) string.Format("→ Halting Count Down of [{0}] for [{1}]", (object) this.effectToHalt.name, (object) this.target));
    Events.OnStatusEffectCountDown += new Events.UnityActionCheck<StatusEffectData, int>(this.StatusCountDown);
  }

  public void OnDestroy()
  {
    Debug.Log((object) string.Format("→ Resuming Count Down of [{0}] for [{1}]", (object) this.effectToHalt.name, (object) this.target));
    Events.OnStatusEffectCountDown -= new Events.UnityActionCheck<StatusEffectData, int>(this.StatusCountDown);
  }

  public void StatusCountDown(StatusEffectData status, ref int amount)
  {
    if (!(status.type == this.effectToHalt.type) || !((Object) status.target == (Object) this.target) || this.Silenced())
      return;
    amount = 0;
  }

  public bool Silenced() => this.target.silenced && !this.ignoreSilence;
}
