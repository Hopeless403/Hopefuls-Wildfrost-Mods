// Decompiled with JetBrains decompiler
// Type: CharacterRewards
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

#nullable disable
public class CharacterRewards : MonoBehaviour
{
  public readonly Dictionary<string, CharacterRewards.Pool> poolLookup = new Dictionary<string, CharacterRewards.Pool>();

  public void Populate(ClassData classData)
  {
    this.poolLookup.Clear();
    foreach (RewardPool rewardPool in classData.rewardPools)
      this.Add(rewardPool);
  }

  public void Add(RewardPool rewardPool)
  {
    if (!this.poolLookup.ContainsKey(rewardPool.type))
      this.poolLookup[rewardPool.type] = new CharacterRewards.Pool();
    for (int index = 0; index < rewardPool.copies; ++index)
    {
      this.poolLookup[rewardPool.type].Add((IEnumerable<DataFile>) rewardPool.list);
      Debug.Log((object) string.Format("Character Reward Pool [{0}] Populated with [{1}] items from [{2}]", (object) rewardPool.type, (object) rewardPool.list.Count, (object) rewardPool.name));
    }
  }

  public List<DataFile> GetItemsInPool(string name)
  {
    CharacterRewards.Pool pool;
    return this.poolLookup.TryGetValue(name, out pool) ? pool.list : (List<DataFile>) null;
  }

  public void Add(string poolName, IEnumerable<DataFile> items)
  {
    if (!this.poolLookup.ContainsKey(poolName))
      this.poolLookup[poolName] = new CharacterRewards.Pool();
    this.poolLookup[poolName].Add(items);
  }

  public void RemoveLockedCards()
  {
    List<UnlockData> remainingUnlocks = MetaprogressionSystem.GetRemainingUnlocks();
    CharacterRewards.Pool pool1;
    if (this.poolLookup.TryGetValue("Items", out pool1))
    {
      List<string> lockedItems = MetaprogressionSystem.GetLockedItems(remainingUnlocks);
      Debug.Log((object) ("Locked Items: [" + string.Join(", ", (IEnumerable<string>) lockedItems) + "]"));
      pool1.Remove((IEnumerable<string>) lockedItems);
    }
    CharacterRewards.Pool pool2;
    if (this.poolLookup.TryGetValue("Units", out pool2))
    {
      List<string> lockedCompanions = MetaprogressionSystem.GetLockedCompanions(remainingUnlocks);
      Debug.Log((object) ("Locked Companions: [" + string.Join(", ", (IEnumerable<string>) lockedCompanions) + "]"));
      pool2.Remove((IEnumerable<string>) lockedCompanions);
    }
    CharacterRewards.Pool pool3;
    if (!this.poolLookup.TryGetValue("Charms", out pool3))
      return;
    List<string> lockedCharms = MetaprogressionSystem.GetLockedCharms(remainingUnlocks);
    Debug.Log((object) ("Locked Charms: [" + string.Join(", ", (IEnumerable<string>) lockedCharms) + "]"));
    pool3.Remove((IEnumerable<string>) lockedCharms);
  }

  public void RemoveCardsFromStartingDeck()
  {
    HashSet<string> stringSet1 = new HashSet<string>();
    HashSet<string> stringSet2 = new HashSet<string>();
    foreach (CardData cardData in References.PlayerData.inventory.deck)
    {
      switch (cardData.cardType.name)
      {
        case "Friendly":
          stringSet2.Add(cardData.name);
          continue;
        case "Item":
        case "Clunker":
          stringSet1.Add(cardData.name);
          continue;
        default:
          continue;
      }
    }
    if (stringSet1.Count > 0)
    {
      Debug.Log((object) ("Removing Items: [" + string.Join(", ", (IEnumerable<string>) stringSet1) + "]"));
      (this.poolLookup.ContainsKey("Items") ? this.poolLookup["Items"] : (CharacterRewards.Pool) null)?.Remove((IEnumerable<string>) stringSet1);
    }
    if (stringSet2.Count <= 0)
      return;
    Debug.Log((object) ("Removing Units: [" + string.Join(", ", (IEnumerable<string>) stringSet2) + "]"));
    (this.poolLookup.ContainsKey("Units") ? this.poolLookup["Units"] : (CharacterRewards.Pool) null)?.Remove((IEnumerable<string>) stringSet2);
  }

