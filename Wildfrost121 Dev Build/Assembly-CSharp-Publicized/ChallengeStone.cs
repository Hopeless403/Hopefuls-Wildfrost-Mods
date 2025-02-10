// Decompiled with JetBrains decompiler
// Type: ChallengeStone
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.Localization.Components;
using UnityEngine.UI;

#nullable disable
public class ChallengeStone : MonoBehaviour
{
  public ChallengeData challenge;
  [SerializeField]
  public GameObject door;
  [SerializeField]
  public CardCharmHolder charmHolder;
  [SerializeField]
  public UINavigationItem navItem;
  [SerializeField]
  public LocalizeStringEvent title;
  [SerializeField]
  public LocalizeStringEvent text;
  public static readonly Vector2 popUpOffset = new Vector2(1f, 0.0f);
  public static readonly Vector4 raycastPadding = new Vector4(0.0f, 0.0f, 0.0f, 0.0f);

  public void OnEnable()
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
