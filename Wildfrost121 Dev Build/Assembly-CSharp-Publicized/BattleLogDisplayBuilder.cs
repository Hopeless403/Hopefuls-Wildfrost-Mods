// Decompiled with JetBrains decompiler
// Type: BattleLogDisplayBuilder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets;

#nullable disable
public class BattleLogDisplayBuilder : MonoBehaviour
{
  [SerializeField]
  public BattleLogDisplay battleLogDisplay;
  [SerializeField]
  public Transform tempGroup;
  [SerializeField]
  public Transform finalGroup;
  [SerializeField]
  public AssetReferenceGameObject groupPrefabRef;
  [SerializeField]
  public BattleLogDisplayBuilder.EntryLookup[] entryTypes;
  public readonly Dictionary<BattleLogType, AssetReferenceGameObject> entryLookup = new Dictionary<BattleLogType, AssetReferenceGameObject>();
  public readonly List<Transform> progress = new List<Transform>();
  public BattleLogSystem battleLogSystem;
  public readonly CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
  public CancellationToken cancellationToken;
  [CompilerGenerated]
  public int \u003Centries\u003Ek__BackingField;
  [CompilerGenerated]
  public bool \u003Crunning\u003Ek__BackingField;

  public int entries
  {
    get => this.\u003Centries\u003Ek__BackingField;
    set => this.\u003Centries\u003Ek__BackingField = value;
  }

  public bool running
  {
    get => this.\u003Crunning\u003Ek__BackingField;
    set => this.\u003Crunning\u003Ek__BackingField = value;
  }

  public void Awake()
  {
    this.entryLookup.Clear();
    foreach (BattleLogDisplayBuilder.EntryLookup entryType in this.entryTypes)
      this.entryLookup[entryType.type] = entryType.entryPrefab;
    this.cancellationToken = this.cancellationTokenSource.Token;
  }

  public async void OnEnable()
  {
    this.battleLogSystem = UnityEngine.Object.FindObjectOfType<BattleLogSystem>();
    if (!(bool) (UnityEngine.Object) this.battleLogSystem)
    {
      this.entries = -1;
    }
    else
    {
      int num = this.entries != this.battleLogSystem.list.Count ? 1 : 0;
      this.entries = this.battleLogSystem.list.Count;
      if (num == 0)
        return;
      this.battleLogDisplay.PromptScrollToBottom();
      if (this.running)
      {
        this.cancellationTokenSource.Cancel();
        while (this.running)
          await Task.Yield();
      }
      await this.Build();
    }
  }

  public async Task Build()
  {
    this.running = true;
    this.finalGroup.DestroyAllChildren();
    await this.Populate();
    foreach (Transform transform in this.progress)
    {
      if (!this.cancellationToken.IsCancellationRequested)
        transform.SetParent(this.finalGroup);
      else
        break;
    }
    this.progress.Clear();
    this.tempGroup.DestroyAllChildren();
    this.running = false;
  }

  public async Task Populate()
  {
    if (this.cancellationToken.IsCancellationRequested)
      return;
    int num1 = 0;
    int count = this.battleLogSystem.list.Count;
    List<Task> taskList = new List<Task>();
    for (int index = 0; index < count; ++index)
    {
      if (this.cancellationToken.IsCancellationRequested)
        return;
      BattleLog battleLog = this.battleLogSystem.list[index];
      if (index == 0 || battleLog.type == BattleLogType.Turn)
      {
        int num2 = this.battleLogSystem.list.FindIndex(index + 1, (Predicate<BattleLog>) (a => a.type == BattleLogType.Turn));
        if (num2 == -1)
          num2 = count;
        List<BattleLog> range = this.battleLogSystem.list.GetRange(index, num2 - index);
        index = num2 - 1;
        if (this.cancellationToken.IsCancellationRequested)
          return;
        this.progress.Add((Transform) null);
        taskList.Add(this.CreateGroup(num1++, range));
      }
    }
    await Task.WhenAll((IEnumerable<Task>) taskList);
  }

  public async Task CreateGroup(int groupIndex, List<BattleLog> logs)
  {
    List<Task<Transform>> tasks;
    if (this.cancellationToken.IsCancellationRequested)
    {
      tasks = (List<Task<Transform>>) null;
    }
    else
    {
      Transform group = await this.CreateGroup(this.tempGroup);
      this.progress[groupIndex] = group;
      tasks = new List<Task<Transform>>();
      foreach (BattleLog log in logs)
      {
        if (this.cancellationToken.IsCancellationRequested)
        {
          tasks = (List<Task<Transform>>) null;
          return;
        }
        tasks.Add(this.CreateEntry(log, group));
      }
      Transform[] transformArray = await Task.WhenAll<Transform>((IEnumerable<Task<Transform>>) tasks);
      if (this.cancellationToken.IsCancellationRequested)
      {
        tasks = (List<Task<Transform>>) null;
      }
      else
      {
        for (int index = 0; index < tasks.Count; ++index)
        {
          Transform result = tasks[index].Result;
          if ((bool) (UnityEngine.Object) result)
            result.SetSiblingIndex(index + 1);
        }
        tasks = (List<Task<Transform>>) null;
      }
    }
  }

  public async Task<Transform> CreateGroup(Transform parent)
  {
    return (await this.groupPrefabRef.InstantiateAsync(parent).Task).transform;
  }

  public async Task<Transform> CreateEntry(BattleLog log, Transform group)
  {
    AssetReferenceGameObject referenceGameObject = this.entryLookup[log.type];
    if (this.cancellationToken.IsCancellationRequested)
      return (Transform) null;
    GameObject result = await referenceGameObject.InstantiateAsync(group).Task;
    await result.GetComponent<BattleLogEntry>().SetUp(log);
    return result.transform;
  }

  public void Cancel() => this.cancellationTokenSource.Cancel();

  [Serializable]
  public struct EntryLookup
  {
    public BattleLogType type;
    public AssetReferenceGameObject entryPrefab;
  }
}
