// Decompiled with JetBrains decompiler
// Type: DataFile
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using Deadpan.Enums.Engine.Components.Modding;
using System;
using UnityEngine;

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
