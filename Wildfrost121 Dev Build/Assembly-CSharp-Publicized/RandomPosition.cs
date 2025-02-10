// Decompiled with JetBrains decompiler
// Type: RandomPosition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using UnityEngine;

#nullable disable
public class RandomPosition : MonoBehaviour
{
  [SerializeField]
  public Vector2 x;
  [SerializeField]
  public Vector2 y;

  public void OnEnable() => this.Randomize();

  [Button(null, EButtonEnableMode.Always)]
  public void Randomize()
  {
    this.transform.localPosition = (Vector3) new Vector2(this.x.Random(), this.y.Random());
  }
}
