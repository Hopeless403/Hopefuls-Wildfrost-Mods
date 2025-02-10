// Decompiled with JetBrains decompiler
// Type: RecallChargeRedrawBellModifierSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.Events;

public class RecallChargeRedrawBellModifierSystem : GameSystem
{
  public RedrawBellSystem _redrawBellSystem;

  public RedrawBellSystem redrawBellSystem => this._redrawBellSystem ?? (this._redrawBellSystem = Object.FindObjectOfType<RedrawBellSystem>());

  public void OnEnable() => global::Events.OnDiscard += new UnityAction<Entity>(this.EntityDiscard);

  public void OnDisable() => global::Events.OnDiscard -= new UnityAction<Entity>(this.EntityDiscard);

  public void EntityDiscard(Entity entity)
  {
    if (!(entity.data.cardType.tag == "Friendly"))
      return;
    this.redrawBellSystem.SetCounter(Mathf.Max(0, this.redrawBellSystem.counter.current - 2));
  }
}
