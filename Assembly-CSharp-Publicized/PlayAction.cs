// Decompiled with JetBrains decompiler
// Type: PlayAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

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
