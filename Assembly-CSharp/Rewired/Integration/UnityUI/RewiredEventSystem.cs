// Decompiled with JetBrains decompiler
// Type: Rewired.Integration.UnityUI.RewiredEventSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.EventSystems;

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
