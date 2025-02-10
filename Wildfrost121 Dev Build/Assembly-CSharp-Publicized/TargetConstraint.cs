// Decompiled with JetBrains decompiler
// Type: TargetConstraint
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
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
