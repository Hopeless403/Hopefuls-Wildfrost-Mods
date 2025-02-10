// Decompiled with JetBrains decompiler
// Type: PlayAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;

public abstract class PlayAction
{
  public float pauseBefore;
  public float pauseAfter;
  public int priority;
  public bool fixedPosition;
  public bool parallel;
  public string note;

  public virtual bool IsRoutine => true;

  public virtual void Process()
  {
  }

  public virtual IEnumerator Run() => (IEnumerator) null;

  public virtual string Name => this.GetType().Name + (this.note.IsNullOrWhitespace() ? "" : " [" + this.note + "]");
}
