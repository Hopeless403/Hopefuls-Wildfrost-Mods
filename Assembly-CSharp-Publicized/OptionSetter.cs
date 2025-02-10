// Decompiled with JetBrains decompiler
// Type: OptionSetter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using TMPro;
using UnityEngine;

public class OptionSetter : MonoBehaviour
{
  [SerializeField]
  public GameObject[] options;
  public bool init;

  public void Start()
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
