// Decompiled with JetBrains decompiler
// Type: Hoverable3d
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.Events;

public class Hoverable3d : GameSystem
{
  [SerializeField]
  private UnityEvent onHover;
  [SerializeField]
  private UnityEvent onUnHover;

  public void Hover() => this.onHover?.Invoke();

  public void UnHover() => this.onUnHover?.Invoke();
}
