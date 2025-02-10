// Decompiled with JetBrains decompiler
// Type: CardType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Localization;

#nullable disable
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
  internal LocalizedString titleKey;
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

  public override bool Equals(object other)
  {
    return other is CardType cardType ? this.name == cardType.name : base.Equals(other);
  }

  public string title => this.titleKey.GetLocalizedString();
}
