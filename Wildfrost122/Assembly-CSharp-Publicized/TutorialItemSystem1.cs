// Decompiled with JetBrains decompiler
// Type: TutorialItemSystem1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
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
