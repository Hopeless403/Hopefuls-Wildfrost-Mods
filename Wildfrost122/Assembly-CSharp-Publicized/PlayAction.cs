// Decompiled with JetBrains decompiler
// Type: PlayAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;

#nullable disable
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

  public virtual string Name
  {
    get => this.GetType().Name + (this.note.IsNullOrWhitespace() ? "" : " [" + this.note + "]");
  }
}
