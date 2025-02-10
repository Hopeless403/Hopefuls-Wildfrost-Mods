// Decompiled with JetBrains decompiler
// Type: HardModeModifierDisplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HardModeModifierDisplay : ModifierDisplay
{
  [SerializeField]
  public GameObject background;
  public GameModifierData[] modifiers;
  public List<string> active;

  public void Populate()
  {
    int num = SaveSystem.LoadProgressData<int>("hardModeModifiersUnlocked", 0);
    this.background.SetActive(num > 0);
    this.active = SaveSystem.LoadProgressData<List<string>>("activeHardModeModifiers");
    if (this.active == null)
      this.active = new List<string>();
    for (int index = 0; index < num && index < this.modifiers.Length; ++index)
    {
      GameModifierData modifier = this.modifiers[index];
      ModifierIcon icon = this.CreateIcon(modifier);
      if (this.active.Contains(modifier.name))
        ModifierSystem.AddModifier(Campaign.Data, modifier);
      else
        icon.GetComponent<ModifierToggle>()?.Toggle();
      icon.GetComponentInChildren<InputAction>()?.action.AddListener((UnityAction) (() => this.Toggle(modifier)));
    }
  }

  public void Toggle(GameModifierData modifier)
  {
    if (this.active.Contains(modifier.name))
    {
      this.active.Remove(modifier.name);
      ModifierSystem.RemoveModifier(Campaign.Data, modifier);
    }
    else
    {
      this.active.Add(modifier.name);
      ModifierSystem.AddModifier(Campaign.Data, modifier);
    }
    SaveSystem.SaveProgressData<List<string>>("activeHardModeModifiers", this.active);
  }
}
