// Decompiled with JetBrains decompiler
// Type: BuildingSequenceWithUnlocks`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using HarmonyLib;
using MonoMod.Cil;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.UI;

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

  public static event RuntimeILReferenceBag.FastDelegateInvokers.Action<T> OnStart;

  public void AddChallengeStone(ChallengeData unlock)
  {
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
