// Decompiled with JetBrains decompiler
// Type: ChallengeListenerHighest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

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
