// Decompiled with JetBrains decompiler
// Type: Rewired.Integration.UnityUI.RewiredEventSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

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
    private bool _alwaysUpdate;

    public bool alwaysUpdate
    {
      get => this._alwaysUpdate;
      set => this._alwaysUpdate = value;
    }

    protected override void Update()
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
