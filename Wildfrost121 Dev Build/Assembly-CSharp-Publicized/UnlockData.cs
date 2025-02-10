// Decompiled with JetBrains decompiler
// Type: UnlockData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using UnityEngine;
using UnityEngine.Localization;

#nullable disable
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
