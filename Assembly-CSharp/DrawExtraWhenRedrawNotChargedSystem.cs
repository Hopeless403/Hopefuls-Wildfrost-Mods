// Decompiled with JetBrains decompiler
// Type: DrawExtraWhenRedrawNotChargedSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

public class DrawExtraWhenRedrawNotChargedSystem : MonoBehaviour
{
  private const int extraDraw = 3;
  private RedrawBellSystem _redrawBellSystem;

  private RedrawBellSystem redrawBellSystem => this._redrawBellSystem ?? (this._redrawBellSystem = Object.FindObjectOfType<RedrawBellSystem>());

  private void OnEnable() => Events.OnGetHandSize += new Events.UnityActionRef<int>(this.GetHandSize);

  private void OnDisable() => Events.OnGetHandSize -= new Events.UnityActionRef<int>(this.GetHandSize);

  private void GetHandSize(ref int handSize)
  {
    if (this.redrawBellSystem.IsCharged)
      return;
    handSize += 3;
  }
}
