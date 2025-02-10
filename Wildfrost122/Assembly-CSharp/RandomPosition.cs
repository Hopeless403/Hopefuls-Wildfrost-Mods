// Decompiled with JetBrains decompiler
// Type: RandomPosition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using UnityEngine;

#nullable disable
public class RandomPosition : MonoBehaviour
{
  [SerializeField]
  private Vector2 x;
  [SerializeField]
  private Vector2 y;

  private void OnEnable() => this.Randomize();

  [Button(null, EButtonEnableMode.Always)]
  private void Randomize()
  {
    this.transform.localPosition = (Vector3) new Vector2(this.x.Random(), this.y.Random());
  }
}
