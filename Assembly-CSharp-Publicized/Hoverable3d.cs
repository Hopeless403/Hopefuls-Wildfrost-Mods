// Decompiled with JetBrains decompiler
// Type: Hoverable3d
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.Events;

public class Hoverable3d : GameSystem
{
  [SerializeField]
  public UnityEvent onHover;
  [SerializeField]
  public UnityEvent onUnHover;

  public void Hover() => this.onHover?.Invoke();

  public void UnHover() => this.onUnHover?.Invoke();
}
