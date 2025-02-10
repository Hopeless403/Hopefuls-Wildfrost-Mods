// Decompiled with JetBrains decompiler
// Type: CampaignNodeTypeEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public abstract class CampaignNodeTypeEvent : CampaignNodeType
{
  [SerializeField]
  public AssetReferenceGameObject routinePrefabRef;

  public override IEnumerator Run(CampaignNode node)
  {
    yield return (object) Transition.To("Event");
    AsyncOperationHandle<GameObject> task = this.routinePrefabRef.InstantiateAsync(EventManager.EventRoutineHolder);
    yield return (object) new WaitUntil((Func<bool>) (() => task.IsDone));
    EventRoutine eventRoutine = task.Result.GetComponent<EventRoutine>();
    task.Result.AddComponent<AddressableReleaser>().Add((AsyncOperationHandle) task);
    Events.InvokeEventStart(node, eventRoutine);
    yield return (object) this.Populate(node);
    Events.InvokeEventPopulated(eventRoutine);
    Transition.End();
    yield return (object) eventRoutine.Run();
    yield return (object) Transition.To("MapNew");
    Transition.End();
    yield return (object) MapNew.CheckCompanionLimit();
  }

  public virtual IEnumerator Populate(CampaignNode node) => (IEnumerator) null;
}
