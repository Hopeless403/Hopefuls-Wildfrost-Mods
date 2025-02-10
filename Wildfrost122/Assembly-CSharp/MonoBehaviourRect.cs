// Decompiled with JetBrains decompiler
// Type: MonoBehaviourRect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
public class MonoBehaviourRect : MonoBehaviour
{
  private RectTransform _rectTransform;

  public RectTransform rectTransform
  {
    get => this._rectTransform ?? (this._rectTransform = (RectTransform) this.transform);
  }
}
