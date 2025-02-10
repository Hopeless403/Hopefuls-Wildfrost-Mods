// Decompiled with JetBrains decompiler
// Type: TargetConstraint
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using UnityEngine;

public abstract class TargetConstraint : ScriptableObject
{
  [SerializeField]
  protected bool not;

  public virtual bool Check(Entity target) => throw new NotImplementedException();

  public virtual bool Check(CardData targetData) => throw new NotImplementedException();
}
