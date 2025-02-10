// Decompiled with JetBrains decompiler
// Type: StatusEffectHaltX
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Specific/Halt X", fileName = "Halt X")]
public class StatusEffectHaltX : StatusEffectData
{
  [SerializeField]
  private StatusEffectData effectToHalt;

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
    if (!(status.type == this.effectToHalt.type) || !((Object) status.target == (Object) this.target))
      return;
    amount = 0;
  }
}
