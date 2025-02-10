// Decompiled with JetBrains decompiler
// Type: JournalVoidNameSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

public class JournalVoidNameSequence : MonoBehaviour
{
  [SerializeField]
  private LeaderNameHistoryDisplay display;
  [SerializeField]
  private TweenUI endTween;

  public static IEnumerator LoadAndRun(bool unloadAfter)
  {
    yield return (object) SceneManager.Load("JournalNameHistory", SceneType.Temporary);
    JournalVoidNameSequence voidNameSequence = Object.FindObjectOfType<JournalVoidNameSequence>();
    yield return (object) voidNameSequence.PlayerKilled();
    if (unloadAfter)
      yield return (object) voidNameSequence.End();
  }

  public IEnumerator PlayerKilled()
  {
    yield return (object) new WaitForSecondsRealtime(0.5f);
    JournalNameHistory.MostRecentNameKilled();
    this.display.Repopulate();
    yield return (object) new WaitForSecondsRealtime(1f);
  }

  public IEnumerator End()
  {
    this.endTween.Fire();
    yield return (object) new WaitForSecondsRealtime(this.endTween.GetDuration());
    Routine routine = new Routine(SceneManager.Unload("JournalNameHistory"));
  }
}
