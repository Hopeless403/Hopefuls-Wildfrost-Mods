// Decompiled with JetBrains decompiler
// Type: KeywordData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.Localization;

[CreateAssetMenu(fileName = "Keyword", menuName = "Keyword")]
public class KeywordData : ScriptableObject
{
  [SerializeField]
  private LocalizedString titleKey;
  [SerializeField]
  private LocalizedString descKey;
  public Color titleColour = new Color(1f, 0.7921569f, 0.3411765f, 1f);
  public Color bodyColour = Color.white;
  public Color noteColour = Color.gray;
  public Sprite panelSprite;
  public Color panelColor;
  public string iconName;
  public string iconTintHex;
  public bool show = true;
  public bool showName;
  public bool showIcon = true;
  public bool canStack;

  public bool HasTitle => !this.titleKey.IsEmpty;

  public string title => this.titleKey.GetLocalizedString();

  public string body
  {
    get
    {
      string localizedString = this.descKey.GetLocalizedString();
      int length = localizedString.IndexOf('|');
      return length <= 0 ? localizedString : localizedString.Substring(0, length);
    }
  }

  public string note
  {
    get
    {
      string localizedString = this.descKey.GetLocalizedString();
      int num = localizedString.IndexOf('|');
      return num <= 0 ? (string) null : localizedString.Substring(num + 1);
    }
  }
}
