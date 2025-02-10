// Decompiled with JetBrains decompiler
// Type: Routine
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using System.Collections.Generic;

public class Routine
{
  public readonly CoroutineManager.State task;

  public event Routine.FinishedHandler Finished;

  public bool IsRunning => this.task.IsRunning;

  public bool IsPaused => this.task.IsPaused;

  public Routine(IEnumerator c, bool autoStart = true)
  {
    this.task = CoroutineManager.Create(c);
    this.task.Finished += new CoroutineManager.State.FinishedHandler(this.TaskFinished);
    if (!autoStart)
      return;
    this.Start();
  }

  public static Routine Create(IEnumerator c, bool autoStart = true) => new Routine(c, autoStart);

  public void Start() => this.task.Start();

  public void Stop() => this.task.Stop();

  public void Pause() => this.task.Pause();

  public void Unpause() => this.task.Unpause();

  public void TaskFinished(bool manual)
  {
    Routine.FinishedHandler finished = this.Finished;
    if (finished == null)
      return;
    finished(manual);
  }

  public delegate void FinishedHandler(bool manualStop);

  public class Clump
  {
    public readonly List<Routine> list = new List<Routine>();

    public int Count => this.list.Count;

    public static Routine.Clump Create(params IEnumerator[] routines)
    {
      Routine.Clump clump = new Routine.Clump();
      foreach (IEnumerator routine in routines)
        clump.Add(routine);
      return clump;
    }

    public void Add(Routine item) => this.list.Add(item);

    public void Add(IEnumerator c) => this.Add(new Routine(c));

    public IEnumerator WaitForEnd()
    {
      while (this.Count > 0)
      {
        bool flag = false;
        foreach (Routine routine in this.list)
        {
          if (routine != null && routine.IsRunning)
          {
            flag = true;
            break;
          }
        }
        if (!flag)
          break;
        yield return (object) null;
      }
    }

    public void Clear()
    {
      foreach (Routine routine in this.list)
        routine.Stop();
      this.list.Clear();
    }
  }
}
