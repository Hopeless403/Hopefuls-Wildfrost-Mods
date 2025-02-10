// Decompiled with JetBrains decompiler
// Type: CardData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Serialization;

#nullable disable
[CreateAssetMenu(fileName = "CardData", menuName = "Card Data")]
public class CardData : DataFile, ISaveable<CardSaveData>
{
  public static ulong idCurrent;
  [CompilerGenerated]
  public ulong \u003Cid\u003Ek__BackingField;
  [FormerlySerializedAs("title")]
  public string titleFallback;
  public string forceTitle;
  [TextArea]
  public string desc;
  public LocalizedString titleKey;
  public LocalizedString textKey;
  [SerializeField]
  public string textInsert;
  public string flavour;
  public LocalizedString flavourKey;
  public int value;
  public CardAnimationProfile idleAnimationProfile;
  public string[] greetMessages;
  public BloodProfile bloodProfile;
  [Header("Stats")]
  public bool hasAttack;
  public int damage;
  public bool hasHealth;
  public int hp;
  public int counter;
  [Header("Attacking")]
  public bool canBeHit;
  [Required(null)]
  public TargetMode targetMode;
  public CardData.StatusEffectStacks[] attackEffects;
  [Header("Assets")]
  [ShowAssetPreview(64, 64)]
  public Sprite mainSprite;
  [ShowAssetPreview(64, 64)]
  public Sprite backgroundSprite;
  [Header("Details")]
  public CardType cardType;
  [ShowIf("IsClunker")]
  public bool isEnemyClunker;
  public Card.PlayType playType;
  public bool needsTarget = true;
  public bool canPlayOnBoard = true;
  public bool canPlayOnHand = true;
  public bool canPlayOnFriendly = true;
  public bool canPlayOnEnemy = true;
  public bool playOnSlot;
  [ShowIf("DoesShove")]
  public bool canShoveToOtherRow = true;
  public CardData.PlayPosition defaultPlayPosition;
  public int uses;
  public CardData.StatusEffectStacks[] startWithEffects;
  public List<CardData.TraitStacks> traits;
  public TargetConstraint[] targetConstraints;
  [Space]
  [ReadOnly]
  public int effectBonus;
  [ReadOnly]
  public float effectFactor = 1f;
  public List<CardData.StatusEffectStacks> injuries;
  [ReadOnly]
  public List<CardUpgradeData> upgrades;
  [ReadOnly]
  public Vector3 random3;
  [ReadOnly]
  public int charmSlots = 3;
  [ReadOnly]
  public int tokenSlots = 1;
  [ReadOnly]
  public int crownSlots = 1;
  public ScriptableCardImage scriptableImagePrefab;
  [SerializeField]
  public CardScript[] createScripts;
  public Dictionary<string, object> customData;
  [CompilerGenerated]
  public CardData \u003Coriginal\u003Ek__BackingField;

  public ulong id
  {
    get => this.\u003Cid\u003Ek__BackingField;
    set => this.\u003Cid\u003Ek__BackingField = value;
  }

  public void SetId(ulong value)
  {
    this.id = value;
    if (this.id <= CardData.idCurrent)
      return;
    CardData.idCurrent = this.id;
  }

  public string title
  {
    get
    {
      if (!this.forceTitle.IsNullOrWhitespace())
        return this.forceTitle;
      LocalizedString titleKey = this.titleKey;
      return titleKey == null || titleKey.IsEmpty ? this.titleFallback : this.titleKey.GetLocalizedString();
    }
  }

  public bool HasCustomText => !this.textKey.IsEmpty;

  public string GetCustomText(bool silenced = false)
  {
    string customText = Text.GetEffectText(this.textKey, this.textInsert, this.attackEffects.Length != 0 ? this.attackEffects[0].count : (this.startWithEffects.Length != 0 ? this.startWithEffects[0].count : 0), silenced);
    for (int index = this.attackEffects.Length - 1; index >= 0; --index)
    {
      string oldValue = "{a" + index.ToString() + "}";
      if (customText.Contains(oldValue))
        customText = customText.Replace(oldValue, this.attackEffects[index].count.ToString());
    }
    for (int index = this.startWithEffects.Length - 1; index >= 0; --index)
    {
      string oldValue = "{s" + index.ToString() + "}";
      if (customText.Contains(oldValue))
        customText = customText.Replace(oldValue, this.startWithEffects[index].count.ToString());
    }
    return customText;
  }

  public bool IsClunker => this.cardType.name == "Clunker";

  public bool IsItem => this.playType == Card.PlayType.Play;

  public bool DoesShove
  {
    get
    {
      if (this.playType == Card.PlayType.Place)
        return true;
      return this.playType == Card.PlayType.Play && this.playOnSlot;
    }
  }

  public CardData original
  {
    get => this.\u003Coriginal\u003Ek__BackingField;
    set => this.\u003Coriginal\u003Ek__BackingField = value;
  }

  public bool HasCrown => (UnityEngine.Object) this.GetCrown() != (UnityEngine.Object) null;

  public CardUpgradeData GetCrown()
  {
    return this.upgrades.Find((Predicate<CardUpgradeData>) (a => a.type == CardUpgradeData.Type.Crown));
  }

  public void RemoveCrown() => this.GetCrown()?.UnAssign(this);

  public CardData Clone(bool runCreateScripts = true)
  {
    return this.Clone(new Vector3(UnityEngine.Random.Range(-1f, 1f), UnityEngine.Random.Range(-1f, 1f), UnityEngine.Random.Range(-1f, 1f)).normalized, CardData.idCurrent + 1UL, runCreateScripts);
  }

  public CardData Clone(Vector3 random3, bool runCreateScripts = true)
  {
    return this.Clone(random3, CardData.idCurrent + 1UL, runCreateScripts);
  }

