// Decompiled with JetBrains decompiler
// Type: TownUnlockSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TownUnlockSequence : MonoBehaviour
{
  [SerializeField]
  private GainUnlockSequence unlockSequence;
  [SerializeField]
  private Fader fader;
  [SerializeField]
  private float pauseBeforeUnlock = 0.1f;
  [SerializeField]
  private float pauseAfterUnlock = 0.1f;
  private const float fadeOutDur = 0.1f;

  private IEnumerator Start()
  {
    TownUnlockSequence townUnlockSequence = this;
    yield return (object) AddressableLoader.LoadGroup("UnlockData");
    List<UnlockData> unlocks = AddressableLoader.GetGroup<UnlockData>("UnlockData");
    List<string> unlocksToGain = SaveSystem.LoadProgressData<List<string>>("townNew", new List<string>());
    foreach (string str in unlocksToGain)
    {
      string unlockName = str;
      UnlockData unlockData = unlocks.FirstOrDefault<UnlockData>((Func<UnlockData, bool>) (a => a.name == unlockName));
      if ((UnityEngine.Object) unlockData != (UnityEngine.Object) null)
      {
        yield return (object) new WaitForSeconds(townUnlockSequence.pauseBeforeUnlock);
        Events.InvokeTownUnlock(unlockData);
        townUnlockSequence.unlockSequence.SetUp(unlockData);
        // ISSUE: reference to a compiler-generated method
        yield return (object) new WaitUntil(new Func<bool>(townUnlockSequence.\u003CStart\u003Eb__5_1));
        yield return (object) new WaitForSeconds(townUnlockSequence.pauseAfterUnlock);
      }
      unlockData = (UnlockData) null;
    }
    unlocksToGain.Clear();
    SaveSystem.SaveProgressData<List<string>>("townNew", unlocksToGain);
    townUnlockSequence.fader.Out(0.1f, LeanTweenType.linear);
    yield return (object) new WaitForSeconds(0.1f);
    Routine routine = new Routine(SceneManager.Unload("TownUnlocks"));
  }
}
