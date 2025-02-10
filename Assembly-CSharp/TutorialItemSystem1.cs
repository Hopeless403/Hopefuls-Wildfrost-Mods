// Decompiled with JetBrains decompiler
// Type: TutorialItemSystem1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.Events;

public class TutorialItemSystem1 : GameSystem
{
  private string[] items;

  private void OnEnable() => global::Events.OnEventStart += new UnityAction<CampaignNode, EventRoutine>(this.EventStart);

  private void OnDisable() => global::Events.OnEventStart -= new UnityAction<CampaignNode, EventRoutine>(this.EventStart);

  public void SetItems(string[] items) => this.items = items;

  private void EventStart(CampaignNode node, EventRoutine @event)
  {
    if (@event is ItemEventRoutine)
      node.data["cards"] = (object) new SaveCollection<string>(this.items);
    Object.Destroy((Object) this);
  }
}
