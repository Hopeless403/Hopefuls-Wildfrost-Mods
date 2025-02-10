// Decompiled with JetBrains decompiler
// Type: DrawExtraWhenRedrawNotChargedSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
public class DrawExtraWhenRedrawNotChargedSystem : MonoBehaviour
{
  public const int extraDraw = 3;
  public RedrawBellSystem _redrawBellSystem;

  public RedrawBellSystem redrawBellSystem
  {
    get
    {
      return this._redrawBellSystem ?? (this._redrawBellSystem = Object.FindObjectOfType<RedrawBellSystem>());
    }
  }

  public void OnEnable()
  {
    Events.OnGetHandSize += new Events.UnityActionRef<int>(this.GetHandSize);
  }

  public void OnDisable()
  {
    Events.OnGetHandSize -= new Events.UnityActionRef<int>(this.GetHandSize);
  }

  public void GetHandSize(ref int handSize)
  {
    if (this.redrawBellSystem.IsCharged)
      return;
    handSize += 3;
  }
}
