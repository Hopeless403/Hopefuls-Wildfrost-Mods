// Decompiled with JetBrains decompiler
// Type: TargetConstraint
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using UnityEngine;

#nullable disable
public abstract class TargetConstraint : ScriptableObject
{
  [SerializeField]
  public bool not;

  public virtual bool Check(Entity target) => throw new NotImplementedException();

  public virtual bool Check(CardData targetData) => throw new NotImplementedException();
}
