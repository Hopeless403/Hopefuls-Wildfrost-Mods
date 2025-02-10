// Decompiled with JetBrains decompiler
// Type: BuildingSequenceWithUnlocks`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using HarmonyLib;
using MonoMod.Cil;
using System;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
public abstract class BuildingSequenceWithUnlocks<T> : BuildingSequence where T : BuildingSequenceWithUnlocks<T>
{
  [SerializeField]
  protected GridLayoutGroup slotGrid;
  [SerializeField]
  protected Transform challengeStonesParent;
  [SerializeField]
  protected GameObject[] locks;
  [SerializeField]
  protected CardContainer[] cardSlots;
  [SerializeField]
  protected ChallengeStone[] challengeStones;
  [SerializeField]
  protected UnityEvent onSetUpComplete;

  public static event RuntimeILReferenceBag.FastDelegateInvokers.Action<T> OnStart;

  public void AddChallengeStone(ChallengeData unlock)
  {
    if (!(bool) (UnityEngine.Object) unlock || (bool) (UnityEngine.Object) this.challengeStones.ToList<ChallengeStone>().Find((Predicate<ChallengeStone>) (a => (UnityEngine.Object) a.challenge == (UnityEngine.Object) unlock)))
      return;
    GameObject gameObject = Addressables.LoadAssetAsync<GameObject>((object) "ChallengeStone").WaitForCompletion().InstantiateKeepName<GameObject>();
    gameObject.transform.parent = this.challengeStonesParent.transform;
    gameObject.transform.localPosition = gameObject.transform.localPosition.WithZ(0.0f);
    ChallengeStone componentInChildren = gameObject.GetComponentInChildren<ChallengeStone>();
    this.challengeStones = this.challengeStones.AddToArray<ChallengeStone>(componentInChildren);
    componentInChildren.challenge = unlock;
    componentInChildren.OnEnable();
  }

  public void AddSlot(ChallengeData unlock)
  {
    if (!(bool) (UnityEngine.Object) unlock || (bool) (UnityEngine.Object) this.cardSlots.ToList<CardContainer>().Find((Predicate<CardContainer>) (a => (UnityEngine.Object) a.gameObject?.GetComponentInChildren<ChallengeDisplayCreator>()?.challenge == (UnityEngine.Object) unlock)))
      return;
    GameObject gameObject = Addressables.LoadAssetAsync<GameObject>((object) "ProgressableCardStack").WaitForCompletion().InstantiateKeepName<GameObject>();
    gameObject.transform.parent = this.slotGrid.transform;
    CardStack componentInChildren1 = gameObject.GetComponentInChildren<CardStack>();
    this.cardSlots = this.cardSlots.AddToArray<CardContainer>((CardContainer) componentInChildren1);
    this.locks = this.locks.AddToArray<GameObject>(componentInChildren1.gameObject.transform.GetChild(0).gameObject);
    ChallengeDisplayCreator componentInChildren2 = gameObject.GetComponentInChildren<ChallengeDisplayCreator>();
    componentInChildren2.challenge = unlock;
    componentInChildren2.Check();
  }

  protected void _OnStart()
  {
    RuntimeILReferenceBag.FastDelegateInvokers.Action<T> onStart = BuildingSequenceWithUnlocks<T>.OnStart;
    if (onStart == null)
      return;
    onStart(this as T);
  }
}
