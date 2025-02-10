// Decompiled with JetBrains decompiler
// Type: DataFile
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

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
    if (!(bool) object1 || !(bool) object2 || !(other is DataFile dataFile) || !(dataFile.name == this.name))
      return false;
    if (this.ModAdded == null)
      return true;
    return this.ModAdded != null && this.ModAdded.GUID == dataFile.ModAdded.GUID;
  }

  public override int GetHashCode() => this.name.GetHashCode();
}
