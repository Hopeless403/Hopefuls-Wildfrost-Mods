// Decompiled with JetBrains decompiler
// Type: IntroSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.Localization;

public class IntroSequence : MonoBehaviour
{
  [SerializeField]
  private string nextScene;
  [SerializeField]
  private UnityEngine.Animator animator;
  [SerializeField]
  private LocalizedString[] textKeys;
  private int textCurrent;
  private GameObject current;

  private void Start()
  {
    if (!GameManager.Ready)
      return;
    Transition.End();
    this.StartSequence();
  }

  private void OnDisable()
  {
    CinemaBarSystem.Clear();
    CinemaBarSystem.OutInstant();
  }

  private void StartSequence()
  {
    CinemaBarSystem.InInstant();
    CinemaBarSystem.Clear();
    this.animator.SetTrigger("Play");
  }

  private void EndSequence()
  {
    Routine routine = new Routine(Transition.To(this.nextScene));
  }

  private void NextText() => CinemaBarSystem.SetScript(this.textKeys[this.textCurrent++].GetLocalizedString(), true);
}
