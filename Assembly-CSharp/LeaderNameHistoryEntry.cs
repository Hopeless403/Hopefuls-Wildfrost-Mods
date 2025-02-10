// Decompiled with JetBrains decompiler
// Type: LeaderNameHistoryEntry
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using TMPro;
using UnityEngine;

public class LeaderNameHistoryEntry : MonoBehaviour
{
  [SerializeField]
  private Transform offset;
  [SerializeField]
  private TMP_Text textElement;
  [SerializeField]
  private AnimationCurve scaleCurve;
  [SerializeField]
  private Gradient colour;
  [SerializeField]
  private Gradient missingColour;

  public void Assign(JournalNameHistory.Name name)
  {
    this.offset.localPosition = (Vector3) name.offset;
    this.offset.localEulerAngles = Vector2.zero.WithZ(name.angle);
    this.offset.localScale = Vector3.one * this.scaleCurve.Evaluate(name.opacity);
    this.textElement.text = name.text;
    if (name.killed)
      this.textElement.fontStyle = FontStyles.Strikethrough;
    if (name.missing)
    {
      this.textElement.text += " ?";
      this.textElement.color = this.missingColour.Evaluate(name.opacity);
    }
    else
      this.textElement.color = this.colour.Evaluate(name.opacity);
  }
}
