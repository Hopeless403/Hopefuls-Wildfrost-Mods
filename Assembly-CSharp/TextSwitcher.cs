// Decompiled with JetBrains decompiler
// Type: TextSwitcher
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections.Generic;
using TMPro;
using UnityEngine;

[RequireComponent(typeof (TextMeshProUGUI))]
public class TextSwitcher : MonoBehaviour
{
  public bool useExistingTextAsFirst = true;
  public float switchTime = 1f;
  public List<string> texts;
  private int i;
  private float t;
  private TextMeshProUGUI tmp;

  private void Awake()
  {
    this.tmp = this.GetComponent<TextMeshProUGUI>();
    if (this.useExistingTextAsFirst)
      this.texts.Insert(0, this.tmp.text);
    this.t = this.switchTime;
  }

  private void Update()
  {
    for (this.t -= Time.deltaTime; (double) this.t <= 0.0; this.t += this.switchTime)
    {
      this.i = (this.i + 1) % this.texts.Count;
      this.tmp.text = this.texts[this.i];
    }
  }
}
