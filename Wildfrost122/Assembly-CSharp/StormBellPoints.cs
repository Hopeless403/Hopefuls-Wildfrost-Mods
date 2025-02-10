// Decompiled with JetBrains decompiler
// Type: StormBellPoints
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Localization.Components;

#nullable disable
public class StormBellPoints : MonoBehaviour
{
  [SerializeField]
  private bool setOnAwake = true;
  [SerializeField]
  private LocalizeStringEvent locEvent;
  [SerializeField]
  private TMP_Text text;
  private int _points;

  public int points
  {
    get => this._points;
    set
    {
      this._points = value;
      this.locEvent.RefreshString();
    }
  }

  public void UpdateText(string text) => this.text.text = text.Format((object) this.points);

  private void Awake()
  {
    if (!this.setOnAwake)
      return;
    int num = 0;
    List<string> stringList = SaveSystem.LoadProgressData<List<string>>("activeHardModeModifiers");
    foreach (HardModeModifierData hardModeModifier in MonoBehaviourSingleton<References>.instance.hardModeModifiers)
    {
      if (stringList.Contains(hardModeModifier.name))
        num += hardModeModifier.stormPoints;
    }
    this.points = num;
  }
}
