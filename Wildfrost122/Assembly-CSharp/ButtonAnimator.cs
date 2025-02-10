// Decompiled with JetBrains decompiler
// Type: ButtonAnimator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class ButtonAnimator : MonoBehaviour
{
  [SerializeField]
  private ButtonType type;
  [InfoBox("This component should be on a separate object to the Button object, so as not to interfere with their tweens", EInfoBoxType.Normal)]
  [SerializeField]
  [Required(null)]
  private Selectable button;
  [SerializeField]
  private UINavigationItem nav;
  private bool hover;
  private bool press;
  private LTDescr tween;
  [Header("Text Colours")]
  public TMP_Text text;
  public Color textNormalColour = Color.white;
  [SerializeField]
  private bool textCopyBase = true;
  [HideIf("textCopyBase")]
  [SerializeField]
  private Color textHighlightColour = Color.white;
  [SerializeField]
  private bool strikeTextWhenDisabled;
  [ShowIf("strikeTextWhenDisabled")]
  [SerializeField]
  private Color textDisabledColour = Color.black;
  public Image image;
  private bool baseColourSet;
  private Color baseColour;
  public Color highlightColour = new Color(1f, 1f, 1f, 0.8f);
  public Color disabledColour = new Color(0.5f, 0.5f, 0.5f, 0.75f);
  [SerializeField]
  private bool setPressColour;
  [ShowIf("setPressColour")]
  [SerializeField]
  private Color pressColour;
  [Header("Tweens")]
  public TweenUI hoverTween;
  public TweenUI unHoverTween;
  public TweenUI pressTween;
  public TweenUI releaseTween;

  public bool interactable
  {
    get => this.button.interactable;
    set
    {
      if (value)
      {
        this.UnHighlight();
        if ((bool) (Object) this.text && this.strikeTextWhenDisabled)
          this.text.fontStyle = FontStyles.Normal;
      }
      else
        this.Disable();
      this.button.interactable = value;
      if (!(bool) (Object) this.nav)
        return;
      this.nav.enabled = value;
    }
  }

  public bool IsHoveredOrPressed => this.hover || this.press;

  private void OnEnable()
  {
    this.hover = false;
    this.press = false;
    if (this.interactable)
    {
      this.UnHighlight();
      if (!((Object) this.text != (Object) null) || !this.strikeTextWhenDisabled)
        return;
      this.text.fontStyle = FontStyles.Normal;
    }
    else
      this.Disable();
  }

  private void OnDisable()
  {
    this.press = false;
    this.UnHoverInstant();
  }

  public virtual void Hover()
  {
    if (this.hover || !this.interactable)
      return;
    this.hover = true;
    if (this.press)
      return;
    this.StopCurrentAnimation();
    this.hoverTween?.Fire();
    Events.InvokeButtonHover(this.type);
    this.Highlight();
  }

  public virtual void UnHover()
  {
    if (!this.hover)
      return;
    this.hover = false;
    if (this.press)
      return;
    this.StopCurrentAnimation();
    this.unHoverTween?.Fire();
    this.UnHighlight();
  }

  public void UnHoverInstant()
  {
    if (!this.hover)
      return;
    this.hover = false;
    if (this.press)
      return;
    this.StopCurrentAnimation();
    this.transform.localScale = Vector3.one;
    this.UnHighlight();
  }

  public virtual void Press()
  {
    if (this.press || !this.interactable)
      return;
    this.press = true;
    this.StopCurrentAnimation();
    this.pressTween?.Fire();
    Events.InvokeButtonPress(this.type);
    if (this.setPressColour)
    {
      if (!((Object) this.image != (Object) null))
        return;
      this.image.color = this.pressColour;
    }
    else
      this.UnHighlight();
  }

  public virtual void Release()
  {
    if (!this.press)
      return;
    this.press = false;
    this.StopCurrentAnimation();
    if (!this.hover)
      this.releaseTween?.Fire();
    else if (this.interactable)
    {
      this.hoverTween?.Fire();
      this.Highlight();
    }
    else
      this.hover = false;
    if (!this.setPressColour || this.hover)
      return;
    this.UnHighlight();
  }

  private void StopCurrentAnimation() => LeanTween.cancel(this.gameObject);

  private void CheckSetBaseColour()
  {
    if (this.baseColourSet)
      return;
    this.baseColourSet = true;
    this.baseColour = this.image.color;
  }

  private void Highlight()
  {
    if ((Object) this.image != (Object) null)
    {
      this.CheckSetBaseColour();
      this.image.color = this.highlightColour;
    }
    if (!((Object) this.text != (Object) null))
      return;
    this.text.color = this.textCopyBase ? this.baseColour : this.textHighlightColour;
  }

  private void UnHighlight()
  {
    if ((Object) this.image != (Object) null)
    {
      this.CheckSetBaseColour();
      this.image.color = this.baseColour;
    }
    if (!((Object) this.text != (Object) null))
      return;
    this.text.color = this.textNormalColour;
  }

  private void Disable()
  {
    if (this.hover)
      this.UnHover();
    if ((Object) this.image != (Object) null)
    {
      this.CheckSetBaseColour();
      this.image.color = this.disabledColour;
    }
    if (!((Object) this.text != (Object) null))
      return;
    if (this.strikeTextWhenDisabled)
      this.text.fontStyle = FontStyles.Strikethrough;
    this.text.color = this.strikeTextWhenDisabled ? this.textDisabledColour : this.disabledColour;
  }
}
