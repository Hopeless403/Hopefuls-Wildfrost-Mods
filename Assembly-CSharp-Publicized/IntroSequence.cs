// Decompiled with JetBrains decompiler
// Type: IntroSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.Localization;

public class IntroSequence : MonoBehaviour
{
  [SerializeField]
  public string nextScene;
  [SerializeField]
  public UnityEngine.Animator animator;
  [SerializeField]
  public LocalizedString[] textKeys;
  public int textCurrent;
  public GameObject current;

  public void Start()
  {
    if (!GameManager.Ready)
      return;
    Transition.End();
    this.StartSequence();
  }

  public void OnDisable()
  {
    CinemaBarSystem.Clear();
    CinemaBarSystem.OutInstant();
  }

  public void StartSequence()
  {
    CinemaBarSystem.InInstant();
    CinemaBarSystem.Clear();
    this.animator.SetTrigger("Play");
  }

  public void EndSequence()
  {
    Routine routine = new Routine(Transition.To(this.nextScene));
  }

  public void NextText() => CinemaBarSystem.SetScript(this.textKeys[this.textCurrent++].GetLocalizedString(), true);
}
