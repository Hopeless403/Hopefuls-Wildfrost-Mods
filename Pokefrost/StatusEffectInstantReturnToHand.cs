// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectInstantReturnToHand
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using Deadpan.Enums.Engine.Components.Modding;
using System.Collections;
using UnityEngine;
using UnityEngine.Localization;

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectInstantReturnToHand : StatusEffectInstant
  {
    public static readonly string Key_Leader = "websiteofsites.wildfrost.pokefrost.leader";

    [PokeLocalizer]
    public static void DefineStrings()
    {
      LocalizationHelper.GetCollection("Tooltips", (LocaleIdentifier) SystemLanguage.English).SetString(StatusEffectInstantReturnToHand.Key_Leader, "Leader Cannot Be In Hand!");
    }

    public virtual void PopupText(Entity entity, string s)
    {
      NoTargetTextSystem objectOfType = Object.FindObjectOfType<NoTargetTextSystem>();
      if (!((Object) objectOfType != (Object) null))
        return;
      objectOfType.textElement.text = LocalizationHelper.GetCollection("Tooltips", (LocaleIdentifier) SystemLanguage.English).GetString(s).GetLocalizedString();
      objectOfType.PopText(entity.transform.position);
    }

    public override IEnumerator Process()
    {
      if ((Object) this.target.owner != (Object) References.Player)
      {
        yield return (object) base.Process();
      }
      else
      {
        if (this.target.data.cardType.name == "Leader")
        {
          this.PopupText(this.target, StatusEffectInstantReturnToHand.Key_Leader);
        }
        else
        {
          CardContainer hand = References.Player.handContainer;
          if ((Object) hand != (Object) null)
            yield return (object) Sequences.CardMove(this.target, new CardContainer[1]
            {
              hand
            });
          hand = (CardContainer) null;
        }
        yield return (object) base.Process();
      }
    }
  }
}
