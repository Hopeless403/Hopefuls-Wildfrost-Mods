// Decompiled with JetBrains decompiler
// Type: CardScriptDestroyCard
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Destroy Card", menuName = "Card Scripts/Destroy Card")]
public class CardScriptDestroyCard : CardScript
{
  public override void Run(CardData target)
  {
    CardScriptDestroyCard.RemoveFromDeck(target);
    CardScriptDestroyCard.DestroyEntities(target);
  }

  public static void RemoveFromDeck(CardData target)
  {
    if (References.PlayerData.inventory.deck.RemoveWhere<CardData>((Predicate<CardData>) (a => (long) target.id == (long) a.id)))
    {
      Debug.Log((object) ("[" + target.name + "] Removed From Player's deck"));
    }
    else
    {
      if (!References.PlayerData.inventory.reserve.RemoveWhere<CardData>((Predicate<CardData>) (a => (long) target.id == (long) a.id)))
        return;
      Debug.Log((object) ("[" + target.name + "] Removed From Player's reserve"));
    }
  }

  public static void DestroyEntities(CardData target)
  {
    foreach (Entity entity in UnityEngine.Object.FindObjectsOfType<Entity>())
    {
      if ((UnityEngine.Object) entity.data == (UnityEngine.Object) target)
      {
        entity.gameObject.AddComponent<CardDestroyedConsume>().sortingLayer = "ParticlesFront";
        entity.RemoveFromContainers();
        entity.display.GetCanvas().sortingLayerName = "Inspect";
      }
    }
    UnityEngine.Object.FindObjectOfType<DeckDisplaySequence>()?.UpdatePositions();
  }
}
