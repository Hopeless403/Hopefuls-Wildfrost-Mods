// Decompiled with JetBrains decompiler
// Type: ChallengeStone
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.Localization.Components;
using UnityEngine.UI;

public class ChallengeStone : MonoBehaviour
{
  public ChallengeData challenge;
  [SerializeField]
  private GameObject door;
  [SerializeField]
  private CardCharmHolder charmHolder;
  [SerializeField]
  private UINavigationItem navItem;
  [SerializeField]
  private LocalizeStringEvent title;
  [SerializeField]
  private LocalizeStringEvent text;
  private static readonly Vector2 popUpOffset = new Vector2(1f, 0.0f);
  private static readonly Vector4 raycastPadding = new Vector4(0.0f, 0.0f, 0.0f, 0.0f);

  internal void OnEnable()
  {
    if (!(bool) (Object) this.challenge)
      return;
    this.title.StringReference = this.challenge.titleKey;
    if (this.challenge.hidden)
      return;
    this.text.StringReference = this.challenge.textKey;
  }

  public void Open(CardUpgradeData upgradeData)
  {
    this.navItem.enabled = false;
    this.door.SetActive(false);
    UpgradeDisplay upgradeDisplay = this.charmHolder.Create(upgradeData);
    Image component1 = upgradeDisplay.GetComponent<Image>();
    if (component1 != null)
      component1.raycastPadding = ChallengeStone.raycastPadding;
    CardCharmInteraction component2 = upgradeDisplay.GetComponent<CardCharmInteraction>();
    if (component2 != null)
    {
      component2.popUpOffset = ChallengeStone.popUpOffset;
      component2.canDrag = false;
    }
    if (!this.challenge.hidden)
      return;
    this.text.StringReference = this.challenge.textKey;
  }
}
