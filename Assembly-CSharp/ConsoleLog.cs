// Decompiled with JetBrains decompiler
// Type: ConsoleLog
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using TMPro;
using UnityEngine;

public class ConsoleLog : MonoBehaviour
{
  [SerializeField]
  private TMP_Text textAsset;
  [SerializeField]
  private AnimationCurve fadeCurve;
  [SerializeField]
  private float fadeDuration = 4f;
  private float fade;

  private void OnEnable() => this.fade = 0.0f;

  private void Update()
  {
    this.fade += Time.deltaTime;
    if ((double) this.fade > (double) this.fadeDuration)
      this.gameObject.Destroy();
    else
      this.textAsset.color = this.textAsset.color.With(alpha: this.fadeCurve.Evaluate(this.fade / this.fadeDuration));
  }
}
