// Decompiled with JetBrains decompiler
// Type: CharacterDisplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using System;
using System.Collections;
using UnityEngine;

public class CharacterDisplay : EntityDisplay
{
  [SerializeField]
  public int team = 1;
  public GoldDisplay goldDisplay;
  [Space]
  public DeckDisplay deckDisplay;
  public HandOverlay handOverlay;
  public int currentEffectBonus;
  public float currentEffectFactor;
  public Character _character;

  public bool IsDeckpackOpen => Deckpack.IsOpen || this.deckDisplay.companionLimitSequence.gameObject.activeSelf;

  public Character character
  {
    get
    {
      if (!(bool) (UnityEngine.Object) this._character)
        this._character = this.entity.GetComponent<Character>();
      return this._character;
    }
  }

  public static void FindAndAssign(Character character)
  {
    foreach (CharacterDisplay characterDisplay in UnityEngine.Object.FindObjectsOfType<CharacterDisplay>())
    {
      if (!(bool) (UnityEngine.Object) characterDisplay.entity && characterDisplay.team == character.team)
      {
        characterDisplay.Assign(character);
        return;
      }
    }
    throw new Exception("Could not find CharacterDisplay for Character [" + character.name + "]");
  }

  public void Assign(Character character)
  {
    Debug.Log((object) string.Format("[{0}] assigned to {1}", (object) character.name, (object) this));
    this.entity = character.entity;
    this.deckDisplay?.SetOwner(character);
    this.handOverlay?.SetOwner(character);
    character.entity.display = (EntityDisplay) this;
    character.entity.PromptUpdate();
  }

  public void UnAssign() => this.entity = (Entity) null;

  public override IEnumerator UpdateDisplay(bool doPingIcons = true)
  {
    CharacterDisplay characterDisplay = this;
    characterDisplay.ClearStatusIcons();
    if ((bool) (UnityEngine.Object) characterDisplay.goldDisplay && (bool) (UnityEngine.Object) characterDisplay.character)
      characterDisplay.goldDisplay.Set(characterDisplay.character.data.inventory.gold.Value);
    if (characterDisplay.entity.effectBonus != characterDisplay.currentEffectBonus || (double) characterDisplay.entity.effectFactor != (double) characterDisplay.currentEffectFactor)
    {
      characterDisplay.currentEffectBonus = characterDisplay.entity.effectBonus;
      characterDisplay.currentEffectFactor = characterDisplay.entity.effectFactor;
      yield return (object) StatusEffectSystem.EffectBonusChangedEvent(characterDisplay.entity);
    }
  }

  public void ToggleInventory()
  {
    if (Deckpack.IsOpen)
    {
      Deckpack.Close();
      this.deckDisplay.displaySequence.End();
    }
    else
    {
      Deckpack.Open();
      this.deckDisplay.displaySequence.Begin();
    }
  }

  public void OpenInventory()
  {
    if (Deckpack.IsOpen)
      return;
    this.ToggleInventory();
  }

  public void CloseInventory()
  {
    if (!Deckpack.IsOpen)
      return;
    this.ToggleInventory();
  }

  [Button(null, EButtonEnableMode.Always)]
  public void ForceUpdateDisplay() => this.StartCoroutine(this.UpdateDisplay(true));
}
