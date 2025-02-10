// Decompiled with JetBrains decompiler
// Type: LeaderNameHistoryEntry
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using TMPro;
using UnityEngine;

#nullable disable
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
