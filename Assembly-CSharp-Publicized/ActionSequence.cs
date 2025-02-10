// Decompiled with JetBrains decompiler
// Type: ActionSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;

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
