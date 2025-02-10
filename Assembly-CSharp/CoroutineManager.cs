// Decompiled with JetBrains decompiler
// Type: CoroutineManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

public class CoroutineManager : MonoBehaviour
{
  private static CoroutineManager instance;

  private static void InstanceCheck()
  {
    if ((bool) (Object) CoroutineManager.instance)
      return;
    CoroutineManager.instance = Object.FindObjectOfType<CoroutineManager>();
    if ((bool) (Object) CoroutineManager.instance)
      return;
    CoroutineManager.instance = new GameObject(nameof (CoroutineManager)).AddComponent<CoroutineManager>();
  }

  public static CoroutineManager.State Create(IEnumerator coroutine)
  {
    CoroutineManager.InstanceCheck();
    return new CoroutineManager.State(coroutine);
  }

  public static void Start(IEnumerator coroutine)
  {
    CoroutineManager.InstanceCheck();
    CoroutineManager.instance.StartCoroutine(coroutine);
  }

  public class State
  {
    private IEnumerator coroutine;
    private bool running;
    private bool paused;
    private bool stopped;

    public event CoroutineManager.State.FinishedHandler Finished;

    public bool IsRunning => this.running;

    public bool IsPaused => this.paused;

    public State(IEnumerator coroutine) => this.coroutine = coroutine;

    public void Pause() => this.paused = true;

    public void Unpause() => this.paused = false;

    public void Start()
    {
      this.running = true;
      CoroutineManager.instance.StartCoroutine(this.CallWrapper());
    }

    public void Stop()
    {
      this.stopped = true;
      this.running = false;
    }

    private IEnumerator CallWrapper()
    {
      yield return (object) null;
      IEnumerator e = this.coroutine;
      while (this.running)
      {
        if (this.paused)
          yield return (object) null;
        else if (e != null && e.MoveNext())
          yield return e.Current;
        else
          this.running = false;
      }
      CoroutineManager.State.FinishedHandler finished = this.Finished;
      if (finished != null)
        finished(this.stopped);
    }

    public delegate void FinishedHandler(bool manualStop);
  }
}
