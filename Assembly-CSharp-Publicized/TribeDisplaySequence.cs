// Decompiled with JetBrains decompiler
// Type: TribeDisplaySequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

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
