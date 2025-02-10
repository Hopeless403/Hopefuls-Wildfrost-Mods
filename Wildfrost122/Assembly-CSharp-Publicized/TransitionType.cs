// Decompiled with JetBrains decompiler
// Type: TransitionType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

#nullable disable
public abstract class TransitionType : MonoBehaviour
{
  [CompilerGenerated]
  public bool \u003CIsRunning\u003Ek__BackingField;

  public bool IsRunning
  {
    get => this.\u003CIsRunning\u003Ek__BackingField;
    set => this.\u003CIsRunning\u003Ek__BackingField = value;
  }

  public virtual IEnumerator In() => (IEnumerator) null;

  public virtual IEnumerator Out() => (IEnumerator) null;
}
