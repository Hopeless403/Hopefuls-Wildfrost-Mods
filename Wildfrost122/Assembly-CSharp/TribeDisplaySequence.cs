// Decompiled with JetBrains decompiler
// Type: TribeDisplaySequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
public class TribeDisplaySequence : MonoBehaviour
{
  [SerializeField]
  private string[] tribeNames;
  [SerializeField]
  private GameObject[] displays;

  public void Run(string className)
  {
    for (int classIndex = 0; classIndex < this.tribeNames.Length; ++classIndex)
    {
      if (this.tribeNames[classIndex] == className)
        this.Run(classIndex);
    }
  }

  public void Run(int classIndex)
  {
    for (int index = 0; index < this.displays.Length; ++index)
      this.displays[index].gameObject.SetActive(index == classIndex);
    this.gameObject.SetActive(true);
  }
}
