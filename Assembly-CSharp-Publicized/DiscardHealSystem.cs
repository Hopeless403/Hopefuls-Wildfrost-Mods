// Decompiled with JetBrains decompiler
// Type: DiscardHealSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Localization;

public class DiscardHealSystem : GameSystem
{
  [SerializeField]
  public int healAmount = 5;
  [SerializeField]
  public LocalizedString healTextKey;
  [SerializeField]
  public Vector3 healPopupOffset = Vector3.up;

  public void OnEnable() => global::Events.OnDiscard += new UnityAction<Entity>(this.Discard);

  public void OnDisable() => global::Events.OnDiscard -= new UnityAction<Entity>(this.Discard);

  public void Discard(Entity entity)
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
