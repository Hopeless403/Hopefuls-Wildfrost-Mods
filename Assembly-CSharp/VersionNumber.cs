// Decompiled with JetBrains decompiler
// Type: VersionNumber
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using TMPro;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof (TMP_Text))]
public class VersionNumber : MonoBehaviour
{
  [SerializeField]
  private bool showProfile;
  [SerializeField]
  private bool showVersion = true;
  private TMP_Text _t;

  private TMP_Text textElement => this._t ?? (this._t = this.GetComponent<TMP_Text>());

  private void OnEnable() => global::Events.OnSaveSystemProfileChanged += new UnityAction(this.UpdateText);

  private void OnDisable() => global::Events.OnSaveSystemProfileChanged -= new UnityAction(this.UpdateText);

  private void Start() => this.UpdateText();

  private void UpdateText()
  {
    string str = "";
    if (SaveSystem.Enabled && this.showProfile)
    {
      if (!str.IsNullOrWhitespace())
        str += "\n";
      str = str + "Profile: " + SaveSystem.Profile;
    }
    if (this.showVersion)
    {
      if (!str.IsNullOrWhitespace())
        str += "\n";
      str += string.Format(Config.data.versionFormat, (object) Config.data.versionNotation);
    }
    this.textElement.text = str;
  }
}
