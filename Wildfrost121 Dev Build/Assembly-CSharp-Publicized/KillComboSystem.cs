// Decompiled with JetBrains decompiler
// Type: KillComboSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class KillComboSystem : GameSystem
{
  public string[] colors = new string[1]{ "ffffff" };
  public string format = "<line-height=0.35><size=0.7><#{1}>x{0}\n<size=0.35>Combo\n\n<#FFD150>+{2}<sprite name=bling>";
  public int min = 2;
  public int baseGold;
  public int goldPerCombo = 5;
  public int count = 1;

  public void OnEnable()
  {
    global::Events.OnBattlePhaseStart += new UnityAction<Battle.Phase>(this.BattlePhaseStart);
    global::Events.OnBattleTurnEnd += new UnityAction<int>(this.BattleTurnEnd);
    global::Events.OnEntityKilled += new UnityAction<Entity, DeathType>(this.EntityKilled);
  }

  public void OnDisable()
  {
    global::Events.OnBattlePhaseStart -= new UnityAction<Battle.Phase>(this.BattlePhaseStart);
    global::Events.OnBattleTurnEnd -= new UnityAction<int>(this.BattleTurnEnd);
    global::Events.OnEntityKilled -= new UnityAction<Entity, DeathType>(this.EntityKilled);
  }

  public void BattlePhaseStart(Battle.Phase phase)
  {
    if (phase != Battle.Phase.Init)
      return;
    this.count = 1;
  }

  public void BattleTurnEnd(int turnNumber) => this.count = 1;

  public void EntityKilled(Entity entity, DeathType deathType)
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

  public int GetGoldAmount(int killCount)
  {
    return Mathf.RoundToInt((float) (this.baseGold + (1 + killCount - this.min) * this.goldPerCombo) * References.PlayerData.comboGoldFactor);
  }
}
