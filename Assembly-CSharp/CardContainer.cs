// Decompiled with JetBrains decompiler
// Type: CardContainer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Pool;

public class CardContainer : 
  MonoBehaviourRect,
  IPointerEnterHandler,
  IEventSystemHandler,
  IPointerExitHandler,
  IList<Entity>,
  ICollection<Entity>,
  IEnumerable<Entity>,
  IEnumerable
{
  [Required(null)]
  public RectTransform holder;
  public UINavigationItem nav;
  public List<CardContainer> shoveTo = new List<CardContainer>();
  private CardContainer _group;
  protected readonly List<Entity> entities = new List<Entity>();
  public Character owner;
  public bool canBePlacedOn;
  public bool canPlayOn;
  public bool canHover = true;
  public int max;
  public Vector3 gap;
  public Vector3 childHoverOffset;
  [Header("Movement Tween")]
  public Vector2 movementDurRand = new Vector2(0.3f, 0.4f);
  public LeanTweenType movementEase = LeanTweenType.easeOutQuart;
  [Header("Scale Tween")]
  public Vector2 scaleDurRand = new Vector2(0.2f, 0.2f);
  public LeanTweenType scaleEase = LeanTweenType.easeOutQuart;
  [Header("Events")]
  public UnityEventEntity onAdd;
  public UnityEventEntity onRemove;
  private CardController _cc;
  [SerializeField]
  private bool poolCardsOnDestroy = true;

  public virtual CardContainer Group
  {
    get => !(bool) (UnityEngine.Object) this._group ? this : this._group;
    set => this._group = value;
  }

  public virtual int Count { get; protected set; }

  public virtual float CardScale => (float) ((double) this.holder.sizeDelta.y / 4.5 * 1.0);

  public bool Empty => this.Count <= 0;

  protected CardController cc
  {
    get
    {
      if (!(bool) (UnityEngine.Object) this._cc)
        this._cc = CardController.Find(this.gameObject);
      return this._cc;
    }
  }

  public bool IsReadOnly => false;

  protected virtual int ChildCount => this.holder.childCount;

  public static CardContainer[] FindAll()
  {
    CardContainer[] objectsOfType = UnityEngine.Object.FindObjectsOfType<CardContainer>();
    HashSet<CardContainer> cardContainerSet = GenericPool<HashSet<CardContainer>>.Get();
    cardContainerSet.Clear();
    foreach (CardContainer cardContainer in objectsOfType)
    {
      if ((UnityEngine.Object) cardContainer.Group != (UnityEngine.Object) cardContainer)
        cardContainerSet.AddIfNotNull<CardContainer>(cardContainer);
    }
    CardContainer[] array = cardContainerSet.ToArray<CardContainer>();
    GenericPool<HashSet<CardContainer>>.Release(cardContainerSet);
    return array;
  }

  public CardContainer[] GetSecondaryContainers(Entity entity)
  {
    List<CardContainer> toRelease = GenericPool<List<CardContainer>>.Get();
    toRelease.Clear();
    foreach (CardContainer cardContainer in CardContainer.FindAll())
    {
      if ((UnityEngine.Object) cardContainer != (UnityEngine.Object) this && cardContainer.Contains(entity))
        toRelease.Add(cardContainer);
    }
    CardContainer[] array = toRelease.ToArray();
    GenericPool<List<CardContainer>>.Release(toRelease);
    return array;
  }

  public virtual void AssignController(CardController controller) => this._cc = controller;

  private void Start()
  {
    this.nav = (UINavigationItem) null;
    this.CheckForNavigationItem(this.transform);
  }

  private void CheckForNavigationItem(Transform inTransform)
  {
    if ((bool) (UnityEngine.Object) inTransform.GetComponent<UINavigationItem>())
    {
      this.nav = inTransform.GetComponent<UINavigationItem>();
    }
    else
    {
      for (int index = 0; index < inTransform.childCount; ++index)
        this.CheckForNavigationItem(inTransform.GetChild(index));
    }
  }

  private void OnDestroy()
  {
    if (GameManager.End || !this.poolCardsOnDestroy)
      return;
    for (int index = this.entities.Count - 1; index >= 0; --index)
      CardManager.ReturnToPool(this.entities[index]);
  }

  public virtual void SetSize(int size, float cardScale) => this.max = size;

  public virtual void Add(Entity entity)
  {
    entity.transform.SetParent((Transform) this.holder);
    entity.AddTo(this);
    this.entities.Add(entity);
    ++this.Count;
    this.CardAdded(entity);
    this.onAdd.Invoke(entity);
  }

  public virtual void Insert(int index, Entity entity)
  {
    entity.transform.SetParent((Transform) this.holder);
    entity.AddTo(this);
    this.entities.Insert(index, entity);
    ++this.Count;
    entity.transform.SetSiblingIndex(index);
    this.CardAdded(entity);
    this.onAdd.Invoke(entity);
  }

  public virtual bool PushForwards(int fromIndex) => throw new NotImplementedException();

  public virtual bool PushBackwards(int fromIndex) => throw new NotImplementedException();

  public virtual void MoveChildrenForward() => throw new NotImplementedException();

  public virtual void Remove(Entity entity)
  {
    if (!entity.inCardPool)
      entity.transform.SetParent((Transform) null);
    entity.RemoveFrom(this);
    this.entities.Remove(entity);
    --this.Count;
    this.CardRemoved(entity);
    this.onRemove.Invoke(entity);
    Debug.Log((object) ("[" + entity.name + "] Removed From [" + this.name + "]"));
  }

  public virtual void RemoveAt(int index) => this.Remove(this[index]);

  public virtual Entity this[int index]
  {
    get => this.entities.Count <= index ? (Entity) null : this.entities[index];
    set => throw new NotImplementedException();
  }

  public virtual Entity GetTop() => this.entities.Count <= 0 ? (Entity) null : this.entities[this.entities.Count - 1];

  public virtual Vector3 GetChildPosition(Entity child) => Vector3.zero;

  public virtual Vector3 GetChildScale(Entity child) => Vector3.one * this.CardScale;

  public virtual Vector3 GetChildRotation(Entity child) => Vector3.zero;

  public virtual int GetChildDrawOrder(Entity child) => 0;

  protected virtual void CardAdded(Entity entity)
  {
  }

  protected virtual void CardRemoved(Entity entity)
  {
  }

  public bool IsPrimaryContainer(Entity entity) => (bool) (UnityEngine.Object) entity && entity.actualContainers.Count > 0 && (UnityEngine.Object) entity.actualContainers[0] == (UnityEngine.Object) this;

  [Button(null, EButtonEnableMode.Always)]
  public virtual void TweenChildPositions()
  {
    foreach (Entity entity in this.Where<Entity>((Func<Entity, bool>) (a => a.alive)))
      entity.TweenToContainer();
  }

  public virtual void SetChildPositions()
  {
    foreach (Entity child in this)
      this.SetChildPosition(child);
  }

  public virtual void TweenChildPosition(Entity child) => child.TweenToContainer();

  public virtual void SetChildPosition(Entity child)
  {
    child.transform.localPosition = this.GetChildPosition(child);
    child.transform.localScale = this.GetChildScale(child);
    child.transform.localEulerAngles = this.GetChildRotation(child);
  }

  public void OnPointerEnter(PointerEventData eventData)
  {
    if (!this.canHover)
      return;
    this.Hover();
  }

  public virtual void Hover()
  {
    if (!(bool) (UnityEngine.Object) this.cc)
      return;
    this.cc.HoverContainer(this);
  }

  public void OnPointerExit(PointerEventData eventData)
  {
    if (!this.canHover)
      return;
    this.UnHover();
  }

  public virtual void UnHover()
  {
    if (!(bool) (UnityEngine.Object) this.cc || !((UnityEngine.Object) this.cc.hoverContainer == (UnityEngine.Object) this))
      return;
    this.cc.UnHoverContainer();
  }

  public virtual int IndexOf(Entity item) => this.entities.IndexOf(item);

  public virtual void Clear()
  {
    for (int index = this.Count - 1; index >= 0; --index)
      this.RemoveAt(index);
  }

  public void DestroyAll()
  {
    foreach (Entity entity in this)
      CardManager.ReturnToPool(entity);
  }

  public void ClearAndDestroyAllImmediately()
  {
    Entity[] array = this.ToArray();
    this.Clear();
    foreach (Component component in array)
      component.gameObject.DestroyImmediate();
  }

  public virtual bool Contains(Entity item) => this.entities.Contains(item);

  public virtual Entity[] ToArray() => this.entities.ToArray();

  public void CopyTo(Entity[] array, int arrayIndex) => this.entities.CopyTo(array, arrayIndex);

  bool ICollection<Entity>.Remove(Entity item) => throw new NotImplementedException();

  public virtual IEnumerator<Entity> GetEnumerator() => (IEnumerator<Entity>) this.entities.GetEnumerator();

  IEnumerator IEnumerable.GetEnumerator() => (IEnumerator) this.GetEnumerator();
}
