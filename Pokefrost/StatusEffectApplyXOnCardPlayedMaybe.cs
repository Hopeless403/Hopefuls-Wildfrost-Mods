// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectApplyXOnCardPlayedMaybe
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using Deadpan.Enums.Engine.Components.Modding;
using UnityEngine;
using UnityEngine.Localization;

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectApplyXOnCardPlayedMaybe : StatusEffectApplyXOnCardPlayed
  {
    public static readonly string Key_FailedFlip = "websiteofsites.wildfrost.pokefrost.failedflip";

    [PokeLocalizer]
    public static void DefineStrings()
    {
      LocalizationHelper.GetCollection("Tooltips", (LocaleIdentifier) SystemLanguage.English).SetString(StatusEffectApplyXOnCardPlayedMaybe.Key_FailedFlip, "Better Luck Next Time!");
    }

    public virtual void PopupText(Entity entity, string s)
    {
      NoTargetTextSystem objectOfType = Object.FindObjectOfType<NoTargetTextSystem>();
      if (!((Object) objectOfType != (Object) null))
        return;
      objectOfType.textElement.text = LocalizationHelper.GetCollection("Tooltips", (LocaleIdentifier) SystemLanguage.English).GetString(s).GetLocalizedString();
      objectOfType.PopText(entity.transform.position);
    }

    public override bool RunCardPlayedEvent(Entity entity, Entity[] targets)
    {
      if ((Object) entity != (Object) this.target)
        return false;
      int amount = this.GetAmount(entity);
      if (amount == 0)
        return false;
      int num = Dead.Random.Range(1, 100);
      if (amount >= num)
        return base.RunCardPlayedEvent(entity, targets);
      this.PopupText(entity, StatusEffectApplyXOnCardPlayedMaybe.Key_FailedFlip);
      return false;
    }
  }
}
