// Decompiled with JetBrains decompiler
// Type: ButtonAnimator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ButtonAnimator : MonoBehaviour
{
  [SerializeField]
  public ButtonType type;
  [InfoBox("This component should be on a separate object to the Button object, so as not to interfere with their tweens", EInfoBoxType.Normal)]
  [SerializeField]
  [Required(null)]
  public Selectable button;
  [SerializeField]
  public UINavigationItem nav;
  public bool hover;
  public bool press;
  public LTDescr tween;
  [Header("Text Colours")]
  public TMP_Text text;
  public Color textNormalColour = Color.white;
  [SerializeField]
  public bool textCopyBase = true;
  [HideIf("textCopyBase")]
  [SerializeField]
  public Color textHighlightColour = Color.white;
  [SerializeField]
  public bool strikeTextWhenDisabled;
  [ShowIf("strikeTextWhenDisabled")]
  [SerializeField]
  public Color textDisabledColour = Color.black;
  public Image image;
  public bool baseColourSet;
  public Color baseColour;
  public Color highlightColour = new Color(1f, 1f, 1f, 0.8f);
  public Color disabledColour = new Color(0.5f, 0.5f, 0.5f, 0.75f);
  [SerializeField]
  public bool setPressColour;
  [ShowIf("setPressColour")]
  [SerializeField]
  public Color pressColour;
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

  public void OnEnable()
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

  public void OnDisable()
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

  public void StopCurrentAnimation() => LeanTween.cancel(this.gameObject);

  public void CheckSetBaseColour()
  {
    if (this.baseColourSet)
      return;
    this.baseColourSet = true;
    this.baseColour = this.image.color;
  }

  public void Highlight()
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

  public void UnHighlight()
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

  public void Disable()
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
