// Decompiled with JetBrains decompiler
// Type: DrawExtraWhenRedrawNotChargedSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

public class DrawExtraWhenRedrawNotChargedSystem : MonoBehaviour
{
  public const int extraDraw = 3;
  public RedrawBellSystem _redrawBellSystem;

  public RedrawBellSystem redrawBellSystem => this._redrawBellSystem ?? (this._redrawBellSystem = Object.FindObjectOfType<RedrawBellSystem>());

  public void OnEnable() => Events.OnGetHandSize += new Events.UnityActionRef<int>(this.GetHandSize);

  public void OnDisable() => Events.OnGetHandSize -= new Events.UnityActionRef<int>(this.GetHandSize);

  public void GetHandSize(ref int handSize)
  {
    if (this.redrawBellSystem.IsCharged)
      return;
    handSize += 3;
  }
}
