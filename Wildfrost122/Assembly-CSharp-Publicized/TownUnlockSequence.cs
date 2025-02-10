// Decompiled with JetBrains decompiler
// Type: TownUnlockSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

#nullable disable
public class TownUnlockSequence : MonoBehaviour
{
  [SerializeField]
  public GainUnlockSequence unlockSequence;
  [SerializeField]
  public Fader fader;
  [SerializeField]
  public float pauseBeforeUnlock = 0.1f;
  [SerializeField]
  public float pauseAfterUnlock = 0.1f;
  public const float fadeOutDur = 0.1f;

  public IEnumerator Start()
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

  [CompilerGenerated]
  public bool \u003CStart\u003Eb__5_1() => !this.unlockSequence.gameObject.activeSelf;
}
