// Decompiled with JetBrains decompiler
// Type: GainBlessingSequence2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using Dead;
using FMODUnity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Localization;

#nullable disable
public class GainBlessingSequence2 : UISequence
{
  [SerializeField]
  public Transform rewardGroup;
  [SerializeField]
  public LocalizedString titleKey;
  [SerializeField]
  public LocalizedString chooseKey;
  [SerializeField]
  public EventReference selectSfxEvent;
  [SerializeField]
  public UnityEngine.Animator animator;
  [SerializeField]
  public ParticleSystem buildUpPS;
  [SerializeField]
  public ParticleSystem explodePS;
  [SerializeField]
  public HandleSpinner handleSpinner;
  [SerializeField]
  public GameObject openTrigger;
  [SerializeField]
  public GameObject closedEye;
  [SerializeField]
  public GameObject openEye;
  [Header("Prefabs")]
  [SerializeField]
  public GainBlessingSequence2.SelectPrefab[] selectPrefabs;
  [Header("Positioning")]
  [SerializeField]
  public float spacing = 2.5f;
  [SerializeField]
  public float randX = 0.1f;
  [SerializeField]
  public float randY = 1f;
  [Header("SFX")]
  [SerializeField]
  public EventReference appearSfxEvent;
  [SerializeField]
  public EventReference openSfxEvent;
  public CampaignNodeTypeBoss.RewardData rewardData;
  public bool canOpen;
  public bool open;
  public int taken;

  public override IEnumerator Run()
  {
    GainBlessingSequence2 blessingSequence2 = this;
    CampaignNode characterNode = Campaign.FindCharacterNode(References.Player);
    blessingSequence2.rewardData = characterNode.data.Get<CampaignNodeTypeBoss.RewardData>("rewards");
    List<BossRewardData.Data> rewardsToCreate = blessingSequence2.rewardData.rewards;
    if (rewardsToCreate != null && rewardsToCreate.Count > 0)
    {
      SfxSystem.OneShot(blessingSequence2.appearSfxEvent);
      CinemaBarSystem.In();
      blessingSequence2.UpdateCinemaBarPrompt();
      blessingSequence2.canOpen = true;
      while (!blessingSequence2.open)
        yield return (object) null;
      blessingSequence2.UpdateCinemaBarPrompt();
      blessingSequence2.CreateRewards(rewardsToCreate);
      while (!blessingSequence2.promptEnd)
        yield return (object) null;
      CinemaBarSystem.Out();
    }
  }

  public void StartOpen()
  {
    if (this.open || !this.canOpen)
      return;
    this.canOpen = false;
    this.openTrigger.SetActive(false);
    this.StartCoroutine(this.OpenRoutine());
  }

  public IEnumerator OpenRoutine()
  {
    CinemaBarSystem.Top.RemovePrompt();
    SfxSystem.OneShot(this.openSfxEvent);
    this.closedEye.SetActive(false);
    this.openEye.SetActive(true);
    this.animator.SetBool("Open", true);
    this.handleSpinner.Spin();
    Events.InvokeScreenRumble(0.0f, 0.5f, 0.0f, 0.05f, 0.25f, 0.05f);
    yield return (object) new WaitForSeconds(0.75f);
    this.handleSpinner.Stop();
    yield return (object) new WaitForSeconds(0.25f);
    Events.InvokeScreenRumble(0.0f, 1f, 0.0f, 0.5f, 0.5f, 0.1f);
    this.buildUpPS.Play();
    yield return (object) new WaitForSeconds(1f);
    Events.InvokeScreenShake(1.5f);
    this.explodePS.Play();
    this.open = true;
    this.animator.gameObject.Destroy();
  }

  public void UpdateCinemaBarPrompt()
  {
    string str;
    if (!this.open)
      str = this.titleKey.GetLocalizedString();
    else
      str = this.chooseKey.GetLocalizedString().Format((object) (this.rewardData.canTake - this.taken));
    string text = str;
    CinemaBarSystem.Top.SetPrompt(text, "Select");
  }

  public void CreateRewards(List<BossRewardData.Data> rewardsToCreate)
  {
    UnityEngine.Random.InitState(Campaign.FindCharacterNode(References.Player).seed);
    float startX = (float) (-(double) this.spacing * (double) (rewardsToCreate.Count - 1) * 0.5);
    int ySign = PettyRandom.Choose<int>(1, -1);
    foreach (BossRewardData.Data reward in rewardsToCreate)
    {
      this.CreateReward(reward, startX, 0.0f, (float) ySign);
      startX += this.spacing;
      if ((double) PettyRandom.Range(0.0f, 1f) > 0.20000000298023224)
        ySign *= -1;
    }
  }

  public void CreateReward(BossRewardData.Data reward, float startX, float startY, float ySign)
  {
    BossRewardSelect bossRewardSelect = UnityEngine.Object.Instantiate<BossRewardSelect>(((IEnumerable<GainBlessingSequence2.SelectPrefab>) this.selectPrefabs).FirstOrDefault<GainBlessingSequence2.SelectPrefab>((Func<GainBlessingSequence2.SelectPrefab, bool>) (a => a.bossRewardType == reward.type)).prefab, this.rewardGroup);
    float x = startX + PettyRandom.Range(-this.randX, this.randX);
    float y = startY + PettyRandom.Range(0.0f, this.randY) * ySign;
    bossRewardSelect.transform.localPosition = PettyRandom.Vector3();
    LeanTween.moveLocal(bossRewardSelect.gameObject, new Vector3(x, y), PettyRandom.Range(1f, 2f)).setEaseOutElastic();
    bossRewardSelect.SetUp(reward, this);
  }

  public void Select(BossRewardData.Data reward)
  {
    if (this.promptEnd)
      return;
    reward.Select();
    if (++this.taken >= this.rewardData.canTake)
      this.promptEnd = true;
    else
      this.UpdateCinemaBarPrompt();
    SfxSystem.OneShot(this.selectSfxEvent);
  }

  [Serializable]
  public struct SelectPrefab
  {
    public BossRewardData.Type bossRewardType;
    public BossRewardSelect prefab;
  }
}
