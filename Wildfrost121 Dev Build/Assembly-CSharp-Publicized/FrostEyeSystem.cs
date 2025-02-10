// Decompiled with JetBrains decompiler
// Type: FrostEyeSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Events;

#nullable disable
public class FrostEyeSystem : GameSystem
{
  [SerializeField]
  public AssetReference frostEyePrefab;
  public static AssetReference frostEyePrefabRef;
  public static readonly List<Entity> toProcess = new List<Entity>();
  public static readonly Dictionary<Card, List<GameObject>> toRemove = new Dictionary<Card, List<GameObject>>();

  public void OnEnable()
  {
    FrostEyeSystem.frostEyePrefabRef = this.frostEyePrefab;
    global::Events.OnEntityCreated += new UnityAction<Entity>(FrostEyeSystem.EntityCreated);
    global::Events.OnEntityDataUpdated += new UnityAction<Entity>(FrostEyeSystem.EntityDataUpdated);
    global::Events.OnCardPooled += new UnityAction<Card>(FrostEyeSystem.CardPooled);
  }

  public void OnDisable()
  {
    global::Events.OnEntityCreated -= new UnityAction<Entity>(FrostEyeSystem.EntityCreated);
    global::Events.OnEntityDataUpdated -= new UnityAction<Entity>(FrostEyeSystem.EntityDataUpdated);
    global::Events.OnCardPooled -= new UnityAction<Card>(FrostEyeSystem.CardPooled);
  }

  public static void EntityCreated(Entity entity)
  {
    Dictionary<string, object> customData = entity.data.customData;
    if (!((customData != null ? customData.GetValueOrDefault<string, object>("eyes", (object) null) : (object) null) is string valueOrDefault) || !(valueOrDefault == "frost"))
      return;
    FrostEyeSystem.toProcess.Add(entity);
  }

  public static void EntityDataUpdated(Entity entity)
  {
    if (!FrostEyeSystem.toProcess.Contains(entity))
      return;
    FrostEyeSystem.toProcess.Remove(entity);
    FrostEyeSystem.Create(entity);
  }

  public static void Create(Entity entity)
  {
    if (!(entity.display is Card display))
      return;
    Transform parent1 = display.mainImage.transform.parent;
    AvatarEyePositions componentInChildren = parent1.GetComponentInChildren<AvatarEyePositions>();
    if (componentInChildren != null)
    {
      Transform transform1 = componentInChildren.transform;
      foreach (AvatarEyePositions.Eye eye in componentInChildren.eyes)
      {
        Transform transform2 = FrostEyeSystem.frostEyePrefabRef.InstantiateAsync(transform1).WaitForCompletion().transform;
        transform2.localPosition = eye.pos;
        transform2.localScale = eye.scale;
      }
    }
    else
    {
      EyeData eyeData = AddressableLoader.GetGroup<EyeData>("EyeData").FirstOrDefault<EyeData>((Func<EyeData, bool>) (a => a.cardData == entity.data.name));
      if (!(bool) (UnityEngine.Object) eyeData)
        return;
      Transform parent2 = ((IEnumerable) parent1).Cast<Transform>().FirstOrDefault<Transform>((Func<Transform, bool>) (a => a.gameObject.activeSelf));
      if (!(bool) (UnityEngine.Object) parent2)
        return;
      FrostEyeSystem.toRemove.Add(display, new List<GameObject>());
      foreach (EyeData.Eye eye in eyeData.eyes)
      {
        Transform transform = FrostEyeSystem.frostEyePrefabRef.InstantiateAsync(parent2).WaitForCompletion().transform;
        transform.SetLocalPositionAndRotation((Vector3) eye.position, Quaternion.Euler(0.0f, 0.0f, eye.rotation));
        transform.localScale = eye.scale.WithZ(1f);
        FrostEyeSystem.toRemove[display].Add(transform.gameObject);
      }
    }
  }

  public static void CardPooled(Card card)
  {
    if (!FrostEyeSystem.toRemove.ContainsKey(card))
      return;
    Debug.Log((object) string.Format("Destroying [{0}] Frosteye objects from [{1}]", (object) FrostEyeSystem.toRemove[card].Count, (object) card.name));
    foreach (UnityEngine.Object @object in FrostEyeSystem.toRemove[card])
      UnityEngine.Object.Destroy(@object);
    FrostEyeSystem.toRemove.Remove(card);
  }
}
