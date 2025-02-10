// Decompiled with JetBrains decompiler
// Type: UnlockData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using UnityEngine;
using UnityEngine.Localization;

[CreateAssetMenu(menuName = "Town/Unlock", fileName = "Unlock")]
public class UnlockData : DataFile
{
  [SerializeField]
  public bool active = true;
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