  public void RemoveCompanionsInFinalBossBattle()
  {
    CharacterRewards.Pool pool = (CharacterRewards.Pool) null;
    CardSaveData[] cardSaveDataArray = SaveSystem.LoadProgressData<CardSaveData[]>("finalBossDeck", (CardSaveData[]) null);
    if (cardSaveDataArray == null)
      return;
    foreach (CardSaveData cardSaveData in cardSaveDataArray)
    {
      CardData cardData = cardSaveData.Peek();
      if ((bool) (UnityEngine.Object) cardData && cardData.cardType.name == "Friendly")
      {
        Debug.Log((object) ("Removing [" + cardData.name + "]"));
        if (pool == null)
          pool = this.poolLookup.ContainsKey("Units") ? this.poolLookup["Units"] : (CharacterRewards.Pool) null;
        pool?.Remove(cardData.name);
      }
    }
  }

  public T Pull<T>(object pulledBy, string poolName) where T : DataFile
  {
    return this.Pull<T>(pulledBy, poolName, 1)[0];
  }

  public T[] Pull<T>(object pulledBy, string poolName, int itemCount, bool allowDuplicates = false) where T : DataFile
  {
    List<DataFile> source = Events.PullRewards(pulledBy, poolName, ref itemCount);
    if (this.poolLookup.ContainsKey(poolName))
    {
      CharacterRewards.Pool pool = this.poolLookup[poolName];
      if (source.Count > 0)
      {
        foreach (DataFile dataFile in source)
          pool.PullOut(dataFile);
      }
      if (itemCount > 0)
        source.AddRange((IEnumerable<DataFile>) pool.Pull(itemCount, allowDuplicates));
    }
    return source.Cast<T>().ToArray<T>();
  }

  public T[] Pull<T>(
    object pulledBy,
    string poolName,
    int itemCount,
    bool allowDuplicates,
    Predicate<DataFile> match)
    where T : DataFile
  {
    List<DataFile> source = Events.PullRewards(pulledBy, poolName, ref itemCount);
    if (this.poolLookup.ContainsKey(poolName))
    {
      CharacterRewards.Pool pool = this.poolLookup[poolName];
      if (source.Count > 0)
      {
        foreach (DataFile dataFile in source)
          pool.PullOut(dataFile);
      }
      if (itemCount > 0)
        source.AddRange((IEnumerable<DataFile>) pool.Pull(itemCount, allowDuplicates, match));
    }
    return source.Cast<T>().ToArray<T>();
  }

  public T[] GetFromOriginalList<T>(
    object pulledBy,
    string poolName,
    int itemCount,
    bool allowDuplicates)
    where T : DataFile
  {
    List<DataFile> source = Events.PullRewards(pulledBy, poolName, ref itemCount);
    if (this.poolLookup.ContainsKey(poolName))
    {
      CharacterRewards.Pool pool = this.poolLookup[poolName];
      if (itemCount > 0)
        source.AddRange((IEnumerable<DataFile>) pool.GetFromOriginalList(itemCount, allowDuplicates));
    }
    return source.Cast<T>().ToArray<T>();
  }

  public T[] GetFromOriginalList<T>(
    object pulledBy,
    string poolName,
    int itemCount,
    bool allowDuplicates,
    Predicate<DataFile> match)
    where T : DataFile
  {
    List<DataFile> source = Events.PullRewards(pulledBy, poolName, ref itemCount);
    if (this.poolLookup.ContainsKey(poolName))
    {
      CharacterRewards.Pool pool = this.poolLookup[poolName];
      if (itemCount > 0)
        source.AddRange((IEnumerable<DataFile>) pool.GetFromOriginalList(itemCount, allowDuplicates, match));
    }
    return source.Cast<T>().ToArray<T>();
  }

  public void PullOut(string poolName, IEnumerable<DataFile> items)
  {
    CharacterRewards.Pool pool;
    if (!this.poolLookup.TryGetValue(poolName, out pool))
      return;
    pool.PullOut(items);
  }

  public void PullOut(string poolName, DataFile item)
  {
    CharacterRewards.Pool pool;
    if (!this.poolLookup.TryGetValue(poolName, out pool))
      return;
    pool.PullOut(item);
  }

  public class Pool
  {
    [CompilerGenerated]
    public List<DataFile> \u003Clist\u003Ek__BackingField;
    public readonly List<DataFile> current = new List<DataFile>();

