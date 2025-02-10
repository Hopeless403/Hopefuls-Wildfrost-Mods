// Decompiled with JetBrains decompiler
// Type: CardSelector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
public class CardSelector : MonoBehaviour
{
  public Character character;
  public UnityEventEntity selectEvent;

  public void TakeCard(Entity entity)
  {
    if (!(bool) (Object) this.character || !(bool) (Object) entity.data)
      return;
    Debug.Log((object) ("CardSelector → adding [" + entity.data.name + "] to " + this.character.name + "'s deck"));
    this.character.data.inventory.deck.Add(entity.data);
    this.MoveCardToDeck(entity);
    this.selectEvent.Invoke(entity);
  }

  public void TakeFirstCard(CardContainer cardContainer)
  {
    if (cardContainer.Count <= 0)
      return;
    this.TakeCard(cardContainer.GetTop());
  }

  public void MoveCardToDeck(Entity entity)
  {
    Events.InvokeEntityEnterBackpack(entity);
    entity.transform.parent = this.character.entity.display.transform;
    entity.display?.hover?.Disable();
    Routine routine = new Routine(AssetLoader.Lookup<CardAnimation>("CardAnimations", "FlyToBackpack").Routine((object) entity));
  }
}
