// Decompiled with JetBrains decompiler
// Type: CoroutineManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

#nullable disable
public class CoroutineManager : MonoBehaviour
{
  public static CoroutineManager instance;

  public static void InstanceCheck()
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
    public IEnumerator coroutine;
    public bool running;
    public bool paused;
    public bool stopped;

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

    public IEnumerator CallWrapper()
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
