// Decompiled with JetBrains decompiler
// Type: OptionSetter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using TMPro;
using UnityEngine;

#nullable disable
public class OptionSetter : MonoBehaviour
{
  [SerializeField]
  private GameObject[] options;
  private bool init;

  private void Start()
  {
    if (this.init)
      return;
    TMP_Dropdown component = this.GetComponent<TMP_Dropdown>();
    if (component == null)
      return;
    this.Set(component.value);
  }

  public void Set(int index)
  {
    for (int index1 = 0; index1 < this.options.Length; ++index1)
      this.options[index1].SetActive(index1 == index);
    if (this.init)
      return;
    this.init = true;
  }
}
