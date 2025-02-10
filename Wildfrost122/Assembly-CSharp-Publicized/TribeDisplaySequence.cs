// Decompiled with JetBrains decompiler
// Type: TribeDisplaySequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
public class TribeDisplaySequence : MonoBehaviour
{
  [SerializeField]
  public string[] tribeNames;
  [SerializeField]
  public GameObject[] displays;

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
