// Decompiled with JetBrains decompiler
// Type: CrownHolder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using Dead;
using UnityEngine;

public class CrownHolder : UpgradeHolder
{
  [SerializeField]
  private float gap = 0.3f;
  [SerializeField]
  private float angleRange = 1f;
  [SerializeField]
  private float xRange = 0.02f;
  [SerializeField]
  private float xMax = 0.1f;
  private int seed;

  private void Awake() => this.seed = PettyRandom.Range(10000, 9999999);

  public override void SetPositions()
  {
    UnityEngine.Random.State state = UnityEngine.Random.state;
    UnityEngine.Random.InitState(this.seed);
    Vector2 zero1 = Vector2.zero;
    Vector3 zero2 = Vector3.zero;
    foreach (RectTransform rectTransform in this.transform)
    {
      rectTransform.anchoredPosition = zero1;
      rectTransform.localEulerAngles = zero2;
      float num1 = UnityEngine.Random.Range(-1f, 1f);
      float num2 = zero1.x + num1 * this.xRange;
      if ((double) num2 > (double) this.xMax || (double) num2 < -(double) this.xMax)
        num1 *= -1f;
      zero1 += new Vector2(num1 * this.xRange, this.gap);
      zero2.z += num1 * this.angleRange;
    }
    UnityEngine.Random.state = state;
  }
}
