// Decompiled with JetBrains decompiler
// Type: JournalTab
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
public class JournalTab : MonoBehaviour
{
  [SerializeField]
  public ButtonType type = ButtonType.Sub;
  [SerializeField]
  public GameObject tweenTarget;
  [SerializeField]
  public Image image;
  [SerializeField]
  public UINavigationItem nav;
  [SerializeField]
  public bool selected;
  [SerializeField]
  public GameObject selectedGroup;
  [SerializeField]
  public GameObject unselectedGroup;
  [SerializeField]
  public UnityEvent onSelect;
  [SerializeField]
  public Transform[] unselectGroups;
  [Header("Colours")]
  [SerializeField]
  public Color baseColour;
  [SerializeField]
  public Color highlightColour;
  [SerializeField]
  public Color pressColour;
  [SerializeField]
  public Color disabledColour;
  public bool _interactable = true;
  public bool hover;
  public bool press;

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

  public void OnEnable() => this.SetSelected();

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

  public void Deselect()
  {
    this.selected = false;
    this.SetSelected();
  }

  public void HoverTween()
  {
    LeanTween.cancel(this.tweenTarget);
    LeanTween.scale(this.tweenTarget, new Vector3(1.05f, 1.05f, 1f), 0.2f).setIgnoreTimeScale(true).setEaseOutBack();
  }

  public void UnHoverTween()
  {
    LeanTween.cancel(this.tweenTarget);
    LeanTween.scale(this.tweenTarget, Vector3.one, 0.05f).setIgnoreTimeScale(true);
  }

  public void PressTween()
  {
    LeanTween.cancel(this.tweenTarget);
    LeanTween.scale(this.tweenTarget, new Vector3(0.95f, 0.95f, 1f), 0.05f).setIgnoreTimeScale(true);
  }

  public void ReleaseTween()
  {
    LeanTween.cancel(this.tweenTarget);
    LeanTween.scale(this.tweenTarget, Vector3.one, 0.05f).setIgnoreTimeScale(true);
  }

  public void SetHighlighted()
  {
    if (!((Object) this.image != (Object) null))
      return;
    this.image.color = this.highlightColour;
  }

  public void SetUnHighlighted()
  {
    if (!((Object) this.image != (Object) null))
      return;
    this.image.color = this.baseColour;
  }

  public void SetPressed()
  {
    if (!((Object) this.image != (Object) null))
      return;
    this.image.color = this.pressColour;
  }

  public void SetDisabled()
  {
    if (!((Object) this.image != (Object) null))
      return;
    this.image.color = this.disabledColour;
  }

  public void SetSelected()
  {
    this.selectedGroup.SetActive(this.selected);
    this.unselectedGroup.SetActive(!this.selected);
  }
}
