// Decompiled with JetBrains decompiler
// Type: CardPopUp
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.UI;

#nullable disable
public class CardPopUp : MonoBehaviourRectSingleton<CardPopUp>
{
  [SerializeField]
  private Canvas canvas;
  [SerializeField]
  private RectTransform bounds;
  [SerializeField]
  private RectTransform boundingBox;
  [SerializeField]
  private RectTransform layout;
  [SerializeField]
  private ContentSizeFitter sizeFitter;
  [SerializeField]
  private float gap = 0.05f;
  [SerializeField]
  [Range(-1f, 1f)]
  private float posX = 1f;
  [SerializeField]
  [Range(-1f, 1f)]
  private float posY;
  [Header("Tooltip Prefabs")]
  [SerializeField]
  private AssetReferenceGameObject keywordTooltipPrefab;
  [SerializeField]
  private int keywordTooltipInitialPool = 1;
  [SerializeField]
  private AssetReferenceGameObject cardTooltipPrefab;
  [SerializeField]
  private int cardTooltipInitialPool = 1;
  private readonly Dictionary<string, Tooltip> activePanels = new Dictionary<string, Tooltip>();
  private RectTransform follow;
  private readonly List<Tooltip> pool = new List<Tooltip>();
  private bool ignoreTimeScale;

  private void Awake()
  {
    for (int index = 0; index < this.keywordTooltipInitialPool; ++index)
      this.PoolPanel((Tooltip) this.keywordTooltipPrefab.InstantiateAsync((Transform) this.layout).WaitForCompletion().GetComponent<CardPopUpPanel>());
    for (int index = 0; index < this.cardTooltipInitialPool; ++index)
      this.PoolPanel((Tooltip) this.cardTooltipPrefab.InstantiateAsync((Transform) this.layout).WaitForCompletion().GetComponent<CardTooltip>());
  }

  private void Update()
  {
    if ((bool) (UnityEngine.Object) this.follow)
    {
      Vector2 vector2_1 = this.follow.sizeDelta * (Vector2) this.follow.lossyScale * this.follow.pivot;
      Vector2 vector2_2 = this.layout.sizeDelta * (Vector2) this.layout.lossyScale * this.layout.pivot;
      this.rectTransform.position = this.ApplyLimits(this.follow.position + new Vector3((vector2_1.x + vector2_2.x + this.gap) * this.posX, (vector2_1.y + vector2_2.y + this.gap) * this.posY, 0.0f));
    }
    else
      CardPopUp.Clear();
  }

  public static void SetCanvasLayer(string layerName, int orderInLayer)
  {
    MonoBehaviourRectSingleton<CardPopUp>.instance.canvas.sortingLayerName = layerName;
    MonoBehaviourRectSingleton<CardPopUp>.instance.canvas.sortingOrder = orderInLayer;
  }

  public static void SetIgnoreTimeScale(bool ignore)
  {
    MonoBehaviourRectSingleton<CardPopUp>.instance.ignoreTimeScale = ignore;
  }

  public static void Reset()
  {
    CardPopUp.SetCanvasLayer("PopUp", 0);
    CardPopUp.SetIgnoreTimeScale(false);
  }

  public static void AssignToCard(Card card)
  {
    MonoBehaviourRectSingleton<CardPopUp>.instance.follow = card.canvas.transform as RectTransform;
    MonoBehaviourRectSingleton<CardPopUp>.instance.posX = 1f;
    MonoBehaviourRectSingleton<CardPopUp>.instance.posY = 0.0f;
  }

  public static void AssignTo(RectTransform rect, float posX, float posY)
  {
    MonoBehaviourRectSingleton<CardPopUp>.instance.follow = rect;
    MonoBehaviourRectSingleton<CardPopUp>.instance.posX = posX;
    MonoBehaviourRectSingleton<CardPopUp>.instance.posY = posY;
  }

  public static CardPopUpPanel AddPanel(string name, string title, string body)
  {
    if (MonoBehaviourRectSingleton<CardPopUp>.instance.activePanels.ContainsKey(name))
      return (CardPopUpPanel) null;
    CardPopUpPanel panel = MonoBehaviourRectSingleton<CardPopUp>.instance.GetPanel<CardPopUpPanel>();
    panel.gameObject.name = name;
    panel.ignoreTimeScale = MonoBehaviourRectSingleton<CardPopUp>.instance.ignoreTimeScale;
    panel.Set(title, body);
    MonoBehaviourRectSingleton<CardPopUp>.instance.activePanels.Add(name, (Tooltip) panel);
    foreach (KeywordData keyword in Text.GetKeywords(body))
    {
      CardPopUpPanel cardPopUpPanel = CardPopUp.AddPanel(keyword);
      panel.children.AddIfNotNull<Tooltip>((Tooltip) cardPopUpPanel);
    }
    return panel;
  }

