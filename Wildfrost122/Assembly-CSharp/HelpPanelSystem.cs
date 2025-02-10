// Decompiled with JetBrains decompiler
// Type: HelpPanelSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using FMODUnity;
using System;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Localization;
using UnityEngine.Localization.Components;
using UnityEngine.UI;

#nullable disable
public class HelpPanelSystem : GameSystem
{
  private static HelpPanelSystem _instance;
  private static GameObject _rtCamera;
  [SerializeField]
  private TMP_Text title;
  [SerializeField]
  private TMP_Text body;
  [SerializeField]
  private TMP_Text note;
  [SerializeField]
  private ImageSprite image;
  [SerializeField]
  private LayoutElement imageLayout;
  [Header("Button Options")]
  [SerializeField]
  private Transform buttonGroup;
  [SerializeField]
  private GameObject backButton;
  [SerializeField]
  private HelpPanelSystem.ButtonProfile[] buttonPrefabs;
  private static readonly Dictionary<HelpPanelSystem.ButtonType, HelpPanelSystem.ButtonProfile> buttonProfileLookup = new Dictionary<HelpPanelSystem.ButtonType, HelpPanelSystem.ButtonProfile>();
  [Header("Emotes")]
  [SerializeField]
  private Image emote;
  [SerializeField]
  private Prompt.Emote[] emoteTypes;
  [Header("SFX")]
  [SerializeField]
  private EventReference popUpSfx;
  public static bool Active;

  private static HelpPanelSystem instance
  {
    get
    {
      return HelpPanelSystem._instance ?? (HelpPanelSystem._instance = UnityEngine.Object.FindObjectOfType<HelpPanelSystem>(true));
    }
  }

  private static GameObject rtCamera
  {
    get
    {
      GameObject rtCamera = HelpPanelSystem._rtCamera;
      if (rtCamera != null)
        return rtCamera;
      Camera[] objectsOfType = UnityEngine.Object.FindObjectsOfType<Camera>(true);
      return HelpPanelSystem._rtCamera = ((IEnumerable<Camera>) objectsOfType).First<Camera>((Func<Camera, bool>) (a => a.name == "RenderTextureCamera")).gameObject;
    }
  }

  private void Awake()
  {
    HelpPanelSystem.buttonProfileLookup.Clear();
    foreach (HelpPanelSystem.ButtonProfile buttonPrefab in this.buttonPrefabs)
      HelpPanelSystem.buttonProfileLookup[buttonPrefab.type] = buttonPrefab;
  }

  private void OnEnable()
  {
    HelpPanelSystem.Active = true;
    HelpPanelSystem.rtCamera.SetActive(true);
  }

  private void OnDisable()
  {
    HelpPanelSystem.Active = false;
    HelpPanelSystem.rtCamera.SetActive(false);
    foreach (Component component in this.buttonGroup)
      component.gameObject.Destroy();
    this.imageLayout.gameObject.SetActive(false);
  }

  public static void SetBackButtonActive(bool active)
  {
    HelpPanelSystem.instance.backButton.SetActive(active);
  }

  public static void Show(LocalizedString key)
  {
    string[] strArray = key.GetLocalizedString().Split('|', StringSplitOptions.None);
    HelpPanelSystem.instance.title.gameObject.SetActive(strArray.Length != 0);
    HelpPanelSystem.instance.body.gameObject.SetActive(strArray.Length > 1);
    HelpPanelSystem.instance.note.gameObject.SetActive(strArray.Length > 2);
    HelpPanelSystem.instance.title.text = strArray.Length != 0 ? strArray[0] : "";
    HelpPanelSystem.instance.body.text = strArray.Length > 1 ? strArray[1] : "";
    HelpPanelSystem.instance.note.text = strArray.Length > 2 ? strArray[2] : "";
    SfxSystem.OneShot(HelpPanelSystem.instance.popUpSfx);
    HelpPanelSystem.instance.gameObject.SetActive(true);
  }

  public static void SetEmote(Prompt.Emote.Type emoteType)
  {
    HelpPanelSystem.instance.emote.sprite = ((IEnumerable<Prompt.Emote>) HelpPanelSystem.instance.emoteTypes).FirstOrDefault<Prompt.Emote>((Func<Prompt.Emote, bool>) (a => a.type == emoteType)).sprite;
  }

  public static void AddButton(
    HelpPanelSystem.ButtonType type,
    LocalizedString textKey,
    string hotKey,
    UnityAction onSelect)
  {
    HelpPanelSystem.ButtonProfile buttonProfile;
    if (!HelpPanelSystem.buttonProfileLookup.TryGetValue(type, out buttonProfile))
      return;
    GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(buttonProfile.prefab, HelpPanelSystem.instance.buttonGroup);
    gameObject.GetComponent<RewiredHotKeyController>()?.SetActionName(hotKey);
    Button componentInChildren = gameObject.GetComponentInChildren<Button>();
    if (onSelect != null)
      componentInChildren.onClick.AddListener(onSelect);
    componentInChildren.onClick.AddListener((UnityAction) (() => HelpPanelSystem.instance.gameObject.SetActive(false)));
    gameObject.GetComponentInChildren<LocalizeStringEvent>().StringReference = textKey;
  }

  public static void SetImage(float width, float height, Sprite sprite)
  {
    HelpPanelSystem.instance.imageLayout.gameObject.SetActive(true);
    HelpPanelSystem.instance.image.SetSprite(sprite);
    HelpPanelSystem.instance.imageLayout.preferredWidth = width;
    HelpPanelSystem.instance.imageLayout.preferredHeight = height;
  }

  [Serializable]
  private struct ButtonProfile
  {
    [SerializeField]
    internal HelpPanelSystem.ButtonType type;
    [SerializeField]
    internal GameObject prefab;
  }

  public enum ButtonType
  {
    Positive,
    Negative,
  }
}
