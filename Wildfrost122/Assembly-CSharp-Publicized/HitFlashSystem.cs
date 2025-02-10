// Decompiled with JetBrains decompiler
// Type: HitFlashSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
public class HitFlashSystem : GameSystem
{
  public static HitFlashSystem instance;
  [SerializeField]
  public float flashDuration = 0.1f;
  [SerializeField]
  public Material damageMaterial;
  public readonly List<HitFlashSystem.HitFlash> list = new List<HitFlashSystem.HitFlash>();

  public void Awake() => HitFlashSystem.instance = this;

  public void OnEnable() => global::Events.OnEntityHit += new UnityAction<Hit>(this.EntityHit);

  public void Update()
  {
    for (int index = this.list.Count - 1; index >= 0; --index)
    {
      HitFlashSystem.HitFlash hitFlash = this.list[index];
      hitFlash.Update(Time.deltaTime);
      if (hitFlash.ended)
        this.list.RemoveAt(index);
    }
  }

  public void OnDisable()
  {
    global::Events.OnEntityHit -= new UnityAction<Hit>(this.EntityHit);
    foreach (HitFlashSystem.HitFlash hitFlash in this.list)
      hitFlash.End();
    this.list.Clear();
  }

  public void EntityHit(Hit hit)
  {
    if (!hit.Offensive || hit.nullified)
      return;
    HitFlashSystem.HitFlash hitFlash = this.list.Find((Predicate<HitFlashSystem.HitFlash>) (a => (UnityEngine.Object) a.target == (UnityEngine.Object) hit.target));
    if (hitFlash != null)
      hitFlash.time = this.flashDuration;
    else
      this.list.Add(new HitFlashSystem.HitFlash(hit.target, this.damageMaterial, this.flashDuration));
  }

  public void RemoveFromTarget(Entity entity)
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
    [CompilerGenerated]
    public Entity \u003Ctarget\u003Ek__BackingField;
    public Material material;
    public float time;
    public Dictionary<Image, Material> imageDict = new Dictionary<Image, Material>();
    public List<TMP_Text> textElements = new List<TMP_Text>();

    public Entity target
    {
      get => this.\u003Ctarget\u003Ek__BackingField;
      set => this.\u003Ctarget\u003Ek__BackingField = value;
    }

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
