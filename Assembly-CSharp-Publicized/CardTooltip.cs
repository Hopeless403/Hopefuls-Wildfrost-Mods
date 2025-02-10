// Decompiled with JetBrains decompiler
// Type: CardTooltip
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.UI;

public class CardTooltip : Tooltip
{
  [Header("Card Elements")]
  [SerializeField]
  public TMP_Text titleElement;
  [SerializeField]
  public TMP_Text descElement;
  [SerializeField]
  public Image cardArt;
  [SerializeField]
  public Image textBox;
  [SerializeField]
  public Image nameTag;
  [SerializeField]
  public Transform healthIconGroup;
  [SerializeField]
  public Transform damageIconGroup;
  [SerializeField]
  public Transform counterIconGroup;
  [SerializeField]
  public Transform crownIconGroup;
  public readonly Dictionary<string, Transform> iconGroups = new Dictionary<string, Transform>();
  public HashSet<KeywordData> keywords;

  public void Awake()
  {
    if ((Object) this.healthIconGroup != (Object) null)
      this.iconGroups["health"] = this.healthIconGroup;
    if ((Object) this.damageIconGroup != (Object) null)
      this.iconGroups["damage"] = this.damageIconGroup;
    if ((Object) this.counterIconGroup != (Object) null)
      this.iconGroups["counter"] = this.counterIconGroup;
    if (!((Object) this.crownIconGroup != (Object) null))
      return;
    this.iconGroups["crown"] = this.crownIconGroup;
  }

  public void Set(CardData data)
  {
    this.healthIconGroup.DestroyAllChildren();
    this.damageIconGroup.DestroyAllChildren();
    this.counterIconGroup.DestroyAllChildren();
    this.crownIconGroup.DestroyAllChildren();
    this.cardArt.sprite = data.mainSprite;
    this.textBox.sprite = data.cardType.textBoxSprite;
    this.nameTag.sprite = data.cardType.nameTagSprite;
    this.titleElement.text = data.title;
    string description = Card.GetDescription(data);
    this.keywords = Text.GetKeywords(description);
    string str = Text.Process(description, 0, 1f, data.cardType.descriptionColours);
    if (str.IsNullOrWhitespace())
    {
      LocalizedString flavourKey = data.flavourKey;
      if (flavourKey != null && !flavourKey.IsEmpty)
      {
        string localizedString = data.flavourKey.GetLocalizedString();
        str = "<i><color=#" + data.cardType.descriptionColours.flavourColour + ">" + localizedString;
      }
    }
    this.descElement.text = str;
    if (data.hasHealth)
      this.CreateIcon("health", "health", data.hp);
    if (data.hasAttack)
      this.CreateIcon("damage", "damage", data.damage);
    if (data.counter > 0)
      this.CreateIcon("counter", "counter", data.counter);
    foreach (CardData.StatusEffectStacks startWithEffect in data.startWithEffects)
    {
      if (startWithEffect.data.visible && !startWithEffect.data.iconGroupName.IsNullOrWhitespace())
        this.CreateIcon(startWithEffect.data.type, startWithEffect.data.iconGroupName, startWithEffect.count);
    }
    this.Ping();
  }

  public void CreateIcon(string type, string iconGroupName, int value) => CardManager.NewStatusIcon(type, this.iconGroups[iconGroupName]).SetValue(new Stat(value), false);
}
