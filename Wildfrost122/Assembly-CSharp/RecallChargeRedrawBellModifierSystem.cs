// Decompiled with JetBrains decompiler
// Type: RecallChargeRedrawBellModifierSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class RecallChargeRedrawBellModifierSystem : GameSystem
{
  private RedrawBellSystem _redrawBellSystem;

  private RedrawBellSystem redrawBellSystem
  {
    get
    {
      return this._redrawBellSystem ?? (this._redrawBellSystem = Object.FindObjectOfType<RedrawBellSystem>());
    }
  }

  private void OnEnable() => global::Events.OnDiscard += new UnityAction<Entity>(this.EntityDiscard);

  private void OnDisable() => global::Events.OnDiscard -= new UnityAction<Entity>(this.EntityDiscard);

  private void EntityDiscard(Entity entity)
  {
    if (!(entity.data.cardType.tag == "Friendly"))
      return;
    this.redrawBellSystem.SetCounter(Mathf.Max(0, this.redrawBellSystem.counter.current - 2));
  }
}
