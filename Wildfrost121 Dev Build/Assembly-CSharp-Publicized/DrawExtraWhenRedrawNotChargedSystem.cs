// Decompiled with JetBrains decompiler
// Type: DrawExtraWhenRedrawNotChargedSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
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
