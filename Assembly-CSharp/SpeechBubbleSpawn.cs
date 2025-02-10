// Decompiled with JetBrains decompiler
// Type: SpeechBubbleSpawn
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections.Generic;
using UnityEngine;

public class SpeechBubbleSpawn : MonoBehaviourRect
{
  public float spacing = 0.01f;
  private readonly List<SpeechBub> bubbles = new List<SpeechBub>();

  private void OnEnable() => Object.FindObjectOfType<SpeechBubbleSystem>()?.AddSpawnPoint(this);

  private void OnDisable() => Object.FindObjectOfType<SpeechBubbleSystem>()?.RemoveSpawnPoint(this);

  private void Update()
  {
    bool flag = false;
    for (int index = this.bubbles.Count - 1; index >= 0; --index)
    {
      SpeechBub bubble = this.bubbles[index];
      if (!(bool) (Object) bubble)
        this.bubbles.RemoveAt(index);
      else if (!flag)
        flag = bubble.sizeUpdated;
    }
    if (!flag)
      return;
    this.UpdateSize();
    this.UpdatePositions();
  }

  public SpeechBub Create(SpeechBub prefab, SpeechBubbleData data)
  {
    SpeechBub speechBub = Object.Instantiate<SpeechBub>(prefab, this.transform);
    Transform transform = speechBub.transform;
    transform.localPosition = Vector3.zero;
    if (transform is RectTransform rectTransform)
      rectTransform.sizeDelta = rectTransform.sizeDelta.WithX(this.rectTransform.sizeDelta.x);
    this.bubbles.Add(speechBub);
    speechBub.Set(data);
    this.UpdateSize();
    this.UpdatePositions();
    return speechBub;
  }

  public void UpdateSize()
  {
    Vector2 vector2 = new Vector2(0.0f, 0.0f);
    int count = this.bubbles.Count;
    for (int index = 0; index < count; ++index)
    {
      SpeechBub bubble = this.bubbles[index];
      if ((bool) (Object) bubble)
      {
        Vector2 sizeDelta = bubble.rectTransform.sizeDelta;
        vector2.x = Mathf.Max(vector2.x, sizeDelta.x);
        vector2.y += sizeDelta.y + (index > 0 ? this.spacing : 0.0f);
      }
    }
    if (!(bool) (Object) this.rectTransform)
      return;
    this.rectTransform.sizeDelta = vector2;
  }

  public void UpdatePositions()
  {
    if (!(bool) (Object) this.rectTransform)
      return;
    Vector2 sizeDelta1 = this.rectTransform.sizeDelta;
    Vector2 vector2 = new Vector2((float) (-(double) sizeDelta1.x * 0.5), sizeDelta1.y * 0.5f);
    int count = this.bubbles.Count;
    for (int index = 0; index < count; ++index)
    {
      SpeechBub bubble = this.bubbles[index];
      if ((bool) (Object) bubble)
      {
        if (index < count - 1 && bubble.hasTail)
          bubble.hasTail = false;
        Vector2 sizeDelta2 = bubble.rectTransform.sizeDelta;
        Vector2 localPos = vector2 + new Vector2(sizeDelta2.x * 0.5f, (float) (-(double) sizeDelta2.y * 0.5));
        bubble.SetPosition((Vector3) localPos);
        vector2.y -= sizeDelta2.y;
      }
    }
  }
}
