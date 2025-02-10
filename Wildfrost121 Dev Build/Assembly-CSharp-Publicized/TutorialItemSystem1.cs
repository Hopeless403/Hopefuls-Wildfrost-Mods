// Decompiled with JetBrains decompiler
// Type: TutorialItemSystem1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class TutorialItemSystem1 : GameSystem
{
  public string[] items;

  public void OnEnable()
  {
    global::Events.OnEventStart += new UnityAction<CampaignNode, EventRoutine>(this.EventStart);
  }

  public void OnDisable()
  {
    global::Events.OnEventStart -= new UnityAction<CampaignNode, EventRoutine>(this.EventStart);
  }

  public void SetItems(string[] items) => this.items = items;

  public void EventStart(CampaignNode node, EventRoutine @event)
  {
    if (@event is ItemEventRoutine)
      node.data["cards"] = (object) new SaveCollection<string>(this.items);
    Object.Destroy((Object) this);
  }
}
