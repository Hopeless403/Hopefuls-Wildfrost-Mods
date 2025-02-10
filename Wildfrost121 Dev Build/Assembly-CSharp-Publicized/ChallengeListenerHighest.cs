// Decompiled with JetBrains decompiler
// Type: ChallengeListenerHighest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Challenge Listener Highest", menuName = "Town/Challenge Listener Highest")]
public class ChallengeListenerHighest : ChallengeListener
{
  public override void Set(string challengeName, int oldValue, int newValue)
  {
    if (newValue < this.target)
      return;
    ChallengeListener.Add(challengeName, 1);
  }
}
