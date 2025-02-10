// Decompiled with JetBrains decompiler
// Type: CrownHolderShop
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.UI;

public class CrownHolderShop : MonoBehaviour
{
  [SerializeField]
  private UnityEngine.Animator animator;
  [SerializeField]
  private GameObject crown;
  [SerializeField]
  private Image crownImage;
  [SerializeField]
  private Image crownWhiteImage;
  [SerializeField]
  private Image interaction;
  [SerializeField]
  private Vector2 popUpOffset = new Vector2(0.7f, 0.25f);
  private CardUpgradeData crownData;
  private string popUpName;
  private string popUpTitle;
  private string popUpBody;
  private bool hover;
  private bool _hasCrown = true;

  public bool hasCrown
  {
    get => this._hasCrown;
    set
    {
      this._hasCrown = value;
      this.crown.SetActive(value);
      this.interaction.enabled = value;
    }
  }

  public void SetCrownData(CardUpgradeData crownData)
  {
    this.crownData = crownData;
    this.crownImage.sprite = crownData.image;
    this.crownWhiteImage.sprite = crownData.image;
    this.popUpName = crownData.name;
    this.popUpTitle = crownData.title;
    this.popUpBody = crownData.text;
  }

  public CardUpgradeData GetCrownData() => this.crownData;

  public bool CanTake() => this._hasCrown && this.enabled;

  public void Hover()
  {
    if (this.hover || !this.CanTake())
      return;
    this.hover = true;
    this.animator.SetBool(nameof (Hover), this.hover);
    CardPopUp.AssignTo(this.interaction.rectTransform, this.popUpOffset.x, this.popUpOffset.y);
    CardPopUp.AddPanel(this.popUpName, this.popUpTitle, this.popUpBody);
  }

  public void UnHover()
  {
    if (!this.hover)
      return;
    this.hover = false;
    this.animator.SetBool("Hover", this.hover);
    CardPopUp.RemovePanel(this.popUpName);
  }

  public void TakeCrown() => this.hasCrown = false;
}
