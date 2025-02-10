// Decompiled with JetBrains decompiler
// Type: AssetLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

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

  public static T Lookup<T>(string groupName, string assetName) where T : UnityEngine.Object => AssetLoader.GetGroup(groupName)?.lookup[assetName.ToLower()] as T;

  public static AssetLoader.Group GetGroup(string groupName) => AssetLoader.groupLookup[groupName.ToLower()];

  public static IEnumerable<T> GetEnumerable<T>(string groupName)
  {
    AssetLoader.Group group = AssetLoader.GetGroup(groupName);
    return group == null ? (IEnumerable<T>) null : group.assets.Cast<T>();
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
