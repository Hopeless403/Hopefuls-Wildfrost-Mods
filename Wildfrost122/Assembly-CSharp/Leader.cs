// Decompiled with JetBrains decompiler
// Type: Leader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
public class Leader : ScriptableCardImage
{
  [SerializeField]
  private CharacterAvatar avatar;

  public override void AssignEvent()
  {
    this.avatar.UpdateDisplay(this.entity.data.customData.Get<CharacterData>("CharacterData"));
  }
}
