// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectInstantSummonReserve
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using Deadpan.Enums.Engine.Components.Modding;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Localization;

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectInstantSummonReserve : StatusEffectInstantSummon
  {
    public static List<CardData> reserve;
    public static int node_id = -1;
    public static readonly string Key_ReserveEmpty = "websiteofsites.wildfrost.pokefrost.reserveEmpty";

    [PokeLocalizer]
    public static void DefineStrings()
    {
      LocalizationHelper.GetCollection("Tooltips", (LocaleIdentifier) SystemLanguage.English).SetString(StatusEffectInstantSummonReserve.Key_ReserveEmpty, "No More in Reserve!");
    }

    public override void Init()
    {
      if (Campaign.FindCharacterNode(References.Player).id != StatusEffectInstantSummonReserve.node_id)
      {
        StatusEffectInstantSummonReserve.reserve = References.Player.data.inventory.reserve.Clone<CardData>();
        StatusEffectInstantSummonReserve.node_id = Campaign.FindCharacterNode(References.Player).id;
      }
      base.Init();
    }

    public UnityAction GetReserve()
    {
      CardDataList reserve = References.Player.data.inventory.reserve;
      return (UnityAction) null;
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
      Debug.Log((object) "[Pokefrost] Process Reserve");
      if (StatusEffectInstantSummonReserve.reserve.Count<CardData>() > 0)
      {
        int index = Dead.Random.Range(0, StatusEffectInstantSummonReserve.reserve.Count<CardData>() - 1);
        CardData cardData = StatusEffectInstantSummonReserve.reserve[index];
        Debug.Log((object) ("[Pokefrost] Found card " + cardData.name));
        if ((Object) cardData != (Object) null)
        {
          this.targetSummon.summonCard = cardData;
          if (this.CanSummon(out CardContainer _, out Dictionary<Entity, List<CardSlot>> _))
            StatusEffectInstantSummonReserve.reserve.RemoveAt(index);
        }
        return base.Process();
      }
      Debug.Log((object) "[Pokefrost] No Card Found");
      this.PopupText(this.target, StatusEffectInstantSummonReserve.Key_ReserveEmpty);
      return this.Remove();
    }
  }
}
