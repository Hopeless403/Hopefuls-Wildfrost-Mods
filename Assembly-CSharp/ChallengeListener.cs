// Decompiled with JetBrains decompiler
// Type: ChallengeListener
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using UnityEngine;

[CreateAssetMenu(fileName = "Challenge Listener", menuName = "Town/Challenge Listener")]
public class ChallengeListener : DataFile
{
  public ChallengeListener.CheckType checkType;
  public string stat;
  public bool hasKey;
  [ShowIf("hasKey")]
  public string key;
  public int target;

  public virtual bool Check(string stat, string key)
  {
    if (!(stat == this.stat))
      return false;
    return !this.hasKey || key == this.key;
  }

  public virtual bool CheckComplete(CampaignStats stats) => stats.Get(this.stat, this.hasKey ? this.key : "", 0) >= this.target;

  public virtual void Set(string challengeName, int oldValue, int newValue) => ChallengeListener.Add(challengeName, newValue - oldValue);

  protected static void Add(string challengeName, int value) => ChallengeProgressSystem.AddProgress(challengeName, value);

  public enum CheckType
  {
    MidRun,
    EndOfRun,
  }
}
