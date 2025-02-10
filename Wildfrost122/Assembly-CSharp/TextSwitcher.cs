// Decompiled with JetBrains decompiler
// Type: TextSwitcher
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections.Generic;
using TMPro;
using UnityEngine;

#nullable disable
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
