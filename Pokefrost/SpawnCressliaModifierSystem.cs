// Decompiled with JetBrains decompiler
// Type: Pokefrost.SpawnCressliaModifierSystem
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using Deadpan.Enums.Engine.Components.Modding;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Localization;

#nullable disable
namespace Pokefrost
{
  public class SpawnCressliaModifierSystem : QuestSystem
  {
    public override string ProgressName => "Dreams";

    public static string Key_Cresselia => "websiteofsites.wildfrost.pokefrost.cresseliaHurt";

    [PokeLocalizer]
    public new static void DefineStrings()
    {
      LocalizationHelper.GetCollection("UI Text", (LocaleIdentifier) SystemLanguage.English).SetString(SpawnCressliaModifierSystem.Key_Cresselia, "Cresselia is too injured...");
    }

    public void OnEnable()
    {
      global::Events.OnBattleStart += new UnityAction(this.Spawn);
      global::Events.OnEntityKilled += new UnityAction<Entity, DeathType>(this.CheckCresseliaAlive);
      this.FindProgress();
    }

    public void OnDisable()
    {
      global::Events.OnBattleStart -= new UnityAction(this.Spawn);
      global::Events.OnEntityKilled -= new UnityAction<Entity, DeathType>(this.CheckCresseliaAlive);
    }

    private void CheckCresseliaAlive(Entity entity, DeathType deathType)
    {
      if (entity?.data?.name != "websiteofsites.wildfrost.pokefrost.quest_cresselia")
        return;
      foreach (Entity card in References.Battle.cards)
      {
        if (card?.data?.name == "websiteofsites.wildfrost.pokefrost.quest_cresselia" && card.IsAliveAndExists())
          return;
      }
      this.UpdateProgress(1);
    }

    private void Spawn()
    {
      if (this.progress != 0)
        return;
      this.StartCoroutine(this.TrueSpawn());
    }

    private IEnumerator TrueSpawn()
    {
      CardContainer slot = Battle.instance.GetRows(References.Player).RandomItem<CardContainer>();
      Debug.Log((object) "[Pokefrost] Got Slot");
      CardData data = Pokefrost.Pokefrost.instance.Get<CardData>("quest_cresselia").Clone();
      Debug.Log((object) "[Pokefrost] Got Data");
      Card card = CardManager.Get(data, References.Battle.playerCardController, References.Player, true, true);
      Debug.Log((object) "[Pokefrost] Got Card");
      card.entity.flipper.FlipDownInstant();
      card.transform.localPosition = new Vector3(-15f, 0.0f, 0.0f);
      yield return (object) card.UpdateData(false);
      slot.Add(card.entity);
      Debug.Log((object) "[Pokefrost] Added to Slot");
      slot.TweenChildPositions();
      ActionQueue.Add((PlayAction) new ActionReveal(card.entity));
      ActionQueue.Add((PlayAction) new ActionRunEnableEvent(card.entity));
      yield return (object) ActionQueue.Wait();
    }

    public override bool CheckConditions(out string failureText)
    {
      failureText = this.GetFailureText(SpawnCressliaModifierSystem.Key_Cresselia);
      Debug.Log((object) string.Format("[Pokefrost] Checking Progress... {0}", (object) this.progress));
      return this.progress == 0;
    }

    public override void QuestBattleFinish() => this.UpdateProgress(2);
  }
}
