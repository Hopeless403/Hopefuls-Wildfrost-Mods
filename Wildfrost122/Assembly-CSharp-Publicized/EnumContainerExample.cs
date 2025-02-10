// Decompiled with JetBrains decompiler
// Type: EnumContainerExample
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using BetaJester.EnumGenerator;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
public class EnumContainerExample : MonoBehaviour, IEnumContainer
{
  public List<ObjectInfo> objectInfos = new List<ObjectInfo>();

  public BetaJester.EnumGenerator.EnumInfo[] GetEnums()
  {
    return new BetaJester.EnumGenerator.EnumInfo[1]
    {
      new BetaJester.EnumGenerator.EnumInfo()
      {
        _name = "ObjectType",
        _values = this.objectInfos.Select<ObjectInfo, string>((Func<ObjectInfo, string>) (x => x.objectName)).ToArray<string>()
      }
    };
  }
}
