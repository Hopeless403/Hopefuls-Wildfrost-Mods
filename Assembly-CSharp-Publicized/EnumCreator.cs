﻿// Decompiled with JetBrains decompiler
// Type: BetaJester.EnumGenerator.EnumCreator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections.Generic;
using UnityEngine;

namespace BetaJester.EnumGenerator
{
  public class EnumCreator : MonoBehaviour
  {
    public bool isPerScene = true;
    public static char whiteSpaceReplacement = '_';
    public string namespaceName = "ExampleTeam";
    [Tooltip("Must start with Assets/")]
    public string filePathOverride = "Assets/";
    public EnumInfo[] enumInfo;
    public GameObject[] enumContainers;
    public List<EnumCreator.EnumValRef> createdValues = new List<EnumCreator.EnumValRef>();

    public static T StringToEnum<T>(string value, T defaultValue) where T : struct, IConvertible
    {
      if (!typeof (T).IsEnum)
        throw new ArgumentException("T must be an enumerated type");
      if (string.IsNullOrEmpty(value))
        return defaultValue;
      string str = value.Replace(' ', EnumCreator.whiteSpaceReplacement);
      foreach (T obj in Enum.GetValues(typeof (T)))
      {
        if (obj.ToString().ToLower().Equals(str.Trim().ToLower()))
          return obj;
      }
      return defaultValue;
    }

    public static string EnumToString<T>(T value) => Enum.GetName(typeof (T), (object) value).Replace(EnumCreator.whiteSpaceReplacement, ' ');

    [Serializable]
    public struct EnumValRef
    {
      public string enumName;
      public string enumVal;
      public int enumIntVal;
    }
  }
}
