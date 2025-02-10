// Decompiled with JetBrains decompiler
// Type: ConsoleLog
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
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
