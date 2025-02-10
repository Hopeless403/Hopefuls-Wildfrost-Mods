// Decompiled with JetBrains decompiler
// Type: StormBellDifficulty
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Components;

public class StormBellDifficulty : MonoBehaviour
{
  [SerializeField]
  private bool setOnAwake = true;
  [SerializeField]
  private LocalizeStringEvent locEvent;
  [SerializeField]
  private TMP_Text text;
  [SerializeField]
  private StormBellDifficulty.Level[] levels;
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

  public void UpdateText(string text)
  {
    foreach (StormBellDifficulty.Level level in this.levels)
    {
      if (this.points >= level.threshold)
      {
        this.text.text = text.Format((object) level.name.GetLocalizedString());
        this.text.color = level.colour;
        break;
      }
    }
  }

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

  [Serializable]
  private struct Level
  {
    public int threshold;
    public LocalizedString name;
    public Color colour;
  }
}
