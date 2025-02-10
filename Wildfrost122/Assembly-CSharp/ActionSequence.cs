// Decompiled with JetBrains decompiler
// Type: ActionSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;

#nullable disable
public class ActionSequence : PlayAction
{
  private readonly Routine routine;

  public ActionSequence(IEnumerator enumerator) => this.routine = new Routine(enumerator, false);

  public override IEnumerator Run()
  {
    this.routine.Start();
    while (this.routine.IsRunning)
      yield return (object) null;
  }
}
