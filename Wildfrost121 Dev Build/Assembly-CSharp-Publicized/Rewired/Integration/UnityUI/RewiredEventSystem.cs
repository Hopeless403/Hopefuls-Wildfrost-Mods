﻿// Decompiled with JetBrains decompiler
// Type: Rewired.Integration.UnityUI.RewiredEventSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.EventSystems;

#nullable disable
namespace Rewired.Integration.UnityUI
{
  [AddComponentMenu("Rewired/Rewired Event System")]
  public class RewiredEventSystem : EventSystem
  {
    [Tooltip("If enabled, the Event System will be updated every frame even if other Event Systems are enabled. Otherwise, only EventSystem.current will be updated.")]
    [SerializeField]
    public bool _alwaysUpdate;

    public bool alwaysUpdate
    {
      get => this._alwaysUpdate;
      set => this._alwaysUpdate = value;
    }

    public override void Update()
    {
      if (this.alwaysUpdate)
      {
        EventSystem current = EventSystem.current;
        if ((Object) current != (Object) this)
          EventSystem.current = (EventSystem) this;
        try
        {
          base.Update();
        }
        finally
        {
          if ((Object) current != (Object) this)
            EventSystem.current = current;
        }
      }
      else
        base.Update();
    }
  }
}
