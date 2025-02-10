// Decompiled with JetBrains decompiler
// Type: ModifierDisplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections.Generic;
using UnityEngine;

#nullable disable
public class ModifierDisplay : MonoBehaviour
{
  [SerializeField]
  protected ModifierIcon iconPrefab;
  [SerializeField]
  private ModifierIconMultiple stormLevelIconPrefab;
  [SerializeField]
  protected Vector2 popUpOffset;
  protected readonly List<ModifierIcon> icons = new List<ModifierIcon>();
  private ModifierIconMultiple stormLevelIcon;

  protected int modifierCount { get; set; }

  public ModifierIcon CreateIcon(GameModifierData data, bool combineStormBells = true)
  {
    if (combineStormBells && (bool) (Object) data.linkedStormBell && (bool) (Object) this.stormLevelIconPrefab)
      return this.AddToStormLevelIcon(data);
    ++this.modifierCount;
    if (!data.visible)
      return (ModifierIcon) null;
    ModifierIcon icon = Object.Instantiate<ModifierIcon>(this.iconPrefab, this.transform);
    icon.Set(data, this.popUpOffset);
    this.icons.Add(icon);
    return icon;
  }

  public void ClearIcons()
  {
    for (int index = this.icons.Count - 1; index >= 0; --index)
    {
      ModifierIcon icon = this.icons[index];
      if ((bool) (Object) icon)
        icon.gameObject.Destroy();
    }
    this.modifierCount = 0;
    this.stormLevelIcon = (ModifierIconMultiple) null;
  }

  private ModifierIcon AddToStormLevelIcon(GameModifierData modifier)
  {
    if (!(bool) (Object) this.stormLevelIcon)
    {
      this.CreateStormLevelIcon(modifier);
    }
    else
    {
      ++this.modifierCount;
      this.stormLevelIcon.Add(modifier);
    }
    return (ModifierIcon) this.stormLevelIcon;
  }

  private ModifierIcon CreateStormLevelIcon(GameModifierData firstModifier)
  {
    ++this.modifierCount;
    this.stormLevelIcon = Object.Instantiate<ModifierIconMultiple>(this.stormLevelIconPrefab, this.transform);
    this.stormLevelIcon.Set(firstModifier, this.popUpOffset);
    this.icons.Add((ModifierIcon) this.stormLevelIcon);
    return (ModifierIcon) this.stormLevelIcon;
  }
}
