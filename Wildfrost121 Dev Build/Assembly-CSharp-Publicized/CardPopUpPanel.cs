// Decompiled with JetBrains decompiler
// Type: CardPopUpPanel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using TMPro;
using UnityEngine;

#nullable disable
public class CardPopUpPanel : Tooltip
{
  [Header("Text")]
  [SerializeField]
  public float titleSize = 0.3f;
  [SerializeField]
  public float iconSize = 0.275f;
  [SerializeField]
  public float bodySize = 0.25f;
  [SerializeField]
  public float noteSize = 0.21f;
  [SerializeField]
  public TextMeshProUGUI textElement;
  [SerializeField]
  public Fitter fitter;
  public static readonly Color defaultTitleColor = new Color(1f, 0.7921569f, 0.3411765f, 1f);
  public static readonly Color defaultBodyColor = Color.white;
  public static readonly Color defaultNoteColor = new Color(0.65f, 0.65f, 0.65f);
  public string titleText;
  public string bodyText;
  public string noteText;

  public string text => this.textElement.text;

  public void Set(
    string iconName,
    string iconTintHex,
    string title,
    Color titleColour,
    string body,
    Color bodyColour,
    Sprite panelSprite,
    Color panelColor)
  {
    this.SetRoutine(iconName, iconTintHex, title, titleColour, body, bodyColour, "", Color.white, panelSprite, panelColor);
  }

  public void Set(
    string iconName,
    string iconTintHex,
    string title,
    Color titleColour,
    string body,
    Color bodyColour)
  {
    this.SetRoutine(iconName, iconTintHex, title, titleColour, body, bodyColour, "", Color.white, this.defaultPanelSprite, this.defaultPanelColor);
  }

  public void Set(string title, string body)
  {
    this.Set(title, CardPopUpPanel.defaultTitleColor, body, CardPopUpPanel.defaultBodyColor);
  }

  public void Set(string title, Color titleColour, string body, Color bodyColour)
  {
    this.SetRoutine("", "", title, titleColour, body, bodyColour, "", Color.white, this.defaultPanelSprite, this.defaultPanelColor);
  }

  public void Set(string text, Color textColour)
  {
    this.SetRoutine("", "", "", Color.white, text, textColour, "", Color.white, this.defaultPanelSprite, this.defaultPanelColor);
  }

  public void Set(KeywordData keyword, string forceBody = null)
  {
    string title = keyword.HasTitle ? keyword.title : "";
    string body = forceBody ?? keyword.body;
    this.SetRoutine(keyword.iconName, keyword.iconTintHex, title, keyword.titleColour, body, keyword.bodyColour, keyword.note, keyword.noteColour, keyword.panelSprite, keyword.panelColor);
  }

  public void SetRoutine(
    string iconName,
    string iconTintHex,
    string title,
    Color titleColour,
    string body,
    Color bodyColour,
    string note,
    Color noteColour,
    Sprite panelSprite,
    Color panelColor)
  {
    this.SetTitle(title, titleColour, iconName, iconTintHex);
    this.SetBody(body, bodyColour);
    this.SetNote(note, noteColour);
    this.BuildTextElement();
    this.panel.sprite = (bool) (UnityEngine.Object) panelSprite ? panelSprite : this.defaultPanelSprite;
    this.panel.color = (bool) (UnityEngine.Object) panelSprite ? panelColor : this.defaultPanelColor;
    if ((bool) (UnityEngine.Object) this.fitter)
    {
      LeanTween.cancel(this.gameObject);
      this.transform.localScale = Vector3.one;
      this.canvasGroup.alpha = 0.0f;
      this.fitter.Fit(new System.Action(((Tooltip) this).Ping));
    }
    else
      this.Ping();
  }

  public void SetTitle(string title, Color titleColour, string iconName, string iconTintHex)
  {
    this.titleText = "";
    if (!title.IsNullOrWhitespace())
      this.titleText += string.Format("<size={0}><#{1}>{2}", (object) this.titleSize, (object) titleColour.ToHexRGBA(), (object) Text.Process(title));
    if (iconName.IsNullOrWhitespace())
      return;
    if (!iconTintHex.IsNullOrWhitespace())
      this.titleText += string.Format("<size={0}><sprite name=\"{1}\" color=#{2}></size>", (object) this.iconSize, (object) iconName, (object) iconTintHex);
    else
      this.titleText += string.Format("<size={0}><sprite name=\"{1}\"></size>", (object) this.iconSize, (object) iconName);
  }

  public void AddToTitle(string text, bool newline = true)
  {
    if (this.titleText.IsNullOrWhitespace())
    {
      this.SetTitle(text, CardPopUpPanel.defaultTitleColor, "", "");
    }
    else
    {
      if (newline)
        this.titleText += "\n";
      this.titleText += Text.Process(text);
    }
  }

  public void SetBody(string body, Color bodyColour)
  {
    this.bodyText = "";
    if (body.IsNullOrWhitespace())
      return;
    this.bodyText = string.Format("<size={0}><#{1}>{2}", (object) this.bodySize, (object) bodyColour.ToHexRGBA(), (object) Text.Process(body));
  }

  public void AddToBody(string text, bool newline = true)
  {
    if (this.bodyText.IsNullOrWhitespace())
    {
      this.SetBody(text, CardPopUpPanel.defaultBodyColor);
    }
    else
    {
      if (newline)
        this.bodyText += "\n";
      this.bodyText += Text.Process(text);
    }
  }

  public void SetNote(string note, Color noteColour)
  {
    this.noteText = "";
    if (note.IsNullOrWhitespace())
      return;
    this.noteText = string.Format("<size={0}><#{1}>{2}", (object) this.noteSize, (object) noteColour.ToHexRGBA(), (object) note);
  }

  public void AddToNote(string text, bool newline = true)
  {
    if (this.noteText.IsNullOrWhitespace())
    {
      this.SetNote(text, CardPopUpPanel.defaultNoteColor);
    }
    else
    {
      if (newline)
        this.noteText += "\n";
      this.noteText += text;
    }
  }

  public void BuildTextElement()
  {
    string titleText = this.titleText;
    if (!this.bodyText.IsNullOrWhitespace())
    {
      if (!titleText.IsNullOrWhitespace())
        titleText += "<line-height=96%>\n</line-height>";
      titleText += this.bodyText;
    }
    if (!this.noteText.IsNullOrWhitespace())
    {
      if (!titleText.IsNullOrWhitespace())
        titleText += "<line-height=96%>\n</line-height>";
      titleText += this.noteText;
    }
    this.textElement.text = titleText;
  }
}
