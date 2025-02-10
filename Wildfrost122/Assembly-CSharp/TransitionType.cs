// Decompiled with JetBrains decompiler
// Type: TransitionType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

#nullable disable
public abstract class TransitionType : MonoBehaviour
{
  public bool IsRunning { get; protected set; }

  public virtual IEnumerator In() => (IEnumerator) null;

  public virtual IEnumerator Out() => (IEnumerator) null;
}
