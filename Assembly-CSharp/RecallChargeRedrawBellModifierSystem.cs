// Decompiled with JetBrains decompiler
// Type: RecallChargeRedrawBellModifierSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.Events;

public class RecallChargeRedrawBellModifierSystem : GameSystem
{
  private RedrawBellSystem _redrawBellSystem;

  private RedrawBellSystem redrawBellSystem => this._redrawBellSystem ?? (this._redrawBellSystem = Object.FindObjectOfType<RedrawBellSystem>());

  private void OnEnable() => global::Events.OnDiscard += new UnityAction<Entity>(this.EntityDiscard);

  private void OnDisable() => global::Events.OnDiscard -= new UnityAction<Entity>(this.EntityDiscard);

  private void EntityDiscard(Entity entity)
  {
    if (!(entity.data.cardType.tag == "Friendly"))
      return;
    this.redrawBellSystem.SetCounter(Mathf.Max(0, this.redrawBellSystem.counter.current - 2));
  }
}
