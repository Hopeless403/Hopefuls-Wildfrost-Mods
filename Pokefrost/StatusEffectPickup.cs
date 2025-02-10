// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectPickup
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using Deadpan.Enums.Engine.Components.Modding;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace Pokefrost
{
  public class StatusEffectPickup : StatusEffectData
  {
    public string[] rewardPoolNames;
    public Func<CardData, bool> constraint;
    public int cap = 10;
    public string text = "{0} Found A Card";
    public string cappedText = "{0} Found A Fortune!";
    public static List<ulong> BlockingQueue = new List<ulong>();

    public override void Init()
    {
      global::Events.OnBattleEnd += new UnityAction(this.CheckPickup);
      base.Init();
    }

    public void OnDestroy() => global::Events.OnBattleEnd -= new UnityAction(this.CheckPickup);

    public virtual void CheckPickup()
    {
      if (!this.target.IsAliveAndExists())
        return;
      PickupRoutine.Queue((this.cap <= this.GetAmount() ? this.cappedText : this.text).Replace("{0}", this.target.data.title), Math.Min(this.cap, this.GetAmount()));
    }

    public virtual IEnumerator Run()
    {
      yield break;
    }

    protected RewardPool[] ConvertToPools()
    {
      List<RewardPool> rewardPoolList = new List<RewardPool>();
      foreach (string rewardPoolName in this.rewardPoolNames)
      {
        RewardPool rewardPool = Extensions.GetRewardPool(rewardPoolName);
        if ((UnityEngine.Object) rewardPool != (UnityEngine.Object) null)
          rewardPoolList.Add(rewardPool);
      }
      return rewardPoolList.ToArray();
    }

    protected static RewardPool[] GetPools()
    {
      List<ClassData> group = AddressableLoader.GetGroup<ClassData>("ClassData");
      ClassData classData1 = group[0];
      string name = References.Player.name;
      Debug.Log((object) ("[Pokefrost] " + name));
      foreach (ClassData classData2 in group)
      {
        if (name.ToLower().Contains(classData2.name.ToLower()))
        {
          classData1 = classData2;
          break;
        }
      }
      return ((IEnumerable<RewardPool>) classData1.rewardPools).Where<RewardPool>((Func<RewardPool, bool>) (r => (UnityEngine.Object) r != (UnityEngine.Object) null && r.type == "Items" && !r.isGeneralPool)).ToArray<RewardPool>();
    }
  }
}
