// Decompiled with JetBrains decompiler
// Type: RunMultipleSequences
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

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
