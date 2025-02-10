// Decompiled with JetBrains decompiler
// Type: CardType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

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
  private LocalizedString titleKey;
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

  public string title => this.titleKey.GetLocalizedString();
}
