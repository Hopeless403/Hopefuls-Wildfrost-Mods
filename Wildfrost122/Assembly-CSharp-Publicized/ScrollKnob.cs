// Decompiled with JetBrains decompiler
// Type: ScrollKnob
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
public class ScrollKnob : MonoBehaviourRect
{
  [SerializeField]
  public RectTransform bounds;
  [SerializeField]
  public bool horizontal;
  public Vector2 targetPosition;

  public void Update()
  {
    this.rectTransform.anchoredPosition = Delta.Lerp(this.rectTransform.anchoredPosition, this.targetPosition, 0.33f, Time.deltaTime);
  }

  public void SetPosition(Vector2 position) => this.SetPosition(this.GetRelevantAxis(position));

  public void SetPosition(float normalizedPosition)
  {
    float relevantAxis = this.GetRelevantAxis(this.bounds.rect.size);
    float num = (float) (-(double) relevantAxis * 0.5 + (double) relevantAxis * (double) Mathf.Clamp(normalizedPosition, 0.0f, 1f));
    if (this.horizontal)
      this.targetPosition.x = num;
    else
      this.targetPosition.y = num;
  }

  public float GetRelevantAxis(Vector2 vector2) => !this.horizontal ? vector2.y : vector2.x;
}
