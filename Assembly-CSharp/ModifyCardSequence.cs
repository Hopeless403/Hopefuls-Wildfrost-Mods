// Decompiled with JetBrains decompiler
// Type: ModifyCardSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Localization;

public class ModifyCardSequence : MonoBehaviour
{
  [SerializeField]
  private CardContainer cardContainer;
  [SerializeField]
  private LocalizedString titleStringRef;
  [SerializeField]
  private LocalizedString continueStringRef;
  [SerializeField]
  private TweenUI endTween;
  private bool canEnd;
  private bool end;

  public IEnumerator Run(CardData cardToModify, CardScript modifyScript)
  {
    ModifyCardSequence modifyCardSequence = this;
    int hp = cardToModify.hp;
    modifyScript.Run(cardToModify);
    int healthLost = hp - cardToModify.hp;
    Events.InvokeScreenRumble(0.0f, 0.2f, 0.0f, 0.25f, 0.25f, 0.1f);
    Card card = CardManager.Get(cardToModify, (CardController) null, References.Player, false, true);
    card.entity.flipper.FlipDownInstant();
    modifyCardSequence.cardContainer.Add(card.entity);
    yield return (object) card.UpdateData(false);
    card.transform.localPosition = Vector3.down;
    card.entity.wobbler.WobbleRandom();
    modifyCardSequence.cardContainer.TweenChildPositions();
    CinemaBarSystem.In();
    CinemaBarSystem.Top.SetScript(modifyCardSequence.titleStringRef.GetLocalizedString().Format((object) cardToModify.title, (object) healthLost));
    CinemaBarSystem.Bottom.SetPrompt(modifyCardSequence.continueStringRef.GetLocalizedString(), "Select");
    yield return (object) new WaitForSeconds(0.2f);
    card.entity.flipper.FlipUp();
    modifyCardSequence.canEnd = true;
    // ISSUE: reference to a compiler-generated method
    yield return (object) new WaitUntil(new Func<bool>(modifyCardSequence.\u003CRun\u003Eb__6_0));
    CinemaBarSystem.Clear();
    if ((bool) (UnityEngine.Object) modifyCardSequence.endTween)
    {
      modifyCardSequence.endTween.Fire();
      yield return (object) new WaitForSeconds(modifyCardSequence.endTween.GetDuration());
    }
  }

  public void Continue()
  {
    if (!this.canEnd)
      return;
    this.end = true;
  }
}
