// Decompiled with JetBrains decompiler
// Type: CampaignNodeTypeJournalPage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "CampaignNodeJournalPage", menuName = "Campaign/Node Type/Journal Page")]
public class CampaignNodeTypeJournalPage : CampaignNodeType
{
  [SerializeField]
  private UnlockData unlock;

  public override IEnumerator Run(CampaignNode node)
  {
    List<string> unlockedList = MetaprogressionSystem.GetUnlockedList();
    if (!unlockedList.Contains(this.unlock.name))
    {
      unlockedList.Add(this.unlock.name);
      SaveSystem.SaveProgressData<List<string>>("unlocked", unlockedList);
    }
    node.SetCleared();
    PauseMenu pauseMenu = UnityEngine.Object.FindObjectOfType<PauseMenu>(true);
    if (pauseMenu != null)
    {
      pauseMenu.OpenLorePages();
      yield return (object) new WaitUntil((Func<bool>) (() => !pauseMenu.gameObject.activeSelf));
    }
    References.Map.Continue();
  }

  public override bool HasMissingData(CampaignNode node) => false;
}
