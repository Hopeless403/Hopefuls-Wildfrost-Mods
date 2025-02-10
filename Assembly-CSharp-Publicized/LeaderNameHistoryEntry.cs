// Decompiled with JetBrains decompiler
// Type: LeaderNameHistoryEntry
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using TMPro;
using UnityEngine;

public class LeaderNameHistoryEntry : MonoBehaviour
{
  [SerializeField]
  public Transform offset;
  [SerializeField]
  public TMP_Text textElement;
  [SerializeField]
  public AnimationCurve scaleCurve;
  [SerializeField]
  public Gradient colour;
  [SerializeField]
  public Gradient missingColour;

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
