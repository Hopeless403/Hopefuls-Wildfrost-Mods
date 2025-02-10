// Decompiled with JetBrains decompiler
// Type: RunMultipleSequences
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

#nullable disable
public class RunMultipleSequences : MonoBehaviour
{
  [SerializeField]
  public UISequence[] sequences;
  [SerializeField]
  public bool unloadSceneAfter = true;

  public IEnumerator Start()
  {
    RunMultipleSequences multipleSequences = this;
    UISequence[] uiSequenceArray = multipleSequences.sequences;
    for (int index = 0; index < uiSequenceArray.Length; ++index)
    {
      UISequence sequence = uiSequenceArray[index];
      sequence.gameObject.SetActive(true);
      yield return (object) sequence.Run();
      sequence.gameObject.SetActive(false);
      sequence = (UISequence) null;
    }
    uiSequenceArray = (UISequence[]) null;
    if (multipleSequences.unloadSceneAfter)
    {
      Routine routine = new Routine(SceneManager.Unload(multipleSequences.gameObject.scene.name));
    }
  }
}
