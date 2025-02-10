// Decompiled with JetBrains decompiler
// Type: StormBellPoints
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Localization.Components;

#nullable disable
public class StormBellPoints : MonoBehaviour
{
  [SerializeField]
  public bool setOnAwake = true;
  [SerializeField]
  public LocalizeStringEvent locEvent;
  [SerializeField]
  public TMP_Text text;
  public int _points;

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

  public void Awake()
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
