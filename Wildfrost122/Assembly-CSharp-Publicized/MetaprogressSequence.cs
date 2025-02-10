// Decompiled with JetBrains decompiler
// Type: MetaprogressSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class MetaprogressSequence : MonoBehaviour
{
  [SerializeField]
  public UnityEngine.Animator animator;
  [SerializeField]
  public GameObject tweener;
  [SerializeField]
  public float startDelay = 1f;
  [SerializeField]
  public float endDelay = 0.5f;
  [SerializeField]
  public Image progressImage;
  [SerializeField]
  public Vector2 randomizeProgress = new Vector2(0.9f, 1.1f);
  [SerializeField]
  public GainUnlockSequence gainUnlockSequence;
  [SerializeField]
  public ParticleSystem particleSystem;
  [CompilerGenerated]
  public bool \u003Crunning\u003Ek__BackingField;
  public float targetFillAmount;
  public const float progressPerParticle = 0.02f;

  public bool running
  {
    get => this.\u003Crunning\u003Ek__BackingField;
    set => this.\u003Crunning\u003Ek__BackingField = value;
  }

  public IEnumerator Start()
  {
    yield return (object) this.Sequence();
  }

  public IEnumerator Sequence(float? amount = null)
  {
    MetaprogressSequence metaprogressSequence = this;
    metaprogressSequence.running = true;
    yield return (object) AddressableLoader.LoadGroup("UnlockData");
    List<string> alreadyUnlocked = MetaprogressionSystem.GetUnlockedList();
    List<UnlockData> remainingUnlocks = MetaprogressionSystem.GetRemainingUnlocks(alreadyUnlocked);
    Debug.Log((object) string.Format("{0} Remaining Unlocks: {1}", (object) remainingUnlocks.Count, (object) string.Join<UnlockData>(", ", (IEnumerable<UnlockData>) remainingUnlocks)));
    MetaprogressSequence.RemoveIneligibleUnlocks((IList<UnlockData>) remainingUnlocks, (ICollection<string>) alreadyUnlocked);
    Debug.Log((object) string.Format("{0} Eligible Unlocks: {1}", (object) remainingUnlocks.Count, (object) string.Join<UnlockData>(", ", (IEnumerable<UnlockData>) remainingUnlocks)));
    Progression townProgress = SaveSystem.LoadProgressData<Progression>("townProgress", new Progression(0.0f, 1f, 0.0f));
    metaprogressSequence.progressImage.fillAmount = remainingUnlocks.Count > 0 ? townProgress.ProgressToNextUnlock() : 1f;
    if (remainingUnlocks.Count > 0)
    {
      yield return (object) new WaitForSeconds(metaprogressSequence.startDelay);
      float num1 = (float) StatsSystem.Get().Count("battlesWon");
      float num2 = 7f;
      double num3 = (!amount.HasValue ? ((double) num1 > 0.0 ? (double) Mathf.Round((float) (((double) num1 + 1.0) / (double) num2 * 3.0 * 3.0)) / 3.0 * 2.0 : 0.0) : (double) amount.GetValueOrDefault()) * (double) metaprogressSequence.randomizeProgress.Random();
      List<float> values = new List<float>();
      List<UnlockData> getUnlocks = new List<UnlockData>();
      float a = (float) num3;
      while (remainingUnlocks.Count > 0)
      {
        float b = townProgress.required - townProgress.current;
        float num4 = Mathf.Min(a, b);
        a -= num4;
        townProgress.current += num4;
        values.Add(townProgress.ProgressToNextUnlock());
        if (townProgress.RequirementMet())
        {
          townProgress.SetNextRequirement();
          UnlockData unlock = MetaprogressSequence.GetUnlock((IList<UnlockData>) remainingUnlocks);
          if (unlock != null)
          {
            getUnlocks.Add(unlock);
            alreadyUnlocked.Add(unlock.name);
            MetaprogressionSystem.SetUnlocksReady(unlock.name);
            Debug.Log((object) string.Format("Unlocking {0}", (object) unlock));
          }
        }
        else
          break;
      }
      SaveSystem.SaveProgressData<Progression>("townProgress", townProgress);
      SaveSystem.SaveProgressData<List<string>>("unlocked", alreadyUnlocked);
      Debug.Log((object) ("Progressing: " + string.Join<float>(", ", (IEnumerable<float>) values)));
      foreach (float num5 in values)
      {
        metaprogressSequence.targetFillAmount = num5;
        float progressToAdd = num5 - metaprogressSequence.progressImage.fillAmount;
        if ((double) progressToAdd > 0.0)
          Events.InvokeProgressStart(metaprogressSequence.progressImage.fillAmount);
        int particles = Mathf.CeilToInt(progressToAdd / 0.02f);
        if (particles > 0)
        {
          metaprogressSequence.animator.SetBool("Increasing", true);
          for (; particles > 0; --particles)
          {
            metaprogressSequence.particleSystem.Emit(1);
            yield return (object) new WaitForSeconds(Dead.Random.Range(0.02f, 0.03f));
          }
        }
        yield return (object) new WaitUntil(new Func<bool>(metaprogressSequence.\u003CSequence\u003Eb__15_0));
        metaprogressSequence.Fill(metaprogressSequence.targetFillAmount);
        metaprogressSequence.animator.SetBool("Increasing", false);
        if ((double) progressToAdd > 0.0)
          Events.InvokeProgressStop();
        if (getUnlocks.Count > 0)
        {
          Events.InvokeProgressDing();
          metaprogressSequence.Ping();
          getUnlocks.RemoveAt(0);
          yield return (object) new WaitForSeconds(1.5f);
          if (getUnlocks.Count > 0 || remainingUnlocks.Count > 0)
            metaprogressSequence.progressImage.fillAmount = 0.0f;
        }
      }
      getUnlocks = (List<UnlockData>) null;
    }
    yield return (object) new WaitForSeconds(metaprogressSequence.endDelay);
    metaprogressSequence.running = false;
  }

  public static UnlockData GetUnlock(IList<UnlockData> orderedList)
  {
    if (orderedList == null || orderedList.Count <= 0)
      return (UnlockData) null;
    List<int> list = new List<int>() { 0 };
    float lowPriority = orderedList[0].lowPriority;
    int count = orderedList.Count;
    for (int index = 1; index < count; ++index)
    {
      if ((double) orderedList[index].lowPriority <= (double) lowPriority)
        list.Add(index);
    }
    int index1 = list.RandomItem<int>();
    UnlockData ordered = orderedList[index1];
    orderedList.RemoveAt(index1);
    return ordered;
  }

  public static void RemoveIneligibleUnlocks(
    IList<UnlockData> remainingUnlocks,
    ICollection<string> alreadyUnlocked)
  {
    for (int index = remainingUnlocks.Count - 1; index >= 0; --index)
    {
      if (!MetaprogressionSystem.CheckUnlockRequirements(remainingUnlocks[index], alreadyUnlocked))
        remainingUnlocks.RemoveAt(index);
    }
  }

  public void OnParticleCollision(GameObject other)
  {
    if ((UnityEngine.Object) other != (UnityEngine.Object) this.particleSystem.gameObject)
      return;
    this.Fill((double) Math.Abs(this.progressImage.fillAmount - this.targetFillAmount) < 0.019999999552965164 ? this.targetFillAmount : this.progressImage.fillAmount + 0.02f);
    this.Blip();
    Events.InvokeProgressBlip();
  }

  public void Fill(float amount)
  {
    this.progressImage.fillAmount = amount;
    Events.InvokeProgressUpdate(amount);
  }

  public void Blip() => this.animator.SetTrigger(nameof (Blip));

  public void Ping() => this.animator.SetTrigger(nameof (Ping));

  [CompilerGenerated]
  public bool \u003CSequence\u003Eb__15_0()
  {
    return !(bool) (UnityEngine.Object) this.particleSystem || this.particleSystem.particleCount <= 0;
  }
}
