// Decompiled with JetBrains decompiler
// Type: ScrollKnob
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

public class ScrollKnob : MonoBehaviourRect
{
  [SerializeField]
  private RectTransform bounds;
  [SerializeField]
  private bool horizontal;
  private Vector2 targetPosition;

  private void Update() => this.rectTransform.anchoredPosition = Delta.Lerp(this.rectTransform.anchoredPosition, this.targetPosition, 0.33f, Time.deltaTime);

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

  private float GetRelevantAxis(Vector2 vector2) => !this.horizontal ? vector2.y : vector2.x;
}
