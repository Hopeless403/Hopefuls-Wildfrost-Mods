// Decompiled with JetBrains decompiler
// Type: Card
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.UI;

#nullable disable
public class Card : EntityDisplay
{
  [SerializeField]
  private Vector2 baseSize = new Vector2(740f, 1100f);
  public int frameLevel;
  [Required(null)]
  public Canvas canvas;
  [Required(null)]
  public CanvasGroup canvasGroup;
  [Required(null)]
  [BoxGroup("Text Elements")]
  public TextMeshProUGUI titleText;
  [Required(null)]
  [BoxGroup("Text Elements")]
  public TextMeshProUGUI descText;
  [Required(null)]
  [BoxGroup("Images")]
  public Image mainImage;
  [Required(null)]
  [BoxGroup("Images")]
  public Image backImage;
  [Required(null)]
  [BoxGroup("Images")]
  public Image backgroundImage;
  [Required(null)]
  [BoxGroup("Images")]
  public Image frameImage;
  [Required(null)]
  [BoxGroup("Images")]
  public CardFrameSetter frameSetter;
  [Required(null)]
  [SerializeField]
  private UINavigationItem uINavigationItem;
  [Required(null)]
  [SerializeField]
  private GameObject frontGroup;
  [Required(null)]
  [SerializeField]
  private GameObject backGroup;
  public UpgradeHolder charmHolder;
  public UpgradeHolder tokenHolder;
  public UpgradeHolder crownHolder;
  public ItemHolderPetCreator itemHolderPet;
  public LargeUIScaleUpdater[] scalers;
  [BoxGroup("Idle Animation")]
  public CardIdleAnimation imageIdleAnimator;
  [BoxGroup("Idle Animation")]
  public CardIdleAnimation backgroundIdleAnimator;
  private int currentEffectBonus;
  private float currentEffectFactor;
  private bool currentSilenced;
  public HashSet<KeywordData> keywords = new HashSet<KeywordData>();
  public HashSet<CardData> mentionedCards;
  private bool hasScriptableImage;
  [SerializeField]
  private ScriptableCardImage scriptableImage;

  public void FlipUp()
  {
    this.backGroup.SetActive(false);
    this.frontGroup.SetActive(true);
  }

  public void FlipDown()
  {
    this.backGroup.SetActive(true);
    this.frontGroup.SetActive(false);
  }

  public override Canvas GetCanvas() => this.canvas;

