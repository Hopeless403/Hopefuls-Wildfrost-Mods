﻿// Decompiled with JetBrains decompiler
// Type: GameSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

public abstract class GameSystem : MonoBehaviour
{
  public void Enable() => this.enabled = true;

  public void Disable() => this.enabled = false;
}
