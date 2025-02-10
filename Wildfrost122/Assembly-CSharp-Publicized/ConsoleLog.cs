// Decompiled with JetBrains decompiler
// Type: ConsoleLog
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using TMPro;
using UnityEngine;

#nullable disable
public class ConsoleLog : MonoBehaviour
{
  [SerializeField]
  public TMP_Text textAsset;
  [SerializeField]
  public AnimationCurve fadeCurve;
  [SerializeField]
  public float fadeDuration = 4f;
  public float fade;

  public void OnEnable() => this.fade = 0.0f;

  public void Update()
  {
    this.fade += Time.deltaTime;
    if ((double) this.fade > (double) this.fadeDuration)
      this.gameObject.Destroy();
    else
      this.textAsset.color = this.textAsset.color.With(alpha: this.fadeCurve.Evaluate(this.fade / this.fadeDuration));
  }
}
