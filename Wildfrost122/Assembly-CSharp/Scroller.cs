// Decompiled with JetBrains decompiler
// Type: Scroller
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class Scroller : MonoBehaviourRect
{
  [SerializeField]
  private UINavigationLayer navLayer;
  public bool interactable = true;
  public float scrollSpeed = 0.2f;
  public float scrollAmount = 1f;
  public bool horizontal;
  public RectTransform bounds;
  [Range(0.0f, 1f)]
  public float boundsHardness = 0.2f;
  public UnityEvent onScroll;
  public UnityEvent<float> afterScroll;
  public Vector2 targetPos;
  private Vector2 preTargetPos;
  [SerializeField]
  private bool hasStartScroll;
  [SerializeField]
  [ShowIf("hasStartScroll")]
  [Range(0.0f, 1f)]
  private float startScroll;
  [SerializeField]
  private bool ignoreTimeScale;
  [Header("Scroll Knob")]
  [SerializeField]
  private RectTransform scrollKnob;
  [SerializeField]
  private RectTransform scrollKnobBounds;
  private float boundsDelay;
  private static float boundsDelayMax;
  private bool checkBounds;

  public float DeltaTime => !this.ignoreTimeScale ? Time.deltaTime : Time.unscaledDeltaTime;

  private float s
  {
    get => this.GetRelevant(this.rectTransform.rect.size) - this.GetRelevant(this.bounds.rect.size);
  }

  private float TargetPos
  {
    get => !this.horizontal ? this.targetPos.y : this.targetPos.x;
    set
    {
      if (this.horizontal)
        this.targetPos.x = value;
      else
        this.targetPos.y = value;
    }
  }

  public float ScrollAmount
  {
    get => (this.s * 0.5f - this.TargetPos) / this.s;
    set => this.TargetPos = (float) (-(double) this.s * 0.5 + (double) value * (double) this.s);
  }

  private void Awake()
  {
    if (!(bool) (Object) this.bounds && this.transform.parent.transform is RectTransform transform)
      this.bounds = transform;
    if (this.navLayer == null)
      this.navLayer = this.FindComponentInParents<UINavigationLayer>(this.transform);
    this.UpdateScrollKnob();
    this.boundsDelay = Scroller.boundsDelayMax;
    this.InvokeAfterScroll();
    this.preTargetPos = this.targetPos;
  }

  private T FindComponentInParents<T>(Transform parent) where T : Component
  {
    T component;
    while (true)
    {
      component = parent.GetComponent<T>();
      if (!((Object) component != (Object) null))
      {
        if (!((Object) parent.parent == (Object) null))
          parent = parent.parent;
        else
          goto label_3;
      }
      else
        break;
    }
    return component;
label_3:
    return default (T);
  }

  private void OnEnable()
  {
    if (!this.hasStartScroll)
      return;
    this.ScrollTo(this.startScroll);
    this.rectTransform.anchoredPosition = this.targetPos;
  }

  public bool CheckNavigationLayer()
  {
    return !(bool) (Object) this.navLayer || (Object) UINavigationSystem.ActiveNavigationLayer == (Object) this.navLayer;
  }

  public void Update()
  {
    if (this.interactable && this.CheckNavigationLayer())
    {
      float num = 0.0f;
      if (MonoBehaviourSingleton<Cursor3d>.instance.usingMouse)
        num = this.horizontal ? -Input.mouseScrollDelta.y : Input.mouseScrollDelta.y;
      if ((double) num != 0.0)
        this.Scroll(num * this.scrollAmount);
    }
    if ((double) this.boundsDelay > 0.0)
      this.boundsDelay -= this.DeltaTime;
    else if (this.checkBounds && (bool) (Object) this.bounds)
      this.CheckBounds();
    Vector2 anchoredPosition = this.rectTransform.anchoredPosition;
    if (!(anchoredPosition != this.targetPos))
      return;
    this.rectTransform.anchoredPosition = Delta.Lerp(anchoredPosition, this.targetPos, this.scrollSpeed, this.DeltaTime);
  }

  private void LateUpdate()
  {
    if (!(this.preTargetPos != this.targetPos))
      return;
    this.InvokeAfterScroll();
    this.preTargetPos = this.targetPos;
  }

  private void InvokeAfterScroll()
  {
    if (this.afterScroll == null || !(bool) (Object) this.bounds)
      return;
    float s = this.s;
    this.afterScroll.Invoke((float) (1.0 - ((double) this.TargetPos + (double) (s * 0.5f) - (double) this.GetRelevant((Vector2) this.bounds.localPosition)) / (double) s));
  }

  public void Scroll(float amount)
  {
    this.TargetPos -= amount;
    this.onScroll?.Invoke();
    this.UpdateScrollKnob();
    this.checkBounds = true;
  }

  public void ScrollImmediate(float amount)
  {
    this.TargetPos -= amount;
    this.onScroll?.Invoke();
    this.CheckBounds();
    this.rectTransform.anchoredPosition = this.targetPos;
    this.UpdateScrollKnob();
  }

  public void ScrollTo(float position)
  {
    this.ScrollAmount = position;
    this.onScroll?.Invoke();
    this.UpdateScrollKnob();
  }

  public void ScrollTo(Vector2 targetPos)
  {
    this.targetPos = targetPos;
    this.onScroll?.Invoke();
    this.UpdateScrollKnob();
    this.checkBounds = true;
  }

  public void CheckBounds()
  {
    Vector2 vector2_1 = this.bounds.rect.size * 0.5f;
    Vector2 anchoredPosition = this.bounds.anchoredPosition;
    float num1 = this.GetRelevant(anchoredPosition) - this.GetRelevant(vector2_1);
    float num2 = this.GetRelevant(anchoredPosition) + this.GetRelevant(vector2_1);
    Vector2 vector2_2 = this.rectTransform.rect.size * 0.5f;
    float num3 = this.TargetPos - this.GetRelevant(vector2_2);
    float num4 = this.TargetPos + this.GetRelevant(vector2_2);
    bool flag1 = (double) num3 >= (double) num1;
    bool flag2 = (double) num4 <= (double) num2;
    Vector2 targetPos = this.targetPos;
    if (flag1 | flag2)
    {
      Vector2 target = !(flag1 & flag2) ? (!flag1 ? this.AddRelevant(targetPos, num2 - num4) : this.AddRelevant(targetPos, num1 - num3)) : this.SetRelevant(targetPos, 0.0f);
      this.targetPos = (double) this.boundsHardness < 1.0 ? Delta.Lerp(this.targetPos, target, this.boundsHardness, this.DeltaTime) : target;
    }
    else
      this.checkBounds = false;
  }

  private float GetRelevant(Vector2 vector2) => !this.horizontal ? vector2.y : vector2.x;

  private Vector2 SetRelevant(Vector2 vector2, float value)
  {
    if (this.horizontal)
      vector2.x = value;
    else
      vector2.y = value;
    return vector2;
  }

  private Vector2 AddRelevant(Vector2 vector2, float value)
  {
    if (this.horizontal)
      vector2.x += value;
    else
      vector2.y += value;
    return vector2;
  }

  private void UpdateScrollKnob()
  {
    if (!(bool) (Object) this.scrollKnob || !(bool) (Object) this.scrollKnobBounds)
      return;
    float relevant = this.GetRelevant(this.scrollKnobBounds.rect.size);
    float num = (float) (-(double) relevant * 0.5 + (double) relevant * (double) Mathf.Clamp(this.ScrollAmount, 0.0f, 1f));
    LeanTween.cancel(this.scrollKnob);
    LeanTween.move(this.scrollKnob, (Vector3) (this.horizontal ? this.scrollKnob.anchoredPosition.WithX(num) : this.scrollKnob.anchoredPosition.WithY(num)), 0.2f).setEase(LeanTweenType.easeOutQuart);
  }

  public void SetInteractable(bool value) => this.interactable = value;

  public bool ContentLargerThanBounds()
  {
    return !this.horizontal ? (double) this.rectTransform.sizeDelta.y > (double) this.bounds.sizeDelta.y : (double) this.rectTransform.sizeDelta.x > (double) this.bounds.sizeDelta.x;
  }
}
