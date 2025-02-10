// Decompiled with JetBrains decompiler
// Type: DailyGenerator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
public class DailyGenerator : MonoBehaviour
{
  [SerializeField]
  private Script[] deckRandomizers;
  [SerializeField]
  private GameModifierData[] goodModifiers;
  [SerializeField]
  private GameModifierData[] badModifiers;
  [SerializeField]
  private GameModifierData[] neutralModifiers;
  [HideInInspector]
  public bool running;

  public IEnumerator Run(int seed, GameMode gameMode)
  {
    this.running = true;
    UnityEngine.Random.InitState(seed);
    Names.Reset();
    ClassData classData = gameMode.classes.RandomItem<ClassData>();
    References.PlayerData = new PlayerData(classData, classData.startingInventory.Clone());
    CardData cardData1 = AddressableLoader.Get<CardData>("CardData", MetaprogressionSystem.GetAllPets().RandomItem<string>()).Clone();
    References.PlayerData.inventory.deck.Insert(0, cardData1);
    CardData cardData2 = classData.leaders.RandomItem<CardData>().Clone();
    References.PlayerData.inventory.deck.Insert(0, cardData2);
    Campaign.Data = new CampaignData(gameMode, seed)
    {
      GameMode = gameMode,
      GameVersion = Config.data.version,
      Seed = seed
    };
    yield return (object) this.deckRandomizers.RandomItem<Script>().Run();
    int num1 = UnityEngine.Random.Range(-100, 0);
    foreach (CardData cardData3 in References.PlayerData.inventory.deck)
    {
      num1 += cardData3.value - 25;
      if (cardData3.upgrades != null)
        num1 += cardData3.upgrades.Count * 50;
    }
    Debug.Log((object) string.Format("Daily Generator → Deck Value: {0}", (object) num1));
    int num2 = 0;
    List<GameModifierData> list1 = ((IEnumerable<GameModifierData>) this.badModifiers).InRandomOrder<GameModifierData>().ToList<GameModifierData>();
    for (int index = 0; index < 2; ++index)
    {
      GameModifierData modifier = list1.FirstOrDefault<GameModifierData>((Func<GameModifierData, bool>) (a => a.visible));
      if ((bool) (UnityEngine.Object) modifier)
      {
        list1.Remove(modifier);
        ModifierSystem.AddModifier(Campaign.Data, modifier);
        num1 += modifier.value;
        Debug.Log((object) string.Format("Daily Generator → Adding [{0}] Modifier. New Deck Value: {1}", (object) modifier.name, (object) num1));
        ++num2;
      }
      else
        break;
    }
    List<GameModifierData> list2 = ((IEnumerable<GameModifierData>) this.goodModifiers).InRandomOrder<GameModifierData>().ToList<GameModifierData>();
    for (int index = 0; index < 1; ++index)
    {
      GameModifierData modifier = list2.FirstOrDefault<GameModifierData>((Func<GameModifierData, bool>) (a => a.visible));
      if ((bool) (UnityEngine.Object) modifier)
      {
        list2.Remove(modifier);
        ModifierSystem.AddModifier(Campaign.Data, modifier);
        num1 += modifier.value;
        Debug.Log((object) string.Format("Daily Generator → Adding [{0}] Modifier. New Deck Value: {1}", (object) modifier.name, (object) num1));
        ++num2;
      }
      else
        break;
    }
    while (num2 < 6 && Mathf.Abs(num1) > 20)
    {
      List<GameModifierData> source = num1 <= 0 || list1.Count <= 0 ? list2 : list1;
      if (source.Count > 0)
      {
        GameModifierData modifier = source.FirstOrDefault<GameModifierData>((Func<GameModifierData, bool>) (a => !a.visible));
        if ((bool) (UnityEngine.Object) modifier)
        {
          source.Remove(modifier);
          ModifierSystem.AddModifier(Campaign.Data, modifier);
          num1 += modifier.value;
          Debug.Log((object) string.Format("Daily Generator → Adding [{0}] Modifier. New Deck Value: {1}", (object) modifier.name, (object) num1));
          ++num2;
          if (num2 >= 3 && (double) UnityEngine.Random.Range(0.0f, 1f) < 0.5)
            break;
        }
        else
          break;
      }
      else
        break;
    }
    yield return (object) Events.InvokeCampaignInit();
    this.running = false;
  }

  public IEnumerator Test(GameMode gameMode, int days = 730)
  {
    Debug.Log((object) string.Format("Daily Generator → Testing {0} Days", (object) days));
    int dayOffset = DailyFetcher.DayOffset;
    Dictionary<GameModifierData, int> modifiers = new Dictionary<GameModifierData, int>();
    foreach (GameModifierData goodModifier in this.goodModifiers)
      modifiers[goodModifier] = 0;
    foreach (GameModifierData badModifier in this.badModifiers)
      modifiers[badModifier] = 0;
    foreach (GameModifierData neutralModifier in this.neutralModifiers)
      modifiers[neutralModifier] = 0;
    int total = 0;
    for (int i = 0; i < days; ++i)
    {
      DailyFetcher.DayOffset = dayOffset + i;
      yield return (object) DailyFetcher.FetchDateTime();
      yield return (object) this.Run(DailyFetcher.GetSeed(), gameMode);
      foreach (GameModifierData modifier in Campaign.Data.Modifiers)
      {
        modifiers[modifier]++;
        ++total;
      }
    }
    DailyFetcher.DayOffset = dayOffset;
    yield return (object) DailyFetcher.FetchDateTime();
    Debug.Log((object) "Daily Generator → Results:");
    foreach (KeyValuePair<GameModifierData, int> keyValuePair in modifiers)
      Debug.Log((object) string.Format("{0} Count: {1} ({2}%)", (object) keyValuePair.Key.name, (object) keyValuePair.Value, (object) Mathf.RoundToInt((float) ((double) keyValuePair.Value / (double) total * 100.0))));
  }
}
