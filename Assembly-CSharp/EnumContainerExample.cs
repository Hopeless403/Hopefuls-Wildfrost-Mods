// Decompiled with JetBrains decompiler
// Type: EnumContainerExample
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using BetaJester.EnumGenerator;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class EnumContainerExample : MonoBehaviour, IEnumContainer
{
  public List<ObjectInfo> objectInfos = new List<ObjectInfo>();

  public BetaJester.EnumGenerator.EnumInfo[] GetEnums() => new BetaJester.EnumGenerator.EnumInfo[1]
  {
    new BetaJester.EnumGenerator.EnumInfo()
    {
      _name = "ObjectType",
      _values = this.objectInfos.Select<ObjectInfo, string>((Func<ObjectInfo, string>) (x => x.objectName)).ToArray<string>()
    }
  };
}