  public override IEnumerator UpdateData(bool doPing = false)
  {
    Card card = this;
    card.name = card.entity.data.name;
    Debug.Log((object) ("Updating Data for [" + card.name + "]"));
    card.entity.damage.current = card.entity.data.damage;
    card.entity.damage.max = card.entity.data.damage;
    card.entity.hp.current = card.entity.data.hp;
    card.entity.hp.max = card.entity.data.hp;
    card.entity.counter.current = card.entity.data.counter;
    card.entity.counter.max = card.entity.data.counter;
    card.entity.uses.current = card.entity.data.uses;
    card.entity.uses.max = card.entity.data.uses;
    card.entity.effectBonus = card.entity.data.effectBonus;
    card.entity.effectFactor = card.entity.data.effectFactor;
    card.backgroundImage.sprite = card.entity.data.backgroundSprite;
    Vector2 v = Vector2.one;
    if ((bool) (UnityEngine.Object) card.entity.data.mainSprite)
    {
      card.mainImage.sprite = card.entity.data.mainSprite;
      v = card.mainImage.sprite.rect.size / card.baseSize;
    }
    float num1 = v.Max();
    Transform transform1 = card.mainImage.transform;
    transform1.localScale = (Vector3) new Vector2(num1, num1);
    transform1.localPosition = (Vector3) new Vector2(0.0f, v.y - 1f);
    int num2 = !(bool) (UnityEngine.Object) card.entity.owner || card.entity.owner.team == 1 ? 1 : -1;
    transform1.SetScaleX((float) num2 * transform1.localScale.x);
    card.backgroundImage.transform.SetScaleX((float) num2 * card.backgroundImage.transform.localScale.x);
    if (card.hasScriptableImage)
    {
      foreach (Transform transform2 in transform1.parent)
      {
        if ((UnityEngine.Object) transform2.gameObject != (UnityEngine.Object) card.mainImage.gameObject)
          transform2.gameObject.Destroy();
      }
      if (!(bool) (UnityEngine.Object) card.entity.data.scriptableImagePrefab)
        card.mainImage.gameObject.SetActive(true);
    }
    if ((bool) (UnityEngine.Object) card.entity.data.scriptableImagePrefab)
    {
      card.hasScriptableImage = true;
      card.scriptableImage = UnityEngine.Object.Instantiate<ScriptableCardImage>(card.entity.data.scriptableImagePrefab, card.mainImage.transform.parent);
      card.scriptableImage.Assign(card.entity);
      Transform transform3 = card.scriptableImage.transform;
      transform3.localScale = (Vector3) ((Vector2) transform3.localScale * new Vector2(num1 * (float) num2, num1));
      card.scriptableImage.transform.localPosition += new Vector3(0.0f, v.y - 1f, 0.0f);
      card.mainImage.gameObject.SetActive(false);
    }
    card.SetName(card.entity.data.title);
    card.currentEffectBonus = card.entity.data.effectBonus;
    card.currentEffectFactor = card.entity.data.effectFactor;
    card.currentSilenced = card.entity.silenced;
    if (!card.entity.startingEffectsApplied)
    {
      card.entity.attackEffects = ((IEnumerable<CardData.StatusEffectStacks>) card.entity.data.attackEffects).Select<CardData.StatusEffectStacks, CardData.StatusEffectStacks>((Func<CardData.StatusEffectStacks, CardData.StatusEffectStacks>) (a => a.Clone())).ToList<CardData.StatusEffectStacks>();
      card.entity.traits.Clear();
      foreach (CardData.TraitStacks trait in card.entity.data.traits)
        card.entity.traits.Add(new Entity.TraitStacks(trait.data, trait.count));
      CardData.StatusEffectStacks[] statusEffectStacksArray = card.entity.data.startWithEffects;
      for (int index = 0; index < statusEffectStacksArray.Length; ++index)
      {
        CardData.StatusEffectStacks statusEffectStacks = statusEffectStacksArray[index];
        yield return (object) StatusEffectSystem.Apply(card.entity, (Entity) null, statusEffectStacks.data, statusEffectStacks.count, applyEvenIfZero: true);
      }
      statusEffectStacksArray = (CardData.StatusEffectStacks[]) null;
      yield return (object) card.entity.UpdateTraits();
      if (card.entity.data.injuries != null)
      {
        foreach (CardData.StatusEffectStacks injury in card.entity.data.injuries)
          yield return (object) StatusEffectSystem.Apply(card.entity, (Entity) null, injury.data, injury.count);
      }
      card.entity.startingEffectsApplied = true;
    }
    card.SetDescription();
    if ((bool) (UnityEngine.Object) card.entity.data.idleAnimationProfile)
    {
      if ((bool) (UnityEngine.Object) card.imageIdleAnimator)
        card.imageIdleAnimator.entity = card.entity;
      if ((bool) (UnityEngine.Object) card.backgroundIdleAnimator)
        card.backgroundIdleAnimator.entity = card.entity;
    }
    card.charmHolder?.Clear();
    card.tokenHolder?.Clear();
    card.crownHolder?.Clear();
    List<CardUpgradeData> upgrades = card.entity.data.upgrades;
    if (upgrades != null && upgrades.Count > 0)
    {
      foreach (CardUpgradeData upgrade in card.entity.data.upgrades)
        upgrade.Display(card.entity);
    }
    // ISSUE: reference to a compiler-generated method
    yield return (object) card.\u003C\u003En__0(doPing);
  }

  public override IEnumerator UpdateDisplay(bool doPing = true)
  {
    Card card = this;
    // ISSUE: reference to a compiler-generated method
    yield return (object) card.\u003C\u003En__1(doPing);
    bool flag = card.entity.effectBonus != card.currentEffectBonus || (double) card.entity.effectFactor != (double) card.currentEffectFactor || card.entity.silenced != card.currentSilenced;
    if (flag || card.promptUpdateDescription)
    {
      card.SetDescription();
      card.promptUpdateDescription = false;
      if (flag)
      {
        card.currentEffectBonus = card.entity.effectBonus;
        card.currentEffectFactor = card.entity.effectFactor;
        card.currentSilenced = card.entity.silenced;
        yield return (object) StatusEffectSystem.EffectBonusChangedEvent(card.entity);
      }
    }
    if (card.hasScriptableImage)
      card.scriptableImage.UpdateEvent();
  }

  public void SetName() => this.SetName(this.entity.data.title);

  public void SetName(string name)
  {
    string str = name;
    if (this.entity.data.injuries.Count > 0)
      str = "<color=red>" + str + "</color>";
    this.titleText.text = str;
  }

