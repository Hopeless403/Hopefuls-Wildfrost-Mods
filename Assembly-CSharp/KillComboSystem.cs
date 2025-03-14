﻿// Decompiled with JetBrains decompiler
// Type: KillComboSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.Events;

public class KillComboSystem : GameSystem
{
  public string[] colors = new string[1]{ "ffffff" };
  public string format = "<line-height=0.35><size=0.7><#{1}>x{0}\n<size=0.35>Combo\n\n<#FFD150>+{2}<sprite name=bling>";
  public int min = 2;
  public int baseGold;
  public int goldPerCombo = 5;
  private int count = 1;

  private void OnEnable()
  {
    global::Events.OnBattlePhaseStart += new UnityAction<Battle.Phase>(this.BattlePhaseStart);
    global::Events.OnBattleTurnEnd += new UnityAction<int>(this.BattleTurnEnd);
    global::Events.OnEntityKilled += new UnityAction<Entity, DeathType>(this.EntityKilled);
  }

  private void OnDisable()
  {
    global::Events.OnBattlePhaseStart -= new UnityAction<Battle.Phase>(this.BattlePhaseStart);
    global::Events.OnBattleTurnEnd -= new UnityAction<int>(this.BattleTurnEnd);
    global::Events.OnEntityKilled -= new UnityAction<Entity, DeathType>(this.EntityKilled);
  }

  private void BattlePhaseStart(Battle.Phase phase)
  {
    if (phase != Battle.Phase.Init)
      return;
    this.count = 1;
  }

  private void BattleTurnEnd(int turnNumber) => this.count = 1;

  private void EntityKilled(Entity entity, DeathType deathType)
  {
    if (!(bool) (Object) References.Player || !((Object) entity.owner != (Object) References.Player))
      return;
    if (this.count >= this.min)
    {
      Vector3 position = entity.transform.position;
      int goldAmount = this.GetGoldAmount(this.count);
      string text = string.Format(this.format, (object) this.count, (object) this.colors[Mathf.Clamp(this.count - this.min, 0, this.colors.Length - 1)], (object) goldAmount);
      FloatingText.Create(position + Vector3.down * 0.5f, text).Animate("Spring").Fade("Smooth", 0.5f, 0.5f);
      global::Events.InvokeDropGold(goldAmount, "Combo", References.Player, position);
      SfxSystem.OneShot("event:/sfx/attack/combo_marker");
      global::Events.InvokeKillCombo(this.count);
    }
    ++this.count;
  }

  private int GetGoldAmount(int killCount) => Mathf.RoundToInt((float) (this.baseGold + (1 + killCount - this.min) * this.goldPerCombo) * References.PlayerData.comboGoldFactor);
}