  public static CardPopUpPanel AddPanel(KeywordData keyword, string forceBody = null)
  {
    if (MonoBehaviourRectSingleton<CardPopUp>.instance.activePanels.ContainsKey(keyword.name))
      return (CardPopUpPanel) null;
    CardPopUpPanel panel = MonoBehaviourRectSingleton<CardPopUp>.instance.GetPanel<CardPopUpPanel>();
    panel.gameObject.name = keyword.name;
    panel.ignoreTimeScale = MonoBehaviourRectSingleton<CardPopUp>.instance.ignoreTimeScale;
    panel.Set(keyword, forceBody);
    Events.InvokePopupPanelCreated(keyword, panel);
    MonoBehaviourRectSingleton<CardPopUp>.instance.activePanels.Add(keyword.name, (Tooltip) panel);
    foreach (KeywordData keyword1 in Text.GetKeywords(keyword.body))
    {
      CardPopUpPanel cardPopUpPanel = CardPopUp.AddPanel(keyword1);
      panel.children.AddIfNotNull<Tooltip>((Tooltip) cardPopUpPanel);
    }
    return panel;
  }

  public static CardTooltip AddPanel(CardData cardData)
  {
    CardTooltip panel = MonoBehaviourRectSingleton<CardPopUp>.instance.GetPanel<CardTooltip>();
    panel.gameObject.name = cardData.name;
    panel.Set(cardData);
    MonoBehaviourRectSingleton<CardPopUp>.instance.activePanels.Add(cardData.name, (Tooltip) panel);
    foreach (KeywordData keyword in panel.keywords)
    {
      CardPopUpPanel cardPopUpPanel = CardPopUp.AddPanel(keyword);
      panel.children.AddIfNotNull<Tooltip>((Tooltip) cardPopUpPanel);
    }
    return panel;
  }

  public static void RemovePanel(string name)
  {
    Tooltip panel;
    if (MonoBehaviourRectSingleton<CardPopUp>.instance.activePanels.TryGetValue(name, out panel))
    {
      foreach (UnityEngine.Object child in panel.children)
        CardPopUp.RemovePanel(child.name);
      MonoBehaviourRectSingleton<CardPopUp>.instance.PoolPanel(panel);
      MonoBehaviourRectSingleton<CardPopUp>.instance.activePanels.Remove(name);
    }
    else
      Debug.Log((object) ("Panel [" + name + "] does not exist (CardPopUp)"));
    MonoBehaviourRectSingleton<CardPopUp>.instance.StartFixLayouts();
  }

  private T GetPanel<T>() where T : Tooltip
  {
    Tooltip panel = this.pool.FirstOrDefault<Tooltip>((Func<Tooltip, bool>) (a => a is T));
    if (!(bool) (UnityEngine.Object) panel)
      panel = !(typeof (T) == typeof (CardTooltip)) ? (Tooltip) this.keywordTooltipPrefab.InstantiateAsync((Transform) this.layout).WaitForCompletion().GetComponent<CardPopUpPanel>() : (Tooltip) this.cardTooltipPrefab.InstantiateAsync((Transform) this.layout).WaitForCompletion().GetComponent<CardTooltip>();
    else
      this.pool.RemoveAt(this.pool.IndexOf(panel));
    panel.gameObject.SetActive(true);
    panel.transform.SetAsLastSibling();
    return panel as T;
  }

  private void PoolPanel(Tooltip panel)
  {
    panel.children.Clear();
    panel.gameObject.SetActive(false);
    this.pool.Add(panel);
  }

  public static void Clear()
  {
    foreach (KeyValuePair<string, Tooltip> activePanel in MonoBehaviourRectSingleton<CardPopUp>.instance.activePanels)
      activePanel.Value.gameObject.Destroy();
    MonoBehaviourRectSingleton<CardPopUp>.instance.activePanels.Clear();
    MonoBehaviourRectSingleton<CardPopUp>.instance.follow = (RectTransform) null;
  }

  private void StartFixLayouts()
  {
    if (!(bool) (UnityEngine.Object) this.sizeFitter)
      return;
    this.StopAllCoroutines();
    this.StartCoroutine(this.FixLayouts());
  }

  private IEnumerator FixLayouts()
  {
    yield return (object) null;
    this.sizeFitter.enabled = false;
    yield return (object) null;
    this.sizeFitter.enabled = true;
  }

  private Vector3 ApplyLimits(Vector3 pos)
  {
    Vector2 max = Vector2.Scale(Vector2.Scale(this.bounds.sizeDelta, this.bounds.pivot) - Vector2.Scale(this.boundingBox.sizeDelta, this.boundingBox.pivot), (Vector2) this.rectTransform.lossyScale);
    return ((Vector2) pos).Clamp(-max, max).WithZ(pos.z);
  }
}
