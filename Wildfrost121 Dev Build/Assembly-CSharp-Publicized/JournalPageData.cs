// Decompiled with JetBrains decompiler
// Type: JournalPageData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using UnityEngine;
using UnityEngine.AddressableAssets;

#nullable disable
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
