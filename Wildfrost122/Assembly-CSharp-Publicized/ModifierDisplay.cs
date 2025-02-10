// Decompiled with JetBrains decompiler
// Type: ModifierDisplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

#nullable disable
public class ModifierDisplay : MonoBehaviour
{
  [SerializeField]
  public ModifierIcon iconPrefab;
  [SerializeField]
  public ModifierIconMultiple stormLevelIconPrefab;
  [SerializeField]
  public Vector2 popUpOffset;
  public readonly List<ModifierIcon> icons = new List<ModifierIcon>();
  [CompilerGenerated]
  public int \u003CmodifierCount\u003Ek__BackingField;
  public ModifierIconMultiple stormLevelIcon;

  public int modifierCount
  {
    get => this.\u003CmodifierCount\u003Ek__BackingField;
    set => this.\u003CmodifierCount\u003Ek__BackingField = value;
  }

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

  public ModifierIcon AddToStormLevelIcon(GameModifierData modifier)
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

  public ModifierIcon CreateStormLevelIcon(GameModifierData firstModifier)
  {
    ++this.modifierCount;
    this.stormLevelIcon = Object.Instantiate<ModifierIconMultiple>(this.stormLevelIconPrefab, this.transform);
    this.stormLevelIcon.Set(firstModifier, this.popUpOffset);
    this.icons.Add((ModifierIcon) this.stormLevelIcon);
    return (ModifierIcon) this.stormLevelIcon;
  }
}
