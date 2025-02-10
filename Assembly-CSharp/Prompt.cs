// Decompiled with JetBrains decompiler
// Type: Prompt
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;
using UnityEngine.UI;

public class Prompt : MonoBehaviourRect
{
  [SerializeField]
  private TMP_Text textAsset;
  [SerializeField]
  private LayoutElement layoutElement;
  [SerializeField]
  private RectTransform textBox;
  [SerializeField]
  private float noteSize = 0.3f;
  [SerializeField]
  private string noteColorHex = "fffa";
  [SerializeField]
  private Prompt.Emote[] emotes;
  [SerializeField]
  private Image emoteImage;
  [SerializeField]
  private string focusFormat = "<#fff>{0}</color>";
  public Prompt.GetTextCallback SetTextAction;
  private float width;
  private Prompt.Emote.Type emoteType;
  private Prompt.Emote.Position emotePosition;

  public bool active { get; private set; }

  private void OnEnable() => LocalizationSettings.Instance.OnSelectedLocaleChanged += new Action<Locale>(this.LocaleChanged);

  private void OnDisable() => LocalizationSettings.Instance.OnSelectedLocaleChanged -= new Action<Locale>(this.LocaleChanged);

  private void LocaleChanged(Locale locale) => this.RunSetTextAction();

  public void RunSetTextAction()
  {
    Prompt.GetTextCallback setTextAction = this.SetTextAction;
    this.SetText(setTextAction != null ? setTextAction() : (string) null);
  }

  public void SetAnchor(Prompt.Anchor anchor)
  {
    switch (anchor)
    {
      case Prompt.Anchor.Mid:
        this.SetAnchor(0.5f, 0.5f);
        break;
      case Prompt.Anchor.Top:
        this.SetAnchor(0.5f, 1f);
        break;
      case Prompt.Anchor.Left:
        this.SetAnchor(0.0f, 0.5f);
        break;
      case Prompt.Anchor.Right:
        this.SetAnchor(1f, 0.5f);
        break;
      case Prompt.Anchor.Bottom:
        this.SetAnchor(0.5f, 0.0f);
        break;
      case Prompt.Anchor.TopLeft:
        this.SetAnchor(0.0f, 1f);
        break;
      case Prompt.Anchor.TopRight:
        this.SetAnchor(1f, 1f);
        break;
      case Prompt.Anchor.BottomLeft:
        this.SetAnchor(0.0f, 0.0f);
        break;
      case Prompt.Anchor.BottomRight:
        this.SetAnchor(1f, 0.0f);
        break;
      default:
        throw new ArgumentException(string.Format("Invalid Anchor {0}", (object) anchor));
    }
  }

  public void SetAnchor(float x, float y) => this.SetAnchor(new Vector2(x, y));

  public void SetAnchor(Vector2 anchor)
  {
    this.rectTransform.anchorMin = anchor;
    this.rectTransform.anchorMax = anchor;
    this.rectTransform.pivot = anchor;
  }

  public void SetPosition(Vector2 position) => this.rectTransform.anchoredPosition = position;

  public void SetPosition(Vector2 position, Prompt.Anchor anchor)
  {
    this.SetAnchor(anchor);
    this.rectTransform.anchoredPosition = position;
  }

  public void SetMaxWidth(float value)
  {
    this.layoutElement.preferredWidth = value;
    this.width = value;
  }

  public void SetText(string text)
  {
    float num = 0.0f;
    int length1 = text.IndexOf('+');
    if (length1 >= 0)
    {
      string s = text.Substring(length1 + 1);
      text = text.Substring(0, length1);
      ref float local = ref num;
      float.TryParse(s, out local);
    }
    this.layoutElement.preferredWidth = this.width + num;
    string note = "";
    if (text.Contains("|"))
    {
      int length2 = text.IndexOf('|');
      note = text.Substring(length2 + 1);
      text = text.Substring(0, length2);
    }
    this.SetText(this.ProcessText(text), note);
    this.SetEmote(this.emoteType, this.emotePosition);
  }

  public void SetText(string text, string note = "")
  {
    if (!note.IsNullOrWhitespace())
      text += string.Format("\n\n<size={0}><#{1}>{2}", (object) this.noteSize, (object) this.noteColorHex, (object) note);
    this.textAsset.text = text;
  }

