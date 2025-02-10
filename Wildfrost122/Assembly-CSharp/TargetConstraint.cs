// Decompiled with JetBrains decompiler
// Type: TargetConstraint
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using UnityEngine;

#nullable disable
public abstract class TargetConstraint : ScriptableObject
{
  [SerializeField]
  protected bool not;

  public virtual bool Check(Entity target) => throw new NotImplementedException();

  public virtual bool Check(CardData targetData) => throw new NotImplementedException();
}
