// Decompiled with JetBrains decompiler
// Type: ModifyCardSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Localization;

public class ModifyCardSequence : MonoBehaviour
{
  [SerializeField]
  public CardContainer cardContainer;
  [SerializeField]
  public LocalizedString titleStringRef;
  [SerializeField]
  public LocalizedString continueStringRef;
  [SerializeField]
  public TweenUI endTween;
  public bool canEnd;
  public bool end;

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

  [CompilerGenerated]
  public bool \u003CRun\u003Eb__6_0() => this.end;
}
