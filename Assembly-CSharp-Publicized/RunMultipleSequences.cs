// Decompiled with JetBrains decompiler
// Type: RunMultipleSequences
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

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
