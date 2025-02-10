// Decompiled with JetBrains decompiler
// Type: Character
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using System;
using UnityEngine;

#nullable disable
public class Character : MonoBehaviour, ISaveable<CharacterSaveData>
{
  public PlayerData data;
  public string title;
  public int team = 1;
  public Entity entity;
  [HorizontalLine(2f, EColor.Gray)]
  public CardContainer drawContainer;
  public CardContainer handContainer;
  public CardContainer discardContainer;
  public CardContainer reserveContainer;
  public bool freeAction;
  public bool endTurn;
  public bool autoTriggerUnits = true;

  public void Assign(PlayerData data) => this.data = data;

  public int GetCompanionCount()
  {
    return this.data.inventory.deck.FindAll((Predicate<CardData>) (a => a.cardType.name == "Friendly")).Count;
  }

  public void GainGold(int amount)
  {
    if (!(bool) (UnityEngine.Object) this.data?.inventory)
      return;
    this.data.inventory.AddGold(amount);
    this.entity.PromptUpdate();
  }

  public void SpendGold(int amount)
  {
    if (!(bool) (UnityEngine.Object) this.data?.inventory)
      return;
    this.data.inventory.gold -= amount;
    this.entity.PromptUpdate();
    Events.InvokeSpendGold(amount);
  }

  [Button("Gain 10 Gold", EButtonEnableMode.Always)]
  public void Gain10Gold() => this.GainGold(10);

  [Button("Gain 100 Gold", EButtonEnableMode.Always)]
  public void Gain100Gold() => this.GainGold(100);

  public CharacterSaveData Save() => new CharacterSaveData(this);

  public override bool Equals(object other)
  {
    return other is Character character && this.team == character.team;
  }
}
