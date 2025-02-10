// Decompiled with JetBrains decompiler
// Type: JournalTab
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class JournalTab : MonoBehaviour
{
  [SerializeField]
  private ButtonType type = ButtonType.Sub;
  [SerializeField]
  private GameObject tweenTarget;
  [SerializeField]
  private Image image;
  [SerializeField]
  private UINavigationItem nav;
  [SerializeField]
  private bool selected;
  [SerializeField]
  private GameObject selectedGroup;
  [SerializeField]
  private GameObject unselectedGroup;
  [SerializeField]
  private UnityEvent onSelect;
  [SerializeField]
  private Transform[] unselectGroups;
  [Header("Colours")]
  [SerializeField]
  private Color baseColour;
  [SerializeField]
  private Color highlightColour;
  [SerializeField]
  private Color pressColour;
  [SerializeField]
  private Color disabledColour;
  private bool _interactable = true;
  private bool hover;
  private bool press;

  public bool interactable
  {
    get => this._interactable;
    set
    {
      if (value)
        this.SetUnHighlighted();
      else
        this.SetDisabled();
      this._interactable = value;
      if (!((Object) this.nav != (Object) null))
        return;
      this.nav.enabled = value;
    }
  }

  private void OnEnable() => this.SetSelected();

  public void Hover()
  {
    if (this.hover || !this.interactable)
      return;
    this.hover = true;
    if (this.press)
      return;
    this.HoverTween();
    this.SetHighlighted();
    global::Events.InvokeButtonHover(this.type);
  }

  public void UnHover()
  {
    if (!this.hover)
      return;
    this.hover = false;
    if (this.press)
      return;
    this.UnHoverTween();
    this.SetUnHighlighted();
  }

  public void Press()
  {
    if (this.press || !this.interactable)
      return;
    this.press = true;
    this.PressTween();
    this.SetPressed();
    global::Events.InvokeButtonPress(this.type);
  }

  public void Release()
  {
    if (!this.press)
      return;
    this.press = false;
    if (this.hover)
    {
      SfxSystem.OneShot("event:/sfx/ui/journal_click");
      this.Select();
      this.SetHighlighted();
      this.HoverTween();
    }
    else
    {
      this.SetUnHighlighted();
      this.ReleaseTween();
    }
  }

  public void Select()
  {
    foreach (Transform unselectGroup in this.unselectGroups)
    {
      foreach (Component component1 in unselectGroup)
      {
        JournalTab component2 = component1.GetComponent<JournalTab>();
        if (component2 != null && component2.selected)
          component2.Deselect();
      }
    }
    this.selected = true;
    this.SetSelected();
    this.onSelect?.Invoke();
  }

  private void Deselect()
  {
    this.selected = false;
    this.SetSelected();
  }

  private void HoverTween()
  {
    LeanTween.cancel(this.tweenTarget);
    LeanTween.scale(this.tweenTarget, new Vector3(1.05f, 1.05f, 1f), 0.2f).setIgnoreTimeScale(true).setEaseOutBack();
  }

  private void UnHoverTween()
  {
    LeanTween.cancel(this.tweenTarget);
    LeanTween.scale(this.tweenTarget, Vector3.one, 0.05f).setIgnoreTimeScale(true);
  }

  private void PressTween()
  {
    LeanTween.cancel(this.tweenTarget);
    LeanTween.scale(this.tweenTarget, new Vector3(0.95f, 0.95f, 1f), 0.05f).setIgnoreTimeScale(true);
  }

  private void ReleaseTween()
  {
    LeanTween.cancel(this.tweenTarget);
    LeanTween.scale(this.tweenTarget, Vector3.one, 0.05f).setIgnoreTimeScale(true);
  }

  private void SetHighlighted()
  {
    if (!((Object) this.image != (Object) null))
      return;
    this.image.color = this.highlightColour;
  }

  private void SetUnHighlighted()
  {
    if (!((Object) this.image != (Object) null))
      return;
    this.image.color = this.baseColour;
  }

  private void SetPressed()
  {
    if (!((Object) this.image != (Object) null))
      return;
    this.image.color = this.pressColour;
  }

  private void SetDisabled()
  {
    if (!((Object) this.image != (Object) null))
      return;
    this.image.color = this.disabledColour;
  }

  private void SetSelected()
  {
    this.selectedGroup.SetActive(this.selected);
    this.unselectedGroup.SetActive(!this.selected);
  }
}
