// Decompiled with JetBrains decompiler
// Type: EventRoutineCharm
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Localization;

#nullable disable
public class EventRoutineCharm : EventRoutine
{
  [SerializeField]
  private UnityEngine.Animator animator;
  [SerializeField]
  private OpenCharmBlockSequence openSequence;
  [SerializeField]
  private Transform charmBlock;
  [SerializeField]
  private LocalizedString takeKey;
  [SerializeField]
  private SfxLoop loop;
  private bool routineActive;

  public void Open(BaseEventData eventData)
  {
    if (eventData is PointerEventData pointerEventData && pointerEventData.button != PointerEventData.InputButton.Left || this.data.Get<bool>("open") || this.routineActive)
      return;
    this.StartCoroutine(this.OpenRoutine());
  }

  private IEnumerator OpenRoutine()
  {
    EventRoutineCharm eventRoutineCharm = this;
    eventRoutineCharm.node.cleared = true;
    DeckpackBlocker.Block();
    CinemaBarSystem.Clear();
    Events.InvokeScreenShake(0.25f);
    Events.InvokeScreenRumble(0.0f, 0.25f, 0.0f, 0.05f, 0.2f, 0.3f);
    SfxSystem.OneShot("event:/sfx/location/charm/rumble");
    eventRoutineCharm.data["open"] = (object) true;
    eventRoutineCharm.routineActive = true;
    yield return (object) Sequences.Wait(0.1f);
    eventRoutineCharm.animator.SetTrigger("OpenMouth");
    yield return (object) Sequences.Wait(0.35f);
    eventRoutineCharm.animator.SetTrigger("DropCharm");
    SfxSystem.OneShot("event:/sfx/location/charm/drop");
    yield return (object) Sequences.Wait(1f);
    eventRoutineCharm.animator.SetBool("Zoom", true);
    eventRoutineCharm.routineActive = false;
  }

  public override IEnumerator Populate()
  {
    // ISSUE: reference to a compiler-generated field
    int num = this.\u003C\u003E1__state;
    EventRoutineCharm eventRoutineCharm = this;
    if (num != 0)
    {
      if (num != 1)
        return false;
      // ISSUE: reference to a compiler-generated field
      this.\u003C\u003E1__state = -1;
      return false;
    }
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = -1;
    eventRoutineCharm.animator.SetBool("OpenMouth", eventRoutineCharm.data.Get<bool>("open"));
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E2__current = (object) null;
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = 1;
    return true;
  }

  public override IEnumerator Run()
  {
    EventRoutineCharm eventRoutineCharm = this;
    CinemaBarSystem.Top.SetPrompt(eventRoutineCharm.takeKey.GetLocalizedString(), "Select");
    eventRoutineCharm.loop.Play();
    // ISSUE: reference to a compiler-generated method
    yield return (object) new WaitUntil(new Func<bool>(eventRoutineCharm.\u003CRun\u003Eb__9_0));
    yield return (object) Sequences.Wait(0.15f);
    CardUpgradeData charmData = AddressableLoader.Get<CardUpgradeData>("CardUpgradeData", eventRoutineCharm.data.Get<string>("charm")).Clone();
    eventRoutineCharm.openSequence.SetCharm(charmData, eventRoutineCharm.charmBlock);
    eventRoutineCharm.openSequence.SetCharacter(eventRoutineCharm.player);
    eventRoutineCharm.charmBlock.gameObject.SetActive(false);
    yield return (object) eventRoutineCharm.openSequence.Run();
    DeckpackBlocker.Unblock();
    eventRoutineCharm.loop.Stop();
    CinemaBarSystem.Clear();
  }
}
