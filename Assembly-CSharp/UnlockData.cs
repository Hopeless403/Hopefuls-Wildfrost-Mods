// Decompiled with JetBrains decompiler
// Type: UnlockData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using UnityEngine;
using UnityEngine.Localization;

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
