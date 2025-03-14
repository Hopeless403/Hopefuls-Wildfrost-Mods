﻿// Decompiled with JetBrains decompiler
// Type: AssetLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
public class AssetLoader : MonoBehaviour
{
  public AssetLoader.Group[] groups;
  private static Dictionary<string, AssetLoader.Group> groupLookup;

  private void Awake()
  {
    Debug.Log((object) "> AssetLoader Loading Resources...");
    StopWatch.Start();
    int num1 = 0;
    int num2 = 0;
    AssetLoader.groupLookup = new Dictionary<string, AssetLoader.Group>();
    foreach (AssetLoader.Group group in this.groups)
    {
      AssetLoader.groupLookup[group.name.ToLower()] = group;
      group.lookup = new Dictionary<string, UnityEngine.Object>();
      ++num1;
      foreach (UnityEngine.Object asset in group.assets)
      {
        group.lookup[asset.name.ToLower()] = asset;
        ++num2;
      }
    }
    Debug.Log((object) string.Format("> {0} Groups", (object) num1));
    Debug.Log((object) string.Format("> {0} Assets", (object) num2));
    Debug.Log((object) string.Format("> DONE ({0}ms)", (object) StopWatch.Stop()));
  }

  public static T Lookup<T>(string groupName, string assetName) where T : UnityEngine.Object
  {
    return AssetLoader.GetGroup(groupName)?.lookup[assetName.ToLower()] as T;
  }

  public static AssetLoader.Group GetGroup(string groupName)
  {
    return AssetLoader.groupLookup[groupName.ToLower()];
  }

  public static IEnumerable<T> GetEnumerable<T>(string groupName)
  {
    AssetLoader.Group group = AssetLoader.GetGroup(groupName);
    return group == null ? (IEnumerable<T>) null : Enumerable.Cast<T>(group.assets);
  }

  public static List<T> GetList<T>(string groupName)
  {
    IEnumerable<T> enumerable = AssetLoader.GetEnumerable<T>(groupName);
    return enumerable == null ? (List<T>) null : enumerable.ToList<T>();
  }

  public static T[] GetArray<T>(string groupName)
  {
    IEnumerable<T> enumerable = AssetLoader.GetEnumerable<T>(groupName);
    return enumerable == null ? (T[]) null : enumerable.ToArray<T>();
  }

  [Serializable]
  public class Group
  {
    public string name;
    public UnityEngine.Object[] assets;
    public Dictionary<string, UnityEngine.Object> lookup;
  }
}
