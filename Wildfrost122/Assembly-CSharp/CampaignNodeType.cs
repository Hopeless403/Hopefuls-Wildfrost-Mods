// Decompiled with JetBrains decompiler
// Type: CampaignNodeType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "CampaignNodeType", menuName = "Campaign/Node Type/Basic")]
public class CampaignNodeType : DataFile
{
  public string letter;
  public string zoneName;
  public bool mustClear;
  public bool canSkip;
  public bool canEnter;
  public bool isBattle;
  public bool isBoss;
  public bool modifierReward;
  public bool interactable;
  public bool startRevealed;
  public bool finalNode;
  public MapNode mapNodePrefab;
  public Sprite mapNodeSprite;
  public float size = 1f;
  public bool canLink;

  public virtual IEnumerator SetUp(CampaignNode node) => (IEnumerator) null;

  public virtual IEnumerator Run(CampaignNode node) => (IEnumerator) null;

  public virtual bool HasMissingData(CampaignNode node) => false;
}
