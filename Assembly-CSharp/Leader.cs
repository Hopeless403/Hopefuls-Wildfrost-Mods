// Decompiled with JetBrains decompiler
// Type: Leader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

public class Leader : ScriptableCardImage
{
  [SerializeField]
  private CharacterAvatar avatar;

  public override void AssignEvent() => this.avatar.UpdateDisplay(this.entity.data.customData.Get<CharacterData>("CharacterData"));
}
