// Decompiled with JetBrains decompiler
// Type: DataFile
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using Deadpan.Enums.Engine.Components.Modding;
using System;
using UnityEngine;

#nullable disable
public class DataFile : ScriptableObject
{
  [NonSerialized]
  public WildfrostMod ModAdded;

  public override bool Equals(object other)
  {
    UnityEngine.Object object1 = other as UnityEngine.Object;
    UnityEngine.Object object2 = (UnityEngine.Object) this;
    return object1.GetInstanceID() == object2.GetInstanceID();
  }

  public override int GetHashCode() => this.name.GetHashCode();
}
