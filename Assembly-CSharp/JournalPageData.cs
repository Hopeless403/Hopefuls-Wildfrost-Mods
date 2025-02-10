// Decompiled with JetBrains decompiler
// Type: JournalPageData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using UnityEngine;
using UnityEngine.AddressableAssets;

[CreateAssetMenu(fileName = "Journal Page Data", menuName = "Journal Page Data")]
public class JournalPageData : ScriptableObject
{
  public UnlockData unlock;
  public bool unlockOnMap = true;
  [ShowIf("unlockOnMap")]
  public char mapTierIndex;
  [ShowIf("unlockOnMap")]
  public char mapAfterLetter;
  [ShowIf("unlockOnMap")]
  public CampaignNodeType mapNodeType;
  public AssetReferenceGameObject prefabRef;
  public GameMode[] legalGameModes;
  public ClassData[] legalTribes;
  public GameModifierData[] requiresModifiers;
  public int requiresStormPoints;
}
