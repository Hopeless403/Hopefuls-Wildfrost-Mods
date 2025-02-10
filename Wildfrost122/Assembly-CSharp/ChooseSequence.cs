// Decompiled with JetBrains decompiler
// Type: ChooseSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using Dead;
using System.Collections;
using UnityEngine;

#nullable disable
public class ChooseSequence : UISequence
{
  public RectTransform background;

  public override IEnumerator Run()
  {
    ChooseSequence chooseSequence = this;
    UIAnchors anchors = chooseSequence.GetComponent<UIAnchors>();
    foreach (UIAnchors.AnchorPoint anchorPoint in anchors.list)
    {
      anchorPoint.Deactivate();
      anchorPoint.SetUp();
    }
    chooseSequence.background.gameObject.SetActive(false);
    yield return (object) Sequences.Wait(chooseSequence.startDelay);
    chooseSequence.gameObject.SetActive(true);
    chooseSequence.background.gameObject.SetActive(true);
    chooseSequence.background.localScale = Vector3.zero;
    yield return (object) null;
    chooseSequence.background.LeanScale(Vector3.one, 1f).setEase(LeanTweenType.easeOutElastic);
    yield return (object) Sequences.Wait(0.25f);
    int c = anchors.Count;
    for (int i = 0; i < c; ++i)
    {
      anchors.Activate(i);
      yield return (object) null;
      chooseSequence.StartCoroutine(anchors.Reveal(i));
    }
    chooseSequence.StartCoroutine(anchors.UpdatePositions());
    while (!chooseSequence.promptEnd)
      yield return (object) null;
    chooseSequence.background.LeanScale(Vector3.zero, chooseSequence.tweenOutDur).setEase(LeanTweenType.easeInBack);
    for (int anchorIndex = 0; anchorIndex < c; ++anchorIndex)
    {
      float delay = PettyRandom.Range(0.0f, chooseSequence.delayBetween);
      chooseSequence.StartCoroutine(anchors.UnReveal(anchorIndex, delay));
    }
    yield return (object) Sequences.Wait(chooseSequence.tweenInDur + chooseSequence.delayBetween);
    chooseSequence.gameObject.SetActive(false);
  }
}
