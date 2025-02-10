// Decompiled with JetBrains decompiler
// Type: BattleLogDisplayBuilder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets;

#nullable disable
public class BattleLogDisplayBuilder : MonoBehaviour
{
  [SerializeField]
  private BattleLogDisplay battleLogDisplay;
  [SerializeField]
  private Transform tempGroup;
  [SerializeField]
  private Transform finalGroup;
  [SerializeField]
  private AssetReferenceGameObject groupPrefabRef;
  [SerializeField]
  private BattleLogDisplayBuilder.EntryLookup[] entryTypes;
  private readonly Dictionary<BattleLogType, AssetReferenceGameObject> entryLookup = new Dictionary<BattleLogType, AssetReferenceGameObject>();
  private readonly List<Transform> progress = new List<Transform>();
  private BattleLogSystem battleLogSystem;
  private readonly CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
  private CancellationToken cancellationToken;

  public int entries { get; private set; }

  public bool running { get; private set; }

  private void Awake()
  {
    this.entryLookup.Clear();
    foreach (BattleLogDisplayBuilder.EntryLookup entryType in this.entryTypes)
      this.entryLookup[entryType.type] = entryType.entryPrefab;
    this.cancellationToken = this.cancellationTokenSource.Token;
  }

  private async void OnEnable()
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

  private async Task Build()
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

  private async Task Populate()
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

  private async Task CreateGroup(int groupIndex, List<BattleLog> logs)
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

  private async Task<Transform> CreateGroup(Transform parent)
  {
    return (await this.groupPrefabRef.InstantiateAsync(parent).Task).transform;
  }

  private async Task<Transform> CreateEntry(BattleLog log, Transform group)
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
  private struct EntryLookup
  {
    public BattleLogType type;
    public AssetReferenceGameObject entryPrefab;
  }
}
