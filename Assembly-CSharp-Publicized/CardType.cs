// Decompiled with JetBrains decompiler
// Type: CardType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Localization;

[CreateAssetMenu(fileName = "CardType", menuName = "Card Type")]
public class CardType : DataFile
{
  public int sortPriority;
  [ShowAssetPreview(64, 64)]
  public Sprite icon;
  public AssetReference prefabRef;
  [Header("Details")]
  public Sprite textBoxSprite;
  public Sprite nameTagSprite;
  [SerializeField]
  public LocalizedString titleKey;
  public bool canDie;
  public bool canTakeCrown;
  public bool canRecall;
  public bool canReserve;
  public bool item;
  public bool unit;
  public string tag;
  public bool miniboss;
  public bool discoverInJournal;
  [Header("Colours")]
  public Text.ColourProfileHex descriptionColours;

  public override bool Equals(object other) => other is CardType cardType ? this.name == cardType.name : base.Equals(other);

  public string title => this.titleKey.GetLocalizedString();
}
