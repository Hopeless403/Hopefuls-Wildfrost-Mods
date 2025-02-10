// Decompiled with JetBrains decompiler
// Type: CardSelector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

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
