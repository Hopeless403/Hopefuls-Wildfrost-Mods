// Decompiled with JetBrains decompiler
// Type: DataFile
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

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
