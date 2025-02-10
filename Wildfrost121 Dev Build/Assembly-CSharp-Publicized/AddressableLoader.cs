// Decompiled with JetBrains decompiler
// Type: AddressableLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

#nullable disable
public class AddressableLoader : MonoBehaviour
{
  [SerializeField]
  public bool initOnStart;
  public static readonly Dictionary<string, AddressableLoader.Group> groups = new Dictionary<string, AddressableLoader.Group>();

  public IEnumerator Start()
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
    AsyncOperationHandle<IList<DataFile>> handle;
    if (!AddressableLoader.StartLoadGroup(name, out handle))
      return;
    handle.WaitForCompletion();
    AddressableLoader.StoreGroup<DataFile>(name, (ICollection<DataFile>) handle.Result);
  }

  public static async Task PreLoadGroup(string name)
  {
    if (AddressableLoader.IsGroupLoaded(name))
      return;
    AsyncOperationHandle<IList<DataFile>> handle;
    AddressableLoader.StartLoadGroup(name, out handle);
    IList<DataFile> task = await handle.Task;
  }

  public static IEnumerator LoadGroup(string name)
  {
    AsyncOperationHandle<IList<DataFile>> handle;
    if (AddressableLoader.StartLoadGroup(name, out handle))
    {
      yield return (object) handle;
      AddressableLoader.StoreGroup<DataFile>(name, (ICollection<DataFile>) handle.Result);
    }
  }

  public static bool StartLoadGroup(string name, out AsyncOperationHandle<IList<DataFile>> handle)
  {
    if (AddressableLoader.IsGroupLoaded(name))
    {
      Debug.Log((object) ("Group [" + name + "] is already loaded!"));
      handle = new AsyncOperationHandle<IList<DataFile>>();
      return false;
    }
    handle = Addressables.LoadAssetsAsync<DataFile>((object) name, (Action<DataFile>) null);
    return true;
  }

  public static void StoreGroup<T>(string name, ICollection<T> data) where T : DataFile
  {
    if (data == null)
      data = (ICollection<T>) new List<T>();
    AddressableLoader.Group group = new AddressableLoader.Group((IEnumerable<DataFile>) data);
    AddressableLoader.groups[name] = group;
    Debug.Log((object) string.Format("Group [{0}] loaded! ({1} items)", (object) name, (object) data.Count));
  }

  public static List<T> GetGroup<T>(string name) where T : DataFile
  {
    if (!AddressableLoader.IsGroupLoaded(name))
      AddressableLoader.ForceLoadGroup(name);
    return AddressableLoader.groups[name].GetList<T>();
  }

  public static void AddToGroup<T>(string name, T value) where T : DataFile
  {
    if (!AddressableLoader.IsGroupLoaded(name))
      AddressableLoader.ForceLoadGroup(name);
    AddressableLoader.groups[name].Add<T>(value);
  }

  public static void RemoveFromGroup<T>(string name, T value) where T : DataFile
  {
    if (!AddressableLoader.IsGroupLoaded(name))
      AddressableLoader.ForceLoadGroup(name);
    AddressableLoader.groups[name].Remove<T>(value);
  }

  public static void AddRangeToGroup<T>(string name, IEnumerable<T> value) where T : DataFile
  {
    if (!AddressableLoader.IsGroupLoaded(name))
      AddressableLoader.ForceLoadGroup(name);
    AddressableLoader.groups[name].AddRange<T>(value);
  }

  public static T Get<T>(string groupName, string assetName) where T : DataFile
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

  public static CardData GetCardDataClone(string cardDataName)
  {
    CardData cardData = AddressableLoader.Get<CardData>("CardData", cardDataName);
    return !(bool) (UnityEngine.Object) cardData ? MissingCardSystem.GetClone(cardDataName) : cardData.Clone();
  }

  public static T Get<T>(string assetName) where T : DataFile
  {
    AsyncOperationHandle<T> asyncOperationHandle = Addressables.LoadAssetAsync<T>((object) assetName);
    asyncOperationHandle.WaitForCompletion();
    return asyncOperationHandle.Result;
  }

  public static GameObject Get(string assetName)
  {
    AsyncOperationHandle<GameObject> asyncOperationHandle = Addressables.LoadAssetAsync<GameObject>((object) assetName);
    asyncOperationHandle.WaitForCompletion();
    return asyncOperationHandle.Result;
  }

  public static bool TryGet<T>(string groupName, string assetName, out T result) where T : DataFile
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

  public class Group
  {
    public readonly Dictionary<string, DataFile> lookup = new Dictionary<string, DataFile>();
    public readonly List<DataFile> list = new List<DataFile>();

    public T Get<T>(string name) where T : DataFile
    {
      return !this.lookup.ContainsKey(name) ? default (T) : this.lookup[name] as T;
    }

    public List<T> GetList<T>() where T : DataFile => this.list.Cast<T>().ToList<T>();

    public void Add<T>(T obj) where T : DataFile
    {
      this.list.Add((DataFile) obj);
      this.lookup[AddressableLoader.Group.GetName((DataFile) obj)] = (DataFile) obj;
    }

    public void Remove<T>(T obj) where T : DataFile
    {
      this.list.Remove((DataFile) obj);
      this.lookup.Remove(AddressableLoader.Group.GetName((DataFile) obj));
    }

    public void AddRange<T>(IEnumerable<T> obj) where T : DataFile
    {
      foreach (T obj1 in obj)
        this.Add<T>(obj1);
    }

    public Group(IEnumerable<DataFile> items)
    {
      foreach (DataFile asset in items)
      {
        this.list.Add(asset);
        this.lookup[AddressableLoader.Group.GetName(asset)] = asset;
      }
    }

    public static string GetName(DataFile asset)
    {
      return !(asset is KeywordData keywordData) ? asset.name : keywordData.name.ToLower();
    }
  }
}
