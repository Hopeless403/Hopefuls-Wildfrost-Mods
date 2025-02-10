// Decompiled with JetBrains decompiler
// Type: ModifierIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class ModifierIcon : MonoBehaviourRect
{
  [SerializeField]
  protected LayoutElement layoutElement;
  [SerializeField]
  protected RectTransform bellHolder;
  public ImageSprite bellImage;
  [SerializeField]
  private ImageSprite dingerImage;
  [SerializeField]
  private GameObject activeIcon;
  [SerializeField]
  private GameObject inactiveIcon;
  [SerializeField]
  private TweenUI[] dingTweens;
  public bool playDingSfx = true;
  private string title;
  private string body;
  [SerializeField]
  protected GameModifierData modifier;
  protected string popUpName;
  [SerializeField]
  protected bool dontPop;
  protected bool poppedUp;
  protected Vector2 popUpOffset;

  public virtual void Set(GameModifierData modifier, Vector2 popUpOffset)
  {
    this.modifier = modifier;
    this.popUpOffset = popUpOffset;
    if ((bool) (Object) this.dingerImage)
      this.dingerImage.SetSprite(this.modifier.dingerSprite);
    if ((bool) (Object) this.bellImage)
    {
      this.bellImage.SetSprite(modifier.bellSprite);
      float y = (float) (((double) Mathf.Max(1f, this.bellImage.rectTransform.sizeDelta.y) - 1.0) * 0.5);
      this.bellHolder.anchoredPosition = new Vector2(0.0f, y);
      if ((bool) (Object) this.layoutElement)
        this.layoutElement.preferredHeight = 1f + y;
    }
    this.popUpName = modifier.name;
    this.title = modifier.titleKey.GetLocalizedString();
    this.body = modifier.descriptionKey.GetLocalizedString();
  }

  public void UpdateText()
  {
    this.title = this.modifier.titleKey.GetLocalizedString();
    this.body = this.modifier.descriptionKey.GetLocalizedString();
  }

  public void SetText(string title, string body)
  {
    this.title = title;
    this.body = body;
  }

  public void AddText(string toBody) => this.body += toBody;

  public virtual void Pop()
  {
    if (this.dontPop || this.poppedUp)
      return;
    CardPopUp.AssignTo(this.rectTransform, this.popUpOffset.x, this.popUpOffset.y);
    CardPopUp.AddPanel(this.popUpName, this.title, this.body);
    this.poppedUp = true;
  }

  public virtual void UnPop()
  {
    if (this.dontPop || !this.poppedUp)
      return;
    CardPopUp.RemovePanel(this.popUpName);
    this.poppedUp = false;
  }

  private void OnDisable() => this.UnPop();

  [Button(null, EButtonEnableMode.Always)]
  public void Ding()
  {
    foreach (TweenUI dingTween in this.dingTweens)
      dingTween.Fire();
    if (!this.playDingSfx)
      return;
    this.modifier.PlayRingSfx();
  }
}
