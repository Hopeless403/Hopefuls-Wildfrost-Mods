// Decompiled with JetBrains decompiler
// Type: Town
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using FMODUnity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
public class Town : MonoBehaviourSingleton<Town>
{
  [SerializeField]
  public HelpPanelShower tutorialPrompt;
  [SerializeField]
  public EventReference denySfxEvent;

  public override void Awake()
  {
    base.Awake();
    Town.CheckStartConstruction();
  }

  public IEnumerator Start()
  {
    foreach (Building building in Object.FindObjectsOfType<Building>(true))
      building.CheckIfUnlocked();
    if ((bool) (Object) CardFramesSystem.instance && CardFramesSystem.instance.AnyNewFrames())
      yield return (object) CardFramesSystem.instance.DisplayNewFrames();
    if (NewFinalBossChecker.Check())
      yield return (object) NewFinalBossChecker.Run();
    if (MetaprogressionSystem.AnyUnlocksReady())
    {
      yield return (object) SceneManager.Load("TownUnlocks", SceneType.Temporary);
      yield return (object) SceneManager.WaitUntilUnloaded("TownUnlocks");
    }
    this.CheckTutorialPrompt();
  }

  public static void SelectBuilding(Building building)
  {
    if (building.built)
    {
      if (building.Select())
        return;
      Events.InvokeCameraAnimation("Shake");
      SfxSystem.OneShot(MonoBehaviourSingleton<Town>.instance.denySfxEvent);
    }
    else
    {
      Events.InvokeCameraAnimation("Shake");
      SfxSystem.OneShot(MonoBehaviourSingleton<Town>.instance.denySfxEvent);
    }
  }

  public static void CheckStartConstruction()
  {
    List<string> unlockedList = MetaprogressionSystem.GetUnlockedList();
    List<string> stringList = MetaprogressionSystem.Get<List<string>>("buildings");
    List<UnlockData> list = new List<UnlockData>();
    foreach (string assetName in stringList)
    {
      if (!unlockedList.Contains(assetName))
      {
        UnlockData unlockData = AddressableLoader.Get<UnlockData>("UnlockData", assetName);
        list.AddIfNotNull<UnlockData>(unlockData);
      }
    }
    UnlockData unlockData1 = (UnlockData) null;
    foreach (UnlockData unlock in list)
    {
      if (unlock.IsActive && MetaprogressionSystem.CheckUnlockRequirements(unlock, (ICollection<string>) unlockedList))
      {
        unlockData1 = unlock;
        break;
      }
    }
    if (!(bool) (Object) unlockData1)
      return;
    unlockedList.Add(unlockData1.name);
    SaveSystem.SaveProgressData<List<string>>("unlocked", unlockedList);
    MetaprogressionSystem.SetUnlocksReady(unlockData1.name);
  }

  public void CheckTutorialPrompt()
  {
    if (SaveSystem.LoadProgressData<bool>("tutorialTownDone", false))
      return;
    this.tutorialPrompt.Show();
    SaveSystem.SaveProgressData<bool>("tutorialTownDone", true);
  }
}