  private string ProcessText(string input)
  {
    string str1 = input.Trim();
    int length = input.Length;
    while (true)
    {
      int num1 = str1.IndexOf('[');
      if (num1 >= 0)
      {
        int num2 = str1.IndexOf(']', num1);
        if (num2 > num1)
        {
          string str2 = this.ProcessTag(str1.Substring(num1, num2 - num1).Substring(1, num2 - num1 - 1));
          string str3 = str1.Substring(0, num1);
          string str4 = str1.Substring(num2 + 1);
          str1 = str3 + str2 + str4;
        }
        else
          break;
      }
      else
        break;
    }
    return str1;
  }

  private string ProcessTag(string tag) => string.Format(this.focusFormat, (object) tag);

  public void SetEmote(Prompt.Emote.Type emoteType, Prompt.Emote.Position position)
  {
    this.emoteType = emoteType;
    this.emotePosition = position;
    Prompt.Emote emote = ((IEnumerable<Prompt.Emote>) this.emotes).FirstOrDefault<Prompt.Emote>((Func<Prompt.Emote, bool>) (e => e.type == emoteType));
    if ((bool) (UnityEngine.Object) emote.sprite)
    {
      this.emoteImage.gameObject.SetActive(true);
      this.emoteImage.sprite = emote.sprite;
      this.SetEmotePosition(position);
    }
    else
      this.emoteImage.gameObject.SetActive(false);
  }

  public void SetEmotePosition(
    Prompt.Emote.Position position,
    float offsetX = 0.0f,
    float offsetY = 0.0f,
    float forceFlip = 0.0f)
  {
    this.StopAllCoroutines();
    this.StartCoroutine(this.SetEmotePositionRoutine(position, offsetX, offsetY, forceFlip));
  }

  private IEnumerator SetEmotePositionRoutine(
    Prompt.Emote.Position position,
    float offsetX = 0.0f,
    float offsetY = 0.0f,
    float forceFlip = 0.0f)
  {
    Rect rect = this.textBox.rect;
    while (rect == this.textBox.rect)
      yield return (object) null;
    rect = this.textBox.rect;
    float num1 = (float) ((double) rect.width * 0.5 + 0.10000000149011612);
    float num2 = (float) ((double) rect.height * 0.5 + 0.68999999761581421);
    RectTransform transform = (RectTransform) this.emoteImage.transform;
    switch (position)
    {
      case Prompt.Emote.Position.Left:
        transform.anchoredPosition = new Vector2(-num1 + offsetX, 0.0f + offsetY);
        break;
      case Prompt.Emote.Position.Right:
        transform.anchoredPosition = new Vector2(num1 + offsetX, 0.0f + offsetY);
        break;
      case Prompt.Emote.Position.Above:
        transform.anchoredPosition = new Vector2((float) (-(double) num1 * 0.5) + offsetX, num2 + offsetY);
        break;
      case Prompt.Emote.Position.Below:
        transform.anchoredPosition = new Vector2(0.0f + offsetX, -num2 + offsetY);
        break;
    }
    float x = (double) forceFlip == 0.0 ? ((double) transform.position.x < 0.0 ? 1f : -1f) : forceFlip;
    transform.localScale = new Vector3(x, 1f, 1f);
  }

  public void Ping()
  {
    LeanTween.cancel(this.gameObject);
    this.transform.localScale = Vector3.one * 0.0f;
    LeanTween.scale(this.gameObject, Vector3.one, 1.5f).setEase(LeanTweenType.easeOutElastic);
  }

  public void Hide()
  {
    this.active = false;
    LeanTween.cancel(this.gameObject);
    this.transform.localScale = Vector3.one;
    LeanTween.scale(this.gameObject, Vector3.zero, 0.167f).setEase(LeanTweenType.easeInBack).setOnComplete((System.Action) (() => this.gameObject.SetActive(false)));
  }

  public void Enable()
  {
    this.active = true;
    this.gameObject.SetActive(true);
  }

  public delegate string GetTextCallback();

  public enum Anchor
  {
    Mid,
    Top,
    Left,
    Right,
    Bottom,
    TopLeft,
    TopRight,
    BottomLeft,
    BottomRight,
  }

  [Serializable]
  public struct Emote
  {
    public Prompt.Emote.Type type;
    public Sprite sprite;

    public enum Type
    {
      None,
      Basic,
      Point,
      Scared,
      Talk,
      Explain,
      Sad,
      Happy,
    }

    public enum Position
    {
      Left,
      Right,
      Above,
      Below,
    }
  }
}