  public void SetDescription()
  {
    string description = Card.GetDescription(this.entity);
    this.keywords = Text.GetKeywords(description);
    this.mentionedCards = Text.GetMentionedCards(description);
    string text = Text.Process(description, this.entity.effectBonus, this.entity.effectFactor, this.entity.data.cardType.descriptionColours);
    Card.AddInjuryText(ref text, this.entity.data);
    if (text.IsNullOrWhitespace())
    {
      LocalizedString flavourKey = this.entity.data.flavourKey;
      if (flavourKey != null && !flavourKey.IsEmpty)
        text = "<i><color=#" + this.entity.data.cardType.descriptionColours.flavourColour + ">" + this.entity.data.flavourKey.GetLocalizedString();
    }
    if (text.IsNullOrWhitespace())
      this.descText.text = "";
    else
      this.descText.text = "<color=#" + this.entity.data.cardType.descriptionColours.textColour + ">" + text;
  }

  public static string GetDescription(CardData data, bool silenced = false)
  {
    string text = "";
    Card.AddAttackEffectText(ref text, (ICollection<CardData.StatusEffectStacks>) data.attackEffects, silenced);
    Card.AddCustomCardText(ref text, data, silenced);
    Card.AddPassiveEffectText(ref text, (ICollection<CardData.StatusEffectStacks>) data.startWithEffects, silenced);
    Card.AddUpgradeText(ref text, data, silenced);
    Card.AddTraitText(ref text, data, silenced);
    return text;
  }

  private static string GetDescription(Entity entity)
  {
    string text = "";
    Card.AddAttackEffectText(ref text, (ICollection<CardData.StatusEffectStacks>) entity.attackEffects, entity.silenced);
    Card.AddCustomCardText(ref text, entity.data, entity.silenced);
    Card.AddPassiveEffectText(ref text, (ICollection<StatusEffectData>) entity.statusEffects, entity.silenced);
    Card.AddUpgradeText(ref text, entity.data, entity.silenced);
    Card.AddTraitText(ref text, entity);
    return text;
  }

  private static void AddAttackEffectText(
    ref string text,
    ICollection<CardData.StatusEffectStacks> attackEffects,
    bool silenced = false)
  {
    if (attackEffects.Count <= 0)
      return;
    Dictionary<string, string> dictionary = new Dictionary<string, string>();
    foreach (CardData.StatusEffectStacks attackEffect in (IEnumerable<CardData.StatusEffectStacks>) attackEffects)
    {
      string applyFormat = attackEffect.data.GetApplyFormat();
      if (!applyFormat.IsNullOrWhitespace() && !attackEffect.data.keyword.IsNullOrWhitespace())
      {
        if (dictionary.ContainsKey(applyFormat))
          dictionary[applyFormat] += string.Format(", <{0}><keyword={1}>", (object) attackEffect.count, (object) attackEffect.data.keyword);
        else
          dictionary[applyFormat] = string.Format("<{0}><keyword={1}>", (object) attackEffect.count, (object) attackEffect.data.keyword);
      }
      else if (!attackEffect.data.textKey.IsEmpty)
        dictionary.Add(attackEffect.data.GetDesc(attackEffect.count), "");
    }
    foreach (KeyValuePair<string, string> keyValuePair in dictionary)
    {
      if (!text.IsNullOrWhitespace())
        text += "\n";
      string str = keyValuePair.Key.Replace("{0}", keyValuePair.Value);
      text += silenced ? "<s>" + str + "</s>" : str;
    }
  }

  private static void AddCustomCardText(ref string text, CardData data, bool silenced = false)
  {
    if (!data.HasCustomText)
      return;
    if (!text.IsNullOrWhitespace())
      text += "\n";
    text += data.GetCustomText(silenced);
  }

  private static void AddPassiveEffectText(
    ref string text,
    ICollection<CardData.StatusEffectStacks> passiveEffects,
    bool silenced = false)
  {
    if (passiveEffects.Count <= 0)
      return;
    foreach (CardData.StatusEffectStacks passiveEffect in (IEnumerable<CardData.StatusEffectStacks>) passiveEffects)
    {
      if (passiveEffect.data.keyword.IsNullOrWhitespace() && passiveEffect.data.HasDesc)
      {
        if (!text.IsNullOrWhitespace())
          text += "\n";
        text += passiveEffect.data.GetDesc(passiveEffect.count, silenced);
      }
    }
  }

  private static void AddPassiveEffectText(
    ref string text,
    ICollection<StatusEffectData> passiveEffects,
    bool silenced = false)
  {
    if (passiveEffects.Count <= 0)
      return;
    foreach (StatusEffectData statusEffectData in (IEnumerable<StatusEffectData>) passiveEffects.OrderBy<StatusEffectData, int>((Func<StatusEffectData, int>) (a => a.textOrder)))
    {
      if (statusEffectData.keyword.IsNullOrWhitespace() && statusEffectData.HasDesc)
      {
        if (!text.IsNullOrWhitespace())
          text += "\n";
        text += statusEffectData.GetDesc(statusEffectData.count, silenced);
      }
    }
  }

