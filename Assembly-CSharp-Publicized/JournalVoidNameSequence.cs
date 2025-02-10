// Decompiled with JetBrains decompiler
// Type: JournalVoidNameSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

public class JournalVoidNameSequence : MonoBehaviour
{
  [SerializeField]
  public LeaderNameHistoryDisplay display;
  [SerializeField]
  public TweenUI endTween;

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
