// Decompiled with JetBrains decompiler
// Type: StatusEffectHaltX
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Specific/Halt X", fileName = "Halt X")]
public class StatusEffectHaltX : StatusEffectData
{
  [SerializeField]
  public StatusEffectData effectToHalt;

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
    if (!(status.type == this.effectToHalt.type) || !((Object) status.target == (Object) this.target))
      return;
    amount = 0;
  }
}
