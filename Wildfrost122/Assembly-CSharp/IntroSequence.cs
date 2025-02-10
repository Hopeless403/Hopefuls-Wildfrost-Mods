// Decompiled with JetBrains decompiler
// Type: IntroSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.Localization;

#nullable disable
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

  private void NextText()
  {
    CinemaBarSystem.SetScript(this.textKeys[this.textCurrent++].GetLocalizedString(), true);
  }
}
