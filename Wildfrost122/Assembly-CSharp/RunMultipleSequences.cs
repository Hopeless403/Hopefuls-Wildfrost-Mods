// Decompiled with JetBrains decompiler
// Type: RunMultipleSequences
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

#nullable disable
public class RunMultipleSequences : MonoBehaviour
{
  [SerializeField]
  private UISequence[] sequences;
  [SerializeField]
  private bool unloadSceneAfter = true;

  private IEnumerator Start()
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