  private static void AddUpgradeText(ref string text, CardData data, bool silenced = false)
  {
  }

  private static void AddTraitText(ref string text, CardData data, bool silenced = false)
  {
    if (data.traits == null || data.traits.Count <= 0)
      return;
    int count = data.traits.Count;
    string traitSeparator = Card.GetTraitSeparator(count);
    string str = "";
    for (int index = 0; index < count; ++index)
    {
      CardData.TraitStacks trait = data.traits[index];
      str += Card.GetTraitText(trait.data, trait.count, silenced);
      if (index < count - 1)
        str += traitSeparator;
    }
    if (str.IsNullOrWhitespace())
      return;
    text = text + "\n" + str;
  }

  private static void AddTraitText(ref string text, Entity entity)
  {
    if (entity.traits == null || entity.traits.Count <= 0)
      return;
    int count = entity.traits.Count;
    string traitSeparator = Card.GetTraitSeparator(count);
    string str = "";
    for (int index = 0; index < count; ++index)
    {
      Entity.TraitStacks trait = entity.traits[index];
      str += Card.GetTraitText(trait.data, trait.count, entity.silenced || trait.silenced);
      if (index < count - 1)
        str += traitSeparator;
    }
    if (str.IsNullOrWhitespace())
      return;
    text = text + "\n" + str;
  }

  private static string GetTraitSeparator(int traitCount) => traitCount <= 2 ? "\n" : ", ";

  private static string GetTraitText(TraitData trait, int count, bool silenced = false)
  {
    string lower = trait.keyword.name.ToLower();
    return !silenced ? string.Format("<keyword={0} {1}>", (object) lower, (object) count) : string.Format("<keyword={0} {1} silenced>", (object) lower, (object) count);
  }

  private static void AddInjuryText(ref string text, CardData data)
  {
    int count = data.injuries.Count;
    if (count <= 0)
      return;
    if (!text.IsNullOrWhitespace())
      text += "\n";
    text = text + "<color=red>" + MonoBehaviourSingleton<StringReference>.instance.injured.GetLocalizedString();
    if (count > 1)
      text += string.Format(" {0}", (object) count);
    text += "</color>";
  }

  public override void OnGetFromPool()
  {
    base.OnGetFromPool();
    this.imageIdleAnimator.OnGetFromPool();
    this.backgroundIdleAnimator.OnGetFromPool();
    foreach (LargeUIScaleUpdater scaler in this.scalers)
      scaler.PromptUpdate();
  }

  public override void OnReturnToPool()
  {
    base.OnReturnToPool();
    this.FlipUp();
    this.imageIdleAnimator.OnReturnToPool();
    this.backgroundIdleAnimator.OnReturnToPool();
    if ((bool) (UnityEngine.Object) this.crownHolder)
      this.crownHolder.Clear();
    if ((bool) (UnityEngine.Object) this.charmHolder)
      this.charmHolder.Clear();
    if ((bool) (UnityEngine.Object) this.tokenHolder)
      this.tokenHolder.Clear();
    this.itemHolderPet.DestroyCurrent();
    this.canvasGroup.alpha = 1f;
    this.currentEffectBonus = 0;
    this.currentEffectFactor = 1f;
    this.currentSilenced = false;
    this.canvas.overrideSorting = false;
    if (!this.hasScriptableImage)
      return;
    foreach (Transform transform in this.mainImage.transform.parent)
    {
      if ((UnityEngine.Object) transform.gameObject != (UnityEngine.Object) this.mainImage.gameObject)
        transform.gameObject.Destroy();
    }
    this.mainImage.gameObject.SetActive(true);
    this.hasScriptableImage = false;
  }

  private void OnDrawGizmos()
  {
    Gizmos.color = Color.magenta;
    ulong num;
    if (!this.entity.data.TryGetCustomData<ulong>("splitOriginalId", out num, 0UL))
      return;
    foreach (Entity card in References.Battle.cards)
    {
      if ((long) card.data.id == (long) num)
      {
        Vector3 position = this.transform.position;
        Gizmos.DrawLine(position, card.transform.position);
        Gizmos.DrawCube(position, Vector3.one * 0.5f);
      }
    }
  }

  public enum PlayType
  {
    None,
    Play,
    Place,
  }
}
