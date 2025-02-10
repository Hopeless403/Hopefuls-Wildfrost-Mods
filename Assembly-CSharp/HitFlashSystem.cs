// Decompiled with JetBrains decompiler
// Type: HitFlashSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class HitFlashSystem : GameSystem
{
  private static HitFlashSystem instance;
  [SerializeField]
  private float flashDuration = 0.1f;
  [SerializeField]
  private Material damageMaterial;
  private readonly List<HitFlashSystem.HitFlash> list = new List<HitFlashSystem.HitFlash>();

  private void Awake() => HitFlashSystem.instance = this;

  private void OnEnable() => global::Events.OnEntityHit += new UnityAction<Hit>(this.EntityHit);

  private void Update()
  {
    for (int index = this.list.Count - 1; index >= 0; --index)
    {
      HitFlashSystem.HitFlash hitFlash = this.list[index];
      hitFlash.Update(Time.deltaTime);
      if (hitFlash.ended)
        this.list.RemoveAt(index);
    }
  }

  private void OnDisable()
  {
    global::Events.OnEntityHit -= new UnityAction<Hit>(this.EntityHit);
    foreach (HitFlashSystem.HitFlash hitFlash in this.list)
      hitFlash.End();
    this.list.Clear();
  }

  private void EntityHit(Hit hit)
  {
    if (!hit.Offensive || hit.nullified)
      return;
    HitFlashSystem.HitFlash hitFlash = this.list.Find((Predicate<HitFlashSystem.HitFlash>) (a => (UnityEngine.Object) a.target == (UnityEngine.Object) hit.target));
    if (hitFlash != null)
      hitFlash.time = this.flashDuration;
    else
      this.list.Add(new HitFlashSystem.HitFlash(hit.target, this.damageMaterial, this.flashDuration));
  }

  private void RemoveFromTarget(Entity entity)
  {
    HitFlashSystem.HitFlash hitFlash = this.list.Find((Predicate<HitFlashSystem.HitFlash>) (a => (UnityEngine.Object) a.target == (UnityEngine.Object) entity));
    if (hitFlash == null)
      return;
    hitFlash.End();
    this.list.Remove(hitFlash);
  }

  public static void Remove(Entity entity)
  {
    if (!((UnityEngine.Object) HitFlashSystem.instance != (UnityEngine.Object) null))
      return;
    HitFlashSystem.instance.RemoveFromTarget(entity);
  }

  public class HitFlash
  {
    private Material material;
    public float time;
    private Dictionary<Image, Material> imageDict = new Dictionary<Image, Material>();
    private List<TMP_Text> textElements = new List<TMP_Text>();

    public Entity target { get; private set; }

    public bool ended => (double) this.time <= 0.0;

    public HitFlash(Entity entity, Material material, float duration)
    {
      this.target = entity;
      this.material = material;
      this.time = duration;
      this.Start();
    }

    public void Start()
    {
      Image[] componentsInChildren1 = this.target.GetComponentsInChildren<Image>(true);
      TMP_Text[] componentsInChildren2 = this.target.GetComponentsInChildren<TMP_Text>(true);
      foreach (Image key in componentsInChildren1)
      {
        if (key.enabled && (UnityEngine.Object) key.sprite != (UnityEngine.Object) null && (UnityEngine.Object) key.gameObject.GetComponent<Mask>() == (UnityEngine.Object) null)
        {
          this.imageDict.Add(key, key.material);
          key.material = this.material;
        }
      }
      foreach (TMP_Text tmpText in componentsInChildren2)
      {
        if (tmpText.enabled)
        {
          this.textElements.Add(tmpText);
          tmpText.enabled = false;
        }
      }
    }

    public void Update(float delta)
    {
      this.time -= delta;
      if ((double) this.time > 0.0)
        return;
      this.End();
    }

    public void End()
    {
      foreach (KeyValuePair<Image, Material> keyValuePair in this.imageDict)
      {
        if ((UnityEngine.Object) keyValuePair.Key != (UnityEngine.Object) null)
          keyValuePair.Key.material = keyValuePair.Value;
      }
      foreach (TMP_Text textElement in this.textElements)
      {
        if ((UnityEngine.Object) textElement != (UnityEngine.Object) null)
          textElement.enabled = true;
      }
    }
  }
}