    public List<DataFile> list
    {
      get => this.\u003Clist\u003Ek__BackingField;
      set => this.\u003Clist\u003Ek__BackingField = value;
    }

    public void Add(DataFile item)
    {
      if (this.list == null)
      {
        List<DataFile> dataFileList;
        this.list = dataFileList = new List<DataFile>();
      }
      this.list.Add(item);
    }

    public void Add(IEnumerable<DataFile> content)
    {
      if (this.list == null)
      {
        List<DataFile> dataFileList;
        this.list = dataFileList = new List<DataFile>();
      }
      this.list.AddRange(content);
    }

    public void Remove(IEnumerable<string> itemNames)
    {
      foreach (string itemName in itemNames)
        this.Remove(itemName);
    }

    public void Remove(string itemName)
    {
      Debug.Log((object) string.Format("Removed [{0}] instances of [{1}]", (object) this.list.RemoveAll((Predicate<DataFile>) (a => a.name == itemName)), (object) itemName));
    }

    public void PullOut(IEnumerable<DataFile> items)
    {
      this.CheckPopulate();
      foreach (DataFile dataFile in items)
        this.current.Remove(dataFile);
    }

    public void PullOut(DataFile item)
    {
      this.CheckPopulate();
      this.current.Remove(item);
    }

    public DataFile Pull()
    {
      this.CheckPopulate();
      DataFile dataFile = this.current[0];
      this.current.RemoveAt(0);
      return dataFile;
    }

    public DataFile[] Pull(int itemCount, bool allowDuplicates = false)
    {
      List<DataFile> dataFileList = new List<DataFile>();
      while (dataFileList.Count < itemCount)
      {
        this.CheckPopulate();
        for (int index = 0; index < this.current.Count; ++index)
        {
          DataFile dataFile = this.current[index];
          if (allowDuplicates || !dataFileList.Contains(dataFile))
          {
            dataFileList.Add(dataFile);
            this.current.RemoveAt(index);
            break;
          }
        }
      }
      return dataFileList.ToArray();
    }

    public DataFile[] Pull(int itemCount, bool allowDuplicates, Predicate<DataFile> match)
    {
      List<DataFile> dataFileList = new List<DataFile>();
      while (dataFileList.Count < itemCount)
      {
        this.CheckPopulate();
        List<DataFile> all = this.current.FindAll(match);
        if (all.Count <= 0)
        {
          this.Populate();
          all = this.current.FindAll(match);
          if (all.Count <= 0)
            break;
        }
        foreach (DataFile dataFile in all)
        {
          if (allowDuplicates || !dataFileList.Contains(dataFile))
          {
            dataFileList.Add(dataFile);
            this.current.RemoveAt(this.current.IndexOf(dataFile));
            if (dataFileList.Count >= itemCount)
              break;
          }
        }
      }
      return dataFileList.ToArray();
    }

    public DataFile[] GetFromOriginalList(int itemCount, bool allowDuplicates)
    {
      List<DataFile> dataFileList = new List<DataFile>();
      while (dataFileList.Count < itemCount)
      {
        foreach (DataFile dataFile in (IEnumerable<DataFile>) this.list.InRandomOrder<DataFile>())
        {
          if (allowDuplicates || !dataFileList.Contains(dataFile))
          {
            dataFileList.Add(dataFile);
            if (dataFileList.Count >= itemCount)
              break;
          }
        }
      }
      return dataFileList.ToArray();
    }

    public DataFile[] GetFromOriginalList(
      int itemCount,
      bool allowDuplicates,
      Predicate<DataFile> match)
    {
      List<DataFile> dataFileList = new List<DataFile>();
      while (dataFileList.Count < itemCount)
      {
        List<DataFile> all = this.current.FindAll(match);
        if (all.Count > 0)
        {
          foreach (DataFile dataFile in (IEnumerable<DataFile>) all.InRandomOrder<DataFile>())
          {
            if (allowDuplicates || !dataFileList.Contains(dataFile))
            {
              dataFileList.Add(dataFile);
              if (dataFileList.Count >= itemCount)
                break;
            }
          }
        }
        else
          break;
      }
      return dataFileList.ToArray();
    }

    public void CheckPopulate()
    {
      if (this.current.Count > 0)
        return;
      this.Populate();
    }

    public void Populate()
    {
      this.current.AddRange((IEnumerable<DataFile>) this.list.InRandomOrder<DataFile>());
    }
  }
}
