// Decompiled with JetBrains decompiler
// Type: AddressableLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class AddressableLoader : MonoBehaviour
{
  [SerializeField]
  private bool initOnStart;
  private static readonly Dictionary<string, AddressableLoader.Group> groups = new Dictionary<string, AddressableLoader.Group>();

  private IEnumerator Start()
  {
    if (this.initOnStart)
    {
      Debug.Log((object) "Addressables Init");
      yield return (object) Addressables.InitializeAsync();
      Debug.Log((object) "Addressables Init Done");
    }
  }

  public static bool IsGroupLoaded(string name) => AddressableLoader.groups.ContainsKey(name);

  public static void ForceLoadGroup(string name)
  {
    AsyncOperationHandle<IList<UnityEngine.Object>> handle;
    if (!AddressableLoader.StartLoadGroup(name, out handle))
      return;
    handle.WaitForCompletion();
    AddressableLoader.StoreGroup<UnityEngine.Object>(name, (ICollection<UnityEngine.Object>) handle.Result);
  }

  public static async Task PreLoadGroup(string name)
  {
    if (AddressableLoader.IsGroupLoaded(name))
      return;
    AsyncOperationHandle<IList<UnityEngine.Object>> handle;
    AddressableLoader.StartLoadGroup(name, out handle);
    IList<UnityEngine.Object> task = await handle.Task;
  }

  public static IEnumerator LoadGroup(string name)
  {
    AsyncOperationHandle<IList<UnityEngine.Object>> handle;
    if (AddressableLoader.StartLoadGroup(name, out handle))
    {
      yield return (object) handle;
      AddressableLoader.StoreGroup<UnityEngine.Object>(name, (ICollection<UnityEngine.Object>) handle.Result);
    }
  }

  private static bool StartLoadGroup(string name, out AsyncOperationHandle<IList<UnityEngine.Object>> handle)
  {
    if (AddressableLoader.IsGroupLoaded(name))
    {
      Debug.Log((object) ("Group [" + name + "] is already loaded!"));
      handle = new AsyncOperationHandle<IList<UnityEngine.Object>>();
      return false;
    }
    handle = Addressables.LoadAssetsAsync<UnityEngine.Object>((object) name, (Action<UnityEngine.Object>) null);
    return true;
  }

  private static void StoreGroup<T>(string name, ICollection<T> data) where T : UnityEngine.Object
  {
    if (data == null)
      data = (ICollection<T>) new List<T>();
    AddressableLoader.Group group = new AddressableLoader.Group((IEnumerable<UnityEngine.Object>) data);
    AddressableLoader.groups[name] = group;
    Debug.Log((object) string.Format("Group [{0}] loaded! ({1} items)", (object) name, (object) data.Count));
  }

  public static List<T> GetGroup<T>(string name) where T : UnityEngine.Object
  {
    if (!AddressableLoader.IsGroupLoaded(name))
      AddressableLoader.ForceLoadGroup(name);
    return AddressableLoader.groups[name].GetList<T>();
  }

  public static void AddToGroup<T>(string name, T value) where T : UnityEngine.Object
  {
    if (!AddressableLoader.IsGroupLoaded(name))
      AddressableLoader.ForceLoadGroup(name);
    AddressableLoader.groups[name].Add<T>(value);
  }

  public static void RemoveFromGroup<T>(string name, T value) where T : UnityEngine.Object
  {
    if (!AddressableLoader.IsGroupLoaded(name))
      AddressableLoader.ForceLoadGroup(name);
    AddressableLoader.groups[name].Remove<T>(value);
  }

  public static void AddRangeToGroup<T>(string name, IEnumerable<T> value) where T : UnityEngine.Object
  {
    if (!AddressableLoader.IsGroupLoaded(name))
      AddressableLoader.ForceLoadGroup(name);
    AddressableLoader.groups[name].AddRange<T>(value);
  }

  public static T Get<T>(string groupName, string assetName) where T : UnityEngine.Object
  {
    if (!AddressableLoader.IsGroupLoaded(groupName))
      AddressableLoader.ForceLoadGroup(groupName);
    try
    {
      return AddressableLoader.groups[groupName].Get<T>(assetName);
    }
    catch (Exception ex)
    {
      throw new Exception("[" + assetName + "] does not exist!\n\n" + ex.Message, ex.InnerException);
    }
  }

  public static T Get<T>(string assetName) where T : UnityEngine.Object
  {
    AsyncOperationHandle<T> asyncOperationHandle = Addressables.LoadAssetAsync<T>((object) assetName);
    asyncOperationHandle.WaitForCompletion();
    return asyncOperationHandle.Result;
  }

  public static bool TryGet<T>(string groupName, string assetName, out T result) where T : UnityEngine.Object
  {
    if (!AddressableLoader.IsGroupLoaded(groupName))
      AddressableLoader.ForceLoadGroup(groupName);
    result = AddressableLoader.groups[groupName].Get<T>(assetName);
    return (UnityEngine.Object) result != (UnityEngine.Object) null;
  }

  public static AsyncOperationHandle<GameObject> InstantiateAsync(
    string key,
    Vector3 position,
    Quaternion rotation,
    Transform parent = null)
  {
    return Addressables.InstantiateAsync((object) key, position, rotation, parent);
  }

  public static AsyncOperationHandle<GameObject> InstantiateAsync(
    AssetReference assetRef,
    Vector3 position,
    Quaternion rotation,
    Transform parent = null)
  {
    return assetRef.InstantiateAsync(position, rotation, parent);
  }

  private class Group
  {
    private readonly Dictionary<string, UnityEngine.Object> lookup = new Dictionary<string, UnityEngine.Object>();
    private readonly List<UnityEngine.Object> list = new List<UnityEngine.Object>();

    public T Get<T>(string name) where T : UnityEngine.Object => !this.lookup.ContainsKey(name) ? default (T) : this.lookup[name] as T;

    public List<T> GetList<T>() where T : UnityEngine.Object => this.list.Cast<T>().ToList<T>();

    public void Add<T>(T obj) where T : UnityEngine.Object
    {
      this.list.Add((UnityEngine.Object) obj);
      this.lookup[AddressableLoader.Group.GetName((UnityEngine.Object) obj)] = (UnityEngine.Object) obj;
    }

    public void Remove<T>(T obj) where T : UnityEngine.Object
    {
      this.list.Remove((UnityEngine.Object) obj);
      this.lookup.Remove(AddressableLoader.Group.GetName((UnityEngine.Object) obj));
    }

    public void AddRange<T>(IEnumerable<T> obj) where T : UnityEngine.Object
    {
      foreach (T obj1 in obj)
        this.Add<T>(obj1);
    }

    public Group(IEnumerable<UnityEngine.Object> items)
    {
      foreach (UnityEngine.Object asset in items)
      {
        this.list.Add(asset);
        this.lookup[AddressableLoader.Group.GetName(asset)] = asset;
      }
    }

    private static string GetName(UnityEngine.Object asset) => !(asset is KeywordData keywordData) ? asset.name : keywordData.name.ToLower();
  }
}
