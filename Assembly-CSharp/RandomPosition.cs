// Decompiled with JetBrains decompiler
// Type: RandomPosition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using UnityEngine;

public class RandomPosition : MonoBehaviour
{
  [SerializeField]
  private Vector2 x;
  [SerializeField]
  private Vector2 y;

  private void OnEnable() => this.Randomize();

  [Button(null, EButtonEnableMode.Always)]
  private void Randomize() => this.transform.localPosition = (Vector3) new Vector2(this.x.Random(), this.y.Random());
}
