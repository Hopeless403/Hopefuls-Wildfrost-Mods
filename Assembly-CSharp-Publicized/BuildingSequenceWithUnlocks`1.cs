// Decompiled with JetBrains decompiler
// Type: BuildingSequenceWithUnlocks`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using HarmonyLib;
using MonoMod.Cil;
using System;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.UI;

public abstract class BuildingSequenceWithUnlocks<T> : BuildingSequence where T : BuildingSequenceWithUnlocks<T>
{
  [SerializeField]
  public GridLayoutGroup slotGrid;
  [SerializeField]
  public Transform challengeStonesParent;
  [SerializeField]
  public GameObject[] locks;
  [SerializeField]
  public CardContainer[] cardSlots;
  [SerializeField]
  public ChallengeStone[] challengeStones;

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

  public void _OnStart()
  {
    RuntimeILReferenceBag.FastDelegateInvokers.Action<T> onStart = BuildingSequenceWithUnlocks<T>.OnStart;
    if (onStart == null)
      return;
    onStart(this as T);
  }
}
