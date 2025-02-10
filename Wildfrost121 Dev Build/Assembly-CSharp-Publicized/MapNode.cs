// Decompiled with JetBrains decompiler
// Type: MapNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using FMODUnity;
using NaughtyAttributes;
using UnityEngine;
using UnityEngine.EventSystems;

#nullable disable
public class MapNode : MonoBehaviour
{
  public MapNew map;
  public CampaignNode campaignNode;
  public MapNode[] connections;
  public int connectedTo;
  public bool interactable;
  [SerializeField]
  public Animator animator;
  [SerializeField]
  public GameObject highlight;
  [SerializeField]
  public GameObject glow;
  [SerializeField]
  public UINavigationItem uINavigationItem;
  [SerializeField]
  public MapNodeSpriteSetter spriteSetter;
  [SerializeField]
  [HideIf("HasSpriteSetter")]
  public Sprite[] spriteOptions;
  [SerializeField]
  [HideIf("HasSpriteSetter")]
  public Sprite[] clearedSpriteOptions;
  public int spriteIndex;
  [SerializeField]
  public EventReference highlightSfx;
  public bool selectable;
  public bool _hoverable = true;
  public bool _pressable = true;
  public bool reachable = true;
  public bool hasSprite;
  public bool hover;
  public bool press;
  [SerializeField]
  public Transform scaler;
  [SerializeField]
  public SpriteRenderer spriteRenderer;
  [SerializeField]
  public MapNodeLabel label;

  public bool HasSpriteSetter => (bool) (Object) this.spriteSetter;

  public bool hoverable
  {
    get => this._hoverable;
    set
    {
      if (this._hoverable != value)
      {
        if (value)
        {
          if (this.hasSprite)
            this.spriteRenderer.color = Color.white;
          if ((bool) (Object) this.scaler)
          {
            LeanTween.cancel(this.scaler.gameObject);
            LeanTween.scale(this.scaler.gameObject, Vector3.one * 1f, 0.33f).setEase(LeanTweenType.easeOutBack);
          }
        }
        else
        {
          Color color = this.reachable ? new Color(1f, 1f, 1f, 1f) : new Color(1f, 1f, 1f, 0.25f);
          if (this.hasSprite)
            this.spriteRenderer.color = color;
          if ((bool) (Object) this.scaler)
          {
            LeanTween.cancel(this.scaler.gameObject);
            LeanTween.scale(this.scaler.gameObject, Vector3.one * 0.9f, 0.33f).setEase(LeanTweenType.easeOutBack);
          }
          if (this.hover)
            this.UnHover();
        }
      }
      if ((bool) (Object) this.uINavigationItem)
        this.uINavigationItem.enabled = value;
      this._hoverable = value;
    }
  }

  public bool pressable
  {
    get => this._pressable;
    set => this._pressable = value;
  }

  public bool IsHovered => this.hover;

  public Color color
  {
    set
    {
      if (!this.hasSprite)
        return;
      this.spriteRenderer.color = value;
    }
  }

  public void Assign(CampaignNode node)
  {
    this.hasSprite = (bool) (Object) this.spriteRenderer;
    Random.InitState(node.seed);
    if (!this.HasSpriteSetter && this.spriteOptions.Length != 0)
      this.spriteIndex = Random.Range(0, this.spriteOptions.Length);
    this.campaignNode = node;
    this.Refresh();
    this.interactable = node.type.interactable;
    if (this.hasSprite)
    {
      Collider2D component = this.spriteRenderer.GetComponent<Collider2D>();
      if (component != null)
        component.Destroy();
      this.spriteRenderer.gameObject.AddComponent<BoxCollider2D>();
    }
    if (!(bool) (Object) this.glow)
      return;
    this.glow.SetActive(node.glow && !node.cleared);
  }

  public void Refresh()
  {
    if (!this.hasSprite)
      return;
    if (this.HasSpriteSetter)
    {
      this.spriteSetter.Set(this);
    }
    else
    {
      Sprite spriteOption = this.spriteOptions[this.spriteIndex];
      Sprite sprite = spriteOption;
      if (this.clearedSpriteOptions.Length != 0)
        sprite = this.clearedSpriteOptions[this.spriteIndex % this.clearedSpriteOptions.Length];
      this.SetSprite(this.campaignNode.cleared ? ((bool) (Object) sprite ? sprite : spriteOption) : spriteOption);
    }
  }

