// Decompiled with JetBrains decompiler
// Type: UnlockData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using UnityEngine;
using UnityEngine.Localization;

#nullable disable
[CreateAssetMenu(menuName = "Town/Unlock", fileName = "Unlock")]
public class UnlockData : DataFile
{
  [SerializeField]
  private bool active = true;
  [ShowIf("active")]
  public bool activeInDemo = true;
  [ShowIf("active")]
  public bool activeInPressDemo = true;
  public UnlockData.Type type;
  public BuildingType relatedBuilding;
  public float lowPriority;
  public UnlockData[] requires;
  public LocalizedString unlockTitle;
  public LocalizedString unlockDesc;

  public bool IsActive => this.active;

  public enum Type
  {
    None,
    BuildingStarted,
    BuildingFinished,
    Item,
    Pet,
    Tribe,
    Companion,
    Event,
    JournalPage,
    Charm,
  }
}