  public CardData Clone(Vector3 random3, ulong id, bool runCreateScripts = true)
  {
    CardData cardData1 = this.InstantiateKeepName<CardData>();
    cardData1.original = this;
    cardData1.SetId(id);
    cardData1.random3 = random3;
    CardData cardData2 = cardData1;
    Dictionary<string, object> customData = this.customData;
    Dictionary<string, object> dictionary = customData != null ? customData.ToDictionary<KeyValuePair<string, object>, string, object>((Func<KeyValuePair<string, object>, string>) (entry => entry.Key), (Func<KeyValuePair<string, object>, object>) (entry => entry.Value)) : (Dictionary<string, object>) null;
    cardData2.customData = dictionary;
    if (runCreateScripts)
    {
      cardData1.RunCreateScripts();
      Events.InvokeCardDataCreated(cardData1);
    }
    return cardData1;
  }

  public void RunCreateScripts()
  {
    if (this.createScripts == null || this.createScripts.Length == 0)
      return;
    UnityEngine.Random.State state = UnityEngine.Random.state;
    int num = Mathf.Abs(Mathf.RoundToInt(this.random3.x * 100000f));
    for (int index = 0; index < this.createScripts.Length; ++index)
    {
      UnityEngine.Random.InitState(num + index);
      this.createScripts[index].Run(this);
    }
    UnityEngine.Random.state = state;
  }

  public void SetCustomData(string key, object value)
  {
    if (this.customData == null)
      this.customData = new Dictionary<string, object>();
    this.customData[key] = value;
  }

  public bool TryGetCustomData<T>(string key, out T value, T defaultValue)
  {
    object obj1;
    if (this.customData != null && this.customData.TryGetValue(key, out obj1) && obj1 is T obj2)
    {
      value = obj2;
      return true;
    }
    value = defaultValue;
    return false;
  }

  public bool IsOffensive()
  {
    bool flag = this.damage > 0 || (bool) (UnityEngine.Object) this.original && this.original.damage > 0;
    if (!flag && ((IEnumerable<CardData.StatusEffectStacks>) this.attackEffects).Any<CardData.StatusEffectStacks>((Func<CardData.StatusEffectStacks, bool>) (s => s.data.offensive)))
      flag = true;
    if (!flag && ((IEnumerable<CardData.StatusEffectStacks>) this.startWithEffects).Any<CardData.StatusEffectStacks>((Func<CardData.StatusEffectStacks, bool>) (s => s.data.makesOffensive)))
      flag = true;
    return flag;
  }

  public CardSaveData Save() => new CardSaveData(this);

  public override int GetHashCode()
  {
    return this.name.GetHashCode() ^ this.random3.GetHashCode() ^ this.id.GetHashCode();
  }

  public enum PlayPosition
  {
    None,
    Friendly,
    Enemy,
    Hand,
    FriendlyRow,
    EnemyRow,
    Field,
    FriendlySlot,
    EnemySlot,
  }

  [Serializable]
  public class StatusEffectStacks : ISaveable<StatusEffectSaveData>
  {
    public StatusEffectData data;
    public int count;

    public StatusEffectStacks()
    {
    }

    public StatusEffectStacks(StatusEffectData data, int count)
    {
      this.data = data;
      this.count = count;
    }

    public StatusEffectSaveData Save()
    {
      return new StatusEffectSaveData()
      {
        name = this.data.name,
        count = this.count
      };
    }

    public static CardData.StatusEffectStacks[] Stack(
      IEnumerable<CardData.StatusEffectStacks> currentEffects,
      IEnumerable<CardData.StatusEffectStacks> newEffects)
    {
      List<CardData.StatusEffectStacks> source = new List<CardData.StatusEffectStacks>(currentEffects);
      foreach (CardData.StatusEffectStacks newEffect in newEffects)
      {
        CardData.StatusEffectStacks e = newEffect;
        CardData.StatusEffectStacks statusEffectStacks = source.FirstOrDefault<CardData.StatusEffectStacks>((Func<CardData.StatusEffectStacks, bool>) (a => (UnityEngine.Object) a.data == (UnityEngine.Object) e.data));
        if (statusEffectStacks != null)
          statusEffectStacks.count += e.count;
        else
          source.Add(new CardData.StatusEffectStacks(e.data, e.count));
      }
      return source.ToArray();
    }

    public override string ToString()
    {
      return string.Format("{0} {1}", (object) this.count, (object) this.data.name);
    }

    public CardData.StatusEffectStacks Clone()
    {
      return new CardData.StatusEffectStacks(this.data, this.count);
    }
  }

  [Serializable]
  public class TraitStacks : ISaveable<TraitSaveData>
  {
    public TraitData data;
    public int count;

    public TraitStacks(TraitData data, int count)
    {
      this.data = data;
      this.count = count;
    }

    public TraitStacks()
    {
    }

    public TraitSaveData Save()
    {
      return new TraitSaveData()
      {
        name = this.data.name,
        count = this.count
      };
    }

    public static void Stack(
      ref List<CardData.TraitStacks> traits,
      IEnumerable<CardData.TraitStacks> newTraits)
    {
      foreach (CardData.TraitStacks newTrait in newTraits)
      {
        bool flag = false;
        foreach (CardData.TraitStacks traitStacks in traits)
        {
          if (((object) traitStacks.data).Equals((object) newTrait.data))
          {
            traitStacks.count += newTrait.count;
            flag = true;
            break;
          }
        }
        if (!flag)
          traits.Add(new CardData.TraitStacks()
          {
            data = newTrait.data,
            count = newTrait.count
          });
      }
    }

    public override string ToString()
    {
      return string.Format("{0} {1}", (object) this.data.name, (object) this.count);
    }
  }
}
