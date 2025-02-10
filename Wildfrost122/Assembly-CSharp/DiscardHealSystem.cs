// Decompiled with JetBrains decompiler
// Type: DiscardHealSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Localization;

#nullable disable
public class DiscardHealSystem : GameSystem
{
  [SerializeField]
  private int healAmount = 5;
  [SerializeField]
  private LocalizedString healTextKey;
  [SerializeField]
  private Vector3 healPopupOffset = Vector3.up;

  private void OnEnable() => global::Events.OnDiscard += new UnityAction<Entity>(this.Discard);

  private void OnDisable() => global::Events.OnDiscard -= new UnityAction<Entity>(this.Discard);

  private void Discard(Entity entity)
  {
    ActionDiscardEffect action = new ActionDiscardEffect(entity, this.healAmount);
    if (!global::Events.CheckAction((PlayAction) action))
      return;
    ActionQueue.Add((PlayAction) action);
    if (!entity.data.hasHealth)
      return;
    Vector3 position = entity.transform.position + this.healPopupOffset;
    string text = "<size=0.5>" + string.Format(this.healTextKey.GetLocalizedString(), (object) this.healAmount);
    FloatingText.Create(position).SetText(text).SetSortingLayer("PopUp", 10).Animate("Spring").Fade("Smooth");
  }
}
