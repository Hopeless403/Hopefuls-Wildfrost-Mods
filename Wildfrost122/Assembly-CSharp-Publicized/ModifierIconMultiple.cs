// Decompiled with JetBrains decompiler
// Type: ModifierIconMultiple
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections.Generic;
using TMPro;
using UnityEngine;

#nullable disable
public class ModifierIconMultiple : ModifierIcon
{
  [SerializeField]
  public TMP_Text stormLevelText;
  [SerializeField]
  public Transform juiceLevel;
  [SerializeField]
  public Vector2 juiceLevelRange = new Vector2(-0.9f, 0.0f);
  public readonly List<GameModifierData> modifiers = new List<GameModifierData>();
  public int _stormLevel;

  public int stormLevel
  {
    get => this._stormLevel;
    set
    {
      this._stormLevel = value;
      if ((bool) (Object) this.stormLevelText)
        this.stormLevelText.text = this._stormLevel.ToString();
      if (!(bool) (Object) this.juiceLevel)
        return;
      this.juiceLevel.transform.localPosition = this.juiceLevel.transform.localPosition.WithY(Mathf.Lerp(this.juiceLevelRange.x, this.juiceLevelRange.y, Mathf.Clamp((float) this._stormLevel / 10f, 0.0f, 1f)));
    }
  }

  public override void Set(GameModifierData modifier, Vector2 popUpOffset)
  {
    base.Set(modifier, popUpOffset);
    this.modifiers.Add(modifier);
    if ((bool) (Object) modifier.linkedStormBell)
      this.stormLevel = modifier.linkedStormBell.stormPoints;
    else
      this.stormLevel = 0;
  }

  public void Add(GameModifierData modifier)
  {
    this.modifiers.Add(modifier);
    if (!(bool) (Object) modifier.linkedStormBell)
      return;
    this.stormLevel += modifier.linkedStormBell.stormPoints;
  }

  public void Clear()
  {
    this.stormLevel = 0;
    this.modifiers.Clear();
  }

  public override void Pop()
  {
    if (this.poppedUp)
      return;
    CardPopUp.AssignTo(this.rectTransform, this.popUpOffset.x, this.popUpOffset.y);
    foreach (GameModifierData modifier in this.modifiers)
      CardPopUp.AddPanel(modifier.name, modifier.titleKey.GetLocalizedString(), modifier.descriptionKey.GetLocalizedString());
    this.poppedUp = true;
  }

  public override void UnPop()
  {
    if (!this.poppedUp)
      return;
    foreach (Object modifier in this.modifiers)
      CardPopUp.RemovePanel(modifier.name);
    this.poppedUp = false;
  }
}
