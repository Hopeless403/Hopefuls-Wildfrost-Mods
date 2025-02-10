// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectInstantHitRedrawBell
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System.Collections;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectInstantHitRedrawBell : StatusEffectInstant
  {
    public override IEnumerator Process()
    {
      RedrawBellSystem objectOfType1 = Object.FindObjectOfType<RedrawBellSystem>();
      Debug.Log((object) "Got bell");
      if ((Object) objectOfType1 == (Object) null || (Object) objectOfType1.controller == (Object) null)
      {
        NoTargetTextSystem objectOfType2 = Object.FindObjectOfType<NoTargetTextSystem>();
        if ((Object) objectOfType2 != (Object) null)
        {
          objectOfType2.textElement.text = "No Bell To Hit!";
          objectOfType2.PopText(this.target.transform.position);
        }
        return base.Process();
      }
      int handSize = Events.GetHandSize(References.PlayerData.handSize);
      ActionRedraw action = new ActionRedraw(objectOfType1.owner, handSize);
      if (Events.CheckAction((PlayAction) action))
      {
        ActionQueue.Add((PlayAction) action);
        objectOfType1.controller.Disable();
        objectOfType1.reset = !objectOfType1.IsCharged;
        Events.InvokeRedrawBellHit(objectOfType1);
        SfxSystem.OneShot("event:/sfx/inventory/redraw_bell_use");
        objectOfType1.SetCounter(objectOfType1.counter.max);
        objectOfType1.AnimatorTrigger("Ring");
        Events.InvokeScreenShake();
        Events.InvokeUINavigationReset();
        objectOfType1.hitParticleSystem.Play();
      }
      return base.Process();
    }
  }
}
