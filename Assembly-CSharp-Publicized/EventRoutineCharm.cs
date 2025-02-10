// Decompiled with JetBrains decompiler
// Type: EventRoutineCharm
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Localization;

public class EventRoutineCharm : EventRoutine
{
  [SerializeField]
  public UnityEngine.Animator animator;
  [SerializeField]
  public OpenCharmBlockSequence openSequence;
  [SerializeField]
  public Transform charmBlock;
  [SerializeField]
  public LocalizedString takeKey;
  [SerializeField]
  public SfxLoop loop;
  public bool routineActive;

  public void Open(BaseEventData eventData)
  {
    if (eventData is PointerEventData pointerEventData && pointerEventData.button != PointerEventData.InputButton.Left || this.data.Get<bool>("open") || this.routineActive)
      return;
    this.StartCoroutine(this.OpenRoutine());
  }

  public IEnumerator OpenRoutine()
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

  [CompilerGenerated]
  public bool \u003CRun\u003Eb__9_0() => this.data.Get<bool>("open") && !this.routineActive;
}
