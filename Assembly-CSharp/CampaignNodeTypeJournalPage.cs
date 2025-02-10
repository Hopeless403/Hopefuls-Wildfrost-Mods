// Decompiled with JetBrains decompiler
// Type: CampaignNodeTypeJournalPage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
}
