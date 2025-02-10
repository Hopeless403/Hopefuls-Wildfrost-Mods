// Decompiled with JetBrains decompiler
// Type: Hoverable3d
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class Hoverable3d : GameSystem
{
  [SerializeField]
  private UnityEvent onHover;
  [SerializeField]
  private UnityEvent onUnHover;

  public void Hover() => this.onHover?.Invoke();

  public void UnHover() => this.onUnHover?.Invoke();
}
