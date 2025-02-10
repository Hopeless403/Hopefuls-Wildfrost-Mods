// Decompiled with JetBrains decompiler
// Type: CardPopUp
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

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
  public Canvas canvas;
  [SerializeField]
  public RectTransform bounds;
  [SerializeField]
  public RectTransform boundingBox;
  [SerializeField]
  public RectTransform layout;
  [SerializeField]
  public ContentSizeFitter sizeFitter;
  [SerializeField]
  public float gap = 0.05f;
  [SerializeField]
  [Range(-1f, 1f)]
  public float posX = 1f;
  [SerializeField]
  [Range(-1f, 1f)]
  public float posY;
  [Header("Tooltip Prefabs")]
  [SerializeField]
  public AssetReferenceGameObject keywordTooltipPrefab;
  [SerializeField]
  public int keywordTooltipInitialPool = 1;
  [SerializeField]
  public AssetReferenceGameObject cardTooltipPrefab;
  [SerializeField]
  public int cardTooltipInitialPool = 1;
  public readonly Dictionary<string, Tooltip> activePanels = new Dictionary<string, Tooltip>();
  public RectTransform follow;
  public readonly List<Tooltip> pool = new List<Tooltip>();
  public bool ignoreTimeScale;

  public void Awake()
  {
    for (int index = 0; index < this.keywordTooltipInitialPool; ++index)
      this.PoolPanel((Tooltip) this.keywordTooltipPrefab.InstantiateAsync((Transform) this.layout).WaitForCompletion().GetComponent<CardPopUpPanel>());
    for (int index = 0; index < this.cardTooltipInitialPool; ++index)
      this.PoolPanel((Tooltip) this.cardTooltipPrefab.InstantiateAsync((Transform) this.layout).WaitForCompletion().GetComponent<CardTooltip>());
  }

  public void Update()
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

  public T GetPanel<T>() where T : Tooltip
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

  public void PoolPanel(Tooltip panel)
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

  public void StartFixLayouts()
  {
    if (!(bool) (UnityEngine.Object) this.sizeFitter)
      return;
    this.StopAllCoroutines();
    this.StartCoroutine(this.FixLayouts());
  }

  public IEnumerator FixLayouts()
  {
    yield return (object) null;
    this.sizeFitter.enabled = false;
    yield return (object) null;
    this.sizeFitter.enabled = true;
  }

  public Vector3 ApplyLimits(Vector3 pos)
  {
    Vector2 max = Vector2.Scale(Vector2.Scale(this.bounds.sizeDelta, this.bounds.pivot) - Vector2.Scale(this.boundingBox.sizeDelta, this.boundingBox.pivot), (Vector2) this.rectTransform.lossyScale);
    return ((Vector2) pos).Clamp(-max, max).WithZ(pos.z);
  }
}
