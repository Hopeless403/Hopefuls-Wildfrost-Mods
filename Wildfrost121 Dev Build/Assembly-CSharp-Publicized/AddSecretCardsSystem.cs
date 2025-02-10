// Decompiled with JetBrains decompiler
// Type: AddSecretCardsSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class AddSecretCardsSystem : GameSystem
{
  [SerializeField]
  public GameModifierData[] requiredModifiers;
  [SerializeField]
  public string[] cardsToAdd;
  [SerializeField]
  public string[] possibleNodeTypes;
  [SerializeField]
  public int[] tiers = new int[2]{ 2, 4 };

  public bool HasRequiredModifiers()
  {
    return Campaign.Data.GameMode.mainGameMode && StormBellManager.TrueFinalBossPointThresholdReached();
  }

  public void OnEnable()
  {
    global::Events.OnCampaignGenerated += new global::Events.AsyncAction(this.Add);
    global::Events.OnEntityEnterBackpack += new UnityAction<Entity>(this.EntityEnterBackpack);
    if (Campaign.Data.Modifiers != null && this.HasRequiredModifiers())
      return;
    this.enabled = false;
  }

  public void OnDisable()
  {
    global::Events.OnCampaignGenerated -= new global::Events.AsyncAction(this.Add);
    global::Events.OnEntityEnterBackpack -= new UnityAction<Entity>(this.EntityEnterBackpack);
  }

  public async Task Add()
  {
    HashSet<CampaignNode> source = new HashSet<CampaignNode>();
    foreach (CampaignNode node in References.Campaign.nodes)
    {
      if (this.tiers.Contains<int>(node.tier) && this.possibleNodeTypes.Contains<string>(node.type.name))
        source.Add(node);
    }
    if (source.Count < this.cardsToAdd.Length)
      return;
    List<CampaignNode> list = source.InRandomOrder<CampaignNode>().OrderByDescending<CampaignNode, int>(new Func<CampaignNode, int>(AddSecretCardsSystem.OrderNodesBySingular)).ToList<CampaignNode>();
    foreach (string cardName in this.cardsToAdd)
    {
      CampaignNode node = list[0];
      list.RemoveAt(0);
      AddSecretCardsSystem.AddCardToNode(node, cardName);
      list.RemoveAll((Predicate<CampaignNode>) (a => a.tier == node.tier));
    }
  }

  public static int OrderNodesBySingular(CampaignNode a)
  {
    if (a.dataLinkedTo == -1)
    {
      List<int> linkedToThis = a.linkedToThis;
      if ((linkedToThis == null || linkedToThis.Count <= 0) && (a.connections.Count > 1 || a.connectedTo > 1))
        return 1;
    }
    return -1;
  }

  public void EntityEnterBackpack(Entity entity)
  {
    if (!((IEnumerable<string>) this.cardsToAdd).Any<string>((Func<string, bool>) (a => entity.name == a)))
      return;
    Campaign.FindCharacterNode(References.Player).glow = false;
  }

  public static void AddCardToNode(CampaignNode node, string cardName)
  {
    node.glow = true;
    switch (node.type)
    {
      case CampaignNodeTypeItem _:
      case CampaignNodeTypeCurseItems _:
        SaveCollection<string> saveCollection = node.data.Get<SaveCollection<string>>("cards");
        bool flag = false;
        foreach (int index in (IEnumerable<int>) ((IList<string>) saveCollection.collection).GetIndices<string>().InRandomOrder<int>())
        {
          if (!node.data.ContainsKey(string.Format("upgrades{0}", (object) index)))
          {
            saveCollection[index] = cardName;
            flag = true;
            break;
          }
        }
        if (flag)
          break;
        int index1 = UnityEngine.Random.Range(0, saveCollection.Count - 1);
        saveCollection[index1] = cardName;
        node.data.Remove(string.Format("upgrades{0}", (object) index1));
        break;
      case CampaignNodeTypeShop _:
        ShopRoutine.Data data1 = node.data.Get<ShopRoutine.Data>("shopData");
        float priceFactor1 = UnityEngine.Random.Range(0.8f, 1.2f);
        CardData cardData1 = AddressableLoader.Get<CardData>("CardData", cardName);
        using (IEnumerator<int> enumerator = data1.items.GetIndices<ShopRoutine.Item>().InRandomOrder<int>().GetEnumerator())
        {
          while (enumerator.MoveNext())
          {
            int current = enumerator.Current;
            if (data1.items[current].category == "Items" && (data1.upgrades == null || data1.upgrades.Count <= current || data1.upgrades[current] == null || data1.upgrades[current].Length == 0))
            {
              float priceFactor2 = data1.items[current].priceFactor;
              data1.items[current] = new ShopRoutine.Item("Items", cardData1, 0, priceFactor1)
              {
                priceFactor = priceFactor2
              };
              break;
            }
          }
          break;
        }
      case CampaignNodeTypeCharmShop _:
        EventRoutineCharmShop.Data data2 = node.data.Get<EventRoutineCharmShop.Data>("data");
        float num = UnityEngine.Random.Range(0.8f, 1.2f);
        CardData cardData2 = AddressableLoader.Get<CardData>("CardData", cardName);
        data2.cards[data2.cards.RandomIndex<EventRoutineCharmShop.UpgradedCard>()] = new EventRoutineCharmShop.UpgradedCard()
        {
          cardDataName = cardName,
          upgradeNames = Array.Empty<string>(),
          price = Mathf.RoundToInt((float) cardData2.value * num),
          priceFactor = 1f,
          purchased = false
        };
        break;
    }
  }
}
