// Decompiled with JetBrains decompiler
// Type: OptionSetter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using TMPro;
using UnityEngine;

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
