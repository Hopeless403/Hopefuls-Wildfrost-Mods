// Decompiled with JetBrains decompiler
// Type: JournalAddNameSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using FMODUnity;
using System.Collections;
using UnityEngine;

#nullable disable
public class JournalAddNameSequence : MonoBehaviour
{
  [SerializeField]
  private LeaderNameHistoryDisplay display;
  [SerializeField]
  private TweenUI endTween;
  [SerializeField]
  private EventReference sfxEvent;

  public static IEnumerator LoadAndRun(CardData leader, bool unloadAfter)
  {
    InputSystem.Disable();
    yield return (object) SceneManager.Load("JournalNameHistory", SceneType.Temporary);
    JournalAddNameSequence addNameSequence = Object.FindObjectOfType<JournalAddNameSequence>();
    yield return (object) addNameSequence.Run(leader);
    if (unloadAfter)
    {
      Routine routine = new Routine(addNameSequence.End());
    }
    InputSystem.Enable();
  }

  public IEnumerator Run(CardData leader)
  {
    yield return (object) new WaitForSecondsRealtime(0.5f);
    JournalNameHistory.FadePrevious();
    JournalNameHistory.AddName(leader.title);
    this.display.Repopulate();
    SfxSystem.OneShot(this.sfxEvent);
    yield return (object) new WaitForSecondsRealtime(1f);
  }

  public IEnumerator End()
  {
    this.endTween.Fire();
    yield return (object) new WaitForSecondsRealtime(this.endTween.GetDuration());
    Routine routine = new Routine(SceneManager.Unload("JournalNameHistory"));
  }
}
