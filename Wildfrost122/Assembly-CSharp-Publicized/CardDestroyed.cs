﻿// Decompiled with JetBrains decompiler
// Type: CardDestroyed
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
public class CardDestroyed : FlyOffScreen, ICardDestroyed, IRemoveWhenPooled
{
  public AngleWobbler[] wobblers;

  public override void Begin()
  {
    this.wobblers = this.GetComponentsInChildren<AngleWobbler>();
    foreach (AngleWobbler wobbler in this.wobblers)
      wobbler.globalSpace = false;
  }

  public override void End() => this.Final();

  public void Final()
  {
    Object.Destroy((Object) this);
    CardManager.ReturnToPool(this.gameObject.GetComponent<Card>());
  }

  public void OnDisable()
  {
    foreach (AngleWobbler wobbler in this.wobblers)
      wobbler.globalSpace = true;
    this.wobblers = (AngleWobbler[]) null;
  }
}
