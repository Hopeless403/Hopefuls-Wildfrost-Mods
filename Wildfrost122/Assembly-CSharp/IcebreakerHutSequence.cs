// Decompiled with JetBrains decompiler
// Type: IcebreakerHutSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using FMODUnity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
public class IcebreakerHutSequence : BuildingSequence
{
  [SerializeField]
  private string metaprogressionKey = "events";
  [SerializeField]
  private ImageSprite[] nodes;
  [SerializeField]
  private ButtonAnimator[] buttons;
  [SerializeField]
  private ChallengeData[] challenges;
  [SerializeField]
  private ChallengeDisplayCreator challengeDisplayCreator;
  [SerializeField]
  private string firstGreetKey = "icebreakerFirstGreet";
  [SerializeField]
  private MapInspectSequence mapInspectSequence;
  [SerializeField]
  private EventReference denySfx;
  private readonly List<bool> unlocked = new List<bool>();

  protected override IEnumerator Sequence()
  {
    IcebreakerHutSequence icebreakerHutSequence = this;
    if (icebreakerHutSequence.building.HasUncheckedUnlocks)
    {
      foreach (string uncheckedUnlock in icebreakerHutSequence.building.uncheckedUnlocks)
        icebreakerHutSequence.Unlock(uncheckedUnlock);
      icebreakerHutSequence.building.uncheckedUnlocks.Clear();
      icebreakerHutSequence.TalkerSay("new event", 0.5f);
    }
    else if (!icebreakerHutSequence.firstGreetKey.IsNullOrEmpty() && !SaveSystem.LoadProgressData<bool>(icebreakerHutSequence.firstGreetKey, false))
    {
      icebreakerHutSequence.TalkerFirstGreet();
      SaveSystem.SaveProgressData<bool>(icebreakerHutSequence.firstGreetKey, true);
    }
    else
      icebreakerHutSequence.TalkerGreet();
    List<string> checkedUnlocks = icebreakerHutSequence.building.checkedUnlocks;
    // ISSUE: explicit non-virtual call
    int count = checkedUnlocks != null ? __nonvirtual (checkedUnlocks.Count) : 0;
    icebreakerHutSequence.SetUpMapNodes(count);
    icebreakerHutSequence.SetCurrentChallenge(count);
    yield return (object) null;
  }

  private void Unlock(string unlockDataName)
  {
    List<string> stringList = SaveSystem.LoadProgressData<List<string>>(this.building.type.unlockedCheckedKey, (List<string>) null) ?? new List<string>();
    stringList.Add(unlockDataName);
    SaveSystem.SaveProgressData<List<string>>(this.building.type.unlockedCheckedKey, stringList);
    Building building = this.building;
    if (building.unlocks == null)
      building.unlocks = new List<string>();
    this.building.unlocks.Add(unlockDataName);
  }

  private void SetUpMapNodes(int unlocked)
  {
    List<string> stringList = MetaprogressionSystem.Get<List<string>>(this.metaprogressionKey);
    for (int index = 0; index < stringList.Count; ++index)
      this.unlocked.Add(index < unlocked);
    for (int index = 0; index < unlocked && index < stringList.Count; ++index)
    {
      CampaignNodeType campaignNodeType = AddressableLoader.Get<CampaignNodeType>("CampaignNodeType", stringList[index]);
      this.nodes[index].SetSprite(campaignNodeType.mapNodeSprite);
      this.buttons[index].interactable = true;
    }
  }

  private void SetCurrentChallenge(int unlocked)
  {
    if (unlocked >= this.challenges.Length)
      return;
    this.challengeDisplayCreator.challenge = this.challenges[unlocked];
    this.challengeDisplayCreator.Check();
  }

  public void TryInspect(int mapNodeIndex)
  {
    if (this.unlocked[mapNodeIndex])
      this.mapInspectSequence.Inspect(mapNodeIndex);
    else
      this.Deny(this.nodes[mapNodeIndex].gameObject);
  }

  private void Deny(GameObject obj)
  {
    SfxSystem.OneShot(this.denySfx);
    LeanTween.cancel(obj);
    LeanTween.moveLocal(obj, Vector3.zero, 0.67f).setFrom(new Vector3(0.5f.WithRandomSign(), 0.0f, 0.0f)).setEaseOutElastic();
  }
}
