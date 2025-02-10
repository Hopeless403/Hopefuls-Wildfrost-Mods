// Decompiled with JetBrains decompiler
// Type: ActionSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;

#nullable disable
public class ActionSequence : PlayAction
{
  public readonly Routine routine;

  public ActionSequence(IEnumerator enumerator) => this.routine = new Routine(enumerator, false);

  public override IEnumerator Run()
  {
    this.routine.Start();
    while (this.routine.IsRunning)
      yield return (object) null;
  }
}
