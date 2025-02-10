// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectApplyRandomOnCardPlayed
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectApplyRandomOnCardPlayed : StatusEffectApplyXOnCardPlayed
  {
    public StatusEffectData[] effectsToapply = new StatusEffectData[0];

    public override void Init()
    {
      base.Init();
      global::Events.OnActionQueued += new UnityAction<PlayAction>(this.DetermineEffect);
    }

    public void OnDestory()
    {
      global::Events.OnActionQueued -= new UnityAction<PlayAction>(this.DetermineEffect);
    }

    private void DetermineEffect(PlayAction arg)
    {
      this.effectToApply = this.effectsToapply[Random.Range(0, this.effectsToapply.Length)];
    }
  }
}