  public void SetSprite(Sprite sprite) => this.spriteRenderer.sprite = sprite;

  public void OnEnable() => this.CheckForFocus();

  public void CheckForFocus()
  {
    if (MonoBehaviourSingleton<Cursor3d>.instance.usingMouse || !(bool) (Object) this.highlight || !this.highlight.gameObject.activeSelf || !(bool) (Object) this.uINavigationItem || !this.uINavigationItem.isActiveAndEnabled)
      return;
    MonoBehaviourSingleton<UINavigationSystem>.instance.SetCurrentNavigationItem(this.uINavigationItem);
  }

  public void Reveal()
  {
    this.campaignNode.revealed = true;
    if (this.gameObject.activeSelf)
      return;
    this.gameObject.SetActive(true);
    this.transform.localScale = Vector3.zero;
    LeanTween.scale(this.gameObject, Vector3.one, Random.Range(0.4f, 0.5f)).setEase(LeanTweenType.easeOutBack);
    this.transform.localEulerAngles = new Vector3(0.0f, 0.0f, Random.Range(45f, 90f));
    LeanTween.rotateLocal(this.gameObject, Vector3.zero, Random.Range(0.4f, 0.5f)).setEase(LeanTweenType.easeOutBack);
    Events.InvokeMapNodeReveal(this);
    if (this.hover || !((Object) MonoBehaviourSingleton<UINavigationSystem>.instance.currentNavigationItem == (Object) this.uINavigationItem))
      return;
    this.Hover();
  }

  public void Hover()
  {
    if (!this.interactable || !this.hoverable || this.hover)
      return;
    this.hover = true;
    LeanTween.cancel(this.spriteRenderer.gameObject);
    LeanTween.scale(this.spriteRenderer.gameObject, Vector3.one * 1.1f, 0.23f).setEase(LeanTweenType.easeOutBack);
    if ((bool) (Object) this.label)
      this.label.Show();
    Events.InvokeMapNodeHover(this);
  }

  public void UnHover()
  {
    if (!this.hover)
      return;
    this.hover = false;
    LeanTween.cancel(this.spriteRenderer.gameObject);
    LeanTween.scale(this.spriteRenderer.gameObject, Vector3.one * 1f, 0.13f).setEase(LeanTweenType.easeOutBack);
    if ((bool) (Object) this.label)
      this.label.Hide();
    Events.InvokeMapNodeUnHover(this);
  }

  public void Press(BaseEventData eventData)
  {
    if (eventData is PointerEventData pointerEventData && pointerEventData.button != PointerEventData.InputButton.Left || !this.interactable || !this.pressable || this.press || !this.hover)
      return;
    this.press = true;
    this.color = new Color(0.85f, 0.85f, 0.85f);
  }

  public void Release(BaseEventData eventData)
  {
    if (eventData is PointerEventData pointerEventData && pointerEventData.button != PointerEventData.InputButton.Left || !this.press)
      return;
    this.press = false;
    this.color = Color.white;
    if (!this.hover)
      return;
    this.Select();
  }

  public void Select()
  {
    if (this.selectable && this.map.TryMoveTo(this))
    {
      Events.InvokeMapNodeSelect(this);
      this.animator.Play(nameof (Select));
      this.glow.SetActive(false);
    }
    else
    {
      Events.InvokeMapNodeSelect((MapNode) null);
      this.animator.Play("Shake");
    }
  }

  public void SetSelectable(bool value)
  {
    if (!this.selectable & value)
    {
      if ((bool) (Object) this.animator)
        this.animator.Play("Selectable");
      if ((bool) (Object) this.highlight)
      {
        this.highlight.gameObject.SetActive(true);
        this.highlight.transform.localScale = Vector3.zero;
        LeanTween.scale(this.highlight, Vector3.one, 1.25f).setEase(LeanTweenType.easeOutElastic).setDelay(0.25f);
      }
      SfxSystem.OneShot(this.highlightSfx);
      this.CheckForFocus();
    }
    else if (this.selectable && !value)
    {
      if ((bool) (Object) this.animator)
        this.animator.Stop();
      if ((bool) (Object) this.highlight)
        this.highlight.gameObject.SetActive(false);
    }
    this.selectable = value;
  }

  public override string ToString() => this.name;
}
