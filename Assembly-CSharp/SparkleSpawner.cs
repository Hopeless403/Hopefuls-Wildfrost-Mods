// Decompiled with JetBrains decompiler
// Type: SparkleSpawner
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections.Generic;
using UnityEngine;

public class SparkleSpawner : MonoBehaviourRect
{
  private int sparkleCount;
  public Sprite sparkleSprite;
  private Queue<Sparkle> pool = new Queue<Sparkle>();
  private List<Transform> activeSparkles = new List<Transform>();
  public Vector2 sizeRange = new Vector2(0.25f, 0.75f);
  public Color colour = Color.white;
  public Vector2 spawnTimeRange = new Vector2(0.75f, 1f);
  public float timer;

  private void Update()
  {
    float y = this.rectTransform.rect.position.y;
    for (int index = this.activeSparkles.Count - 1; index >= 0; --index)
    {
      Transform activeSparkle = this.activeSparkles[index];
      Vector3 localPosition = activeSparkle.localPosition;
      if ((double) localPosition.y < (double) y)
      {
        this.pool.Enqueue(activeSparkle.GetComponent<Sparkle>());
        activeSparkle.gameObject.SetActive(false);
        this.activeSparkles.Remove(activeSparkle);
      }
      else
        activeSparkle.localPosition = localPosition;
    }
    this.timer -= Time.deltaTime;
    if ((double) this.timer > 0.0)
      return;
    this.NewSparkle();
    this.timer = this.spawnTimeRange.PettyRandom();
  }

  private void NewSparkle()
  {
    Sparkle sparkle;
    if (this.pool.Count <= 0)
    {
      sparkle = new GameObject(string.Format("Sparkle {0}", (object) this.sparkleCount++)).AddComponent<Sparkle>();
      sparkle.sprite = this.sparkleSprite;
      sparkle.transform.SetParent(this.transform);
    }
    else
    {
      sparkle = this.pool.Dequeue();
      sparkle.gameObject.SetActive(true);
    }
    float num = this.sizeRange.PettyRandom();
    float a = Mathf.Min(1f, num * 2f) * 0.5f;
    Rect rect = this.rectTransform.rect;
    Vector3 vector3 = (rect.position + new Vector2(Random.Range(0.0f, rect.width), rect.height)).WithZ(0.0f);
    RectTransform component = sparkle.GetComponent<RectTransform>();
    component.localPosition = vector3;
    component.localEulerAngles = Vector3.zero;
    component.localScale = Vector3.one;
    sparkle.size = num;
    sparkle.color = new Color(this.colour.r, this.colour.g, this.colour.b, a);
    this.activeSparkles.Add(sparkle.transform);
  }
}
