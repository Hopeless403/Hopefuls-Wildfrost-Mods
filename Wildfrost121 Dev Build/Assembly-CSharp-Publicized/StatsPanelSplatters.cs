// Decompiled with JetBrains decompiler
// Type: StatsPanelSplatters
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
public class StatsPanelSplatters : MonoBehaviour
{
  [SerializeField]
  public Sprite[] splatterSprites;
  [SerializeField]
  public ImageSprite[] splatters;
  public static readonly StatsPanelSplatters.Profile[] profiles = new StatsPanelSplatters.Profile[8]
  {
    new StatsPanelSplatters.Profile(1f, 1f, 1f, 1f, 0.0f, -2f),
    new StatsPanelSplatters.Profile(1f, 0.5f, 1f, 0.5f, 0.0f, -2f),
    new StatsPanelSplatters.Profile(1f, 0.0f, 1f, 0.0f, -2f, 0.0f),
    new StatsPanelSplatters.Profile(0.0f, 1f, 0.0f, 1f, 2f, 0.0f),
    new StatsPanelSplatters.Profile(0.0f, 0.5f, 0.0f, 0.5f, 0.0f, 2f),
    new StatsPanelSplatters.Profile(0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 2f),
    new StatsPanelSplatters.Profile(0.5f, 1f, 0.5f, 1f, 2f, 0.0f),
    new StatsPanelSplatters.Profile(0.5f, 0.0f, 0.5f, 0.0f, -2f, 0.0f)
  };
  public readonly List<Sprite> spritePool = new List<Sprite>();
  public readonly List<StatsPanelSplatters.Profile> profilePool = new List<StatsPanelSplatters.Profile>();

  public void OnEnable()
  {
    List<Color> list = new List<Color>();
    SplatterPersistenceSystem objectOfType = UnityEngine.Object.FindObjectOfType<SplatterPersistenceSystem>();
    if (objectOfType.storedSplatters != null && objectOfType.storedSplatters.Count > 0)
    {
      foreach (SplatterPersistenceSystem.SplatterData[] source in objectOfType.storedSplatters.Values)
        list.AddRange(((IEnumerable<SplatterPersistenceSystem.SplatterData>) source).Select<SplatterPersistenceSystem.SplatterData, Color>((Func<SplatterPersistenceSystem.SplatterData, Color>) (a => a.color)));
    }
    int num = Mathf.Min(this.splatters.Length, list.Count);
    for (int index = 0; index < num; ++index)
    {
      ImageSprite splatter = this.splatters[index];
      StatsPanelSplatters.Profile profile1 = this.PullProfile();
      Sprite sprite1 = this.PullSprite();
      StatsPanelSplatters.Profile profile2 = profile1;
      Sprite sprite2 = sprite1;
      Color color = list.RandomItem<Color>();
      StatsPanelSplatters.Set(splatter, profile2, sprite2, color);
    }
  }

  public StatsPanelSplatters.Profile PullProfile()
  {
    if (this.profilePool.Count <= 0)
      this.profilePool.AddRange((IEnumerable<StatsPanelSplatters.Profile>) StatsPanelSplatters.profiles);
    return this.profilePool.TakeRandom<StatsPanelSplatters.Profile>();
  }

  public Sprite PullSprite()
  {
    if (this.spritePool.Count <= 0)
      this.spritePool.AddRange((IEnumerable<Sprite>) this.splatterSprites);
    return this.spritePool.TakeRandom<Sprite>();
  }

  public static void Set(
    ImageSprite image,
    StatsPanelSplatters.Profile profile,
    Sprite sprite,
    Color color)
  {
    image.gameObject.SetActive(true);
    image.SetSprite(sprite);
    image.color = color;
    if (!(image.transform is RectTransform transform))
      return;
    transform.anchorMax = profile.anchorMax;
    transform.anchorMin = profile.anchorMin;
    transform.anchoredPosition = new Vector2(UnityEngine.Random.Range(0.0f, profile.moveRange.x), UnityEngine.Random.Range(0.0f, profile.moveRange.y));
    transform.localEulerAngles = new Vector3(0.0f, 0.0f, UnityEngine.Random.Range(0.0f, 360f));
  }

  public struct Profile
  {
    public readonly Vector2 anchorMin;
    public readonly Vector2 anchorMax;
    public readonly Vector2 moveRange;

    public Profile(float minX, float minY, float maxX, float maxY, float moveX, float moveY)
    {
      this.anchorMin = new Vector2(minX, minY);
      this.anchorMax = new Vector2(maxX, maxY);
      this.moveRange = new Vector2(moveX, moveY);
    }
  }
}
