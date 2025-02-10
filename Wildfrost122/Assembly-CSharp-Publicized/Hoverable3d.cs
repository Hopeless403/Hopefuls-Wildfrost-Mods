// Decompiled with JetBrains decompiler
// Type: Hoverable3d
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class Hoverable3d : GameSystem
{
  [SerializeField]
  public UnityEvent onHover;
  [SerializeField]
  public UnityEvent onUnHover;

  public void Hover() => this.onHover?.Invoke();

  public void UnHover() => this.onUnHover?.Invoke();
}
