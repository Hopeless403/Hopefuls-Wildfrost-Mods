// Decompiled with JetBrains decompiler
// Type: DrawExtraWhenRedrawNotChargedSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
public class DrawExtraWhenRedrawNotChargedSystem : MonoBehaviour
{
  private const int extraDraw = 3;
  private RedrawBellSystem _redrawBellSystem;

  private RedrawBellSystem redrawBellSystem
  {
    get
    {
      return this._redrawBellSystem ?? (this._redrawBellSystem = Object.FindObjectOfType<RedrawBellSystem>());
    }
  }

  private void OnEnable()
  {
    Events.OnGetHandSize += new Events.UnityActionRef<int>(this.GetHandSize);
  }

  private void OnDisable()
  {
    Events.OnGetHandSize -= new Events.UnityActionRef<int>(this.GetHandSize);
  }

  private void GetHandSize(ref int handSize)
  {
    if (this.redrawBellSystem.IsCharged)
      return;
    handSize += 3;
  }
}
