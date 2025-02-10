// Decompiled with JetBrains decompiler
// Type: ChallengeListenerHighest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

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
