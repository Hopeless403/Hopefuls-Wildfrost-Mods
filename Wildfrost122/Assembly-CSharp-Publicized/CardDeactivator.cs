// Decompiled with JetBrains decompiler
// Type: CardDeactivator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class CardDeactivator : MonoBehaviour
{
  public readonly List<GameObject> entities = new List<GameObject>();
  public readonly List<GameObject> toDisable = new List<GameObject>();
  public Camera _cam;

  public Camera cam => this._cam ?? (this._cam = Camera.main);

  public void OnEnable()
  {
    global::Events.OnEntityCreated += new UnityAction<Entity>(this.EntityCreated);
    global::Events.OnEntityDestroyed += new UnityAction<Entity>(this.EntityDestroyed);
  }

  public void OnDisable()
  {
    global::Events.OnEntityCreated -= new UnityAction<Entity>(this.EntityCreated);
    global::Events.OnEntityDestroyed -= new UnityAction<Entity>(this.EntityDestroyed);
  }

  public void EntityCreated(Entity entity) => this.entities.Add(entity.gameObject);

  public void EntityDestroyed(Entity entity) => this.entities.Remove(entity.gameObject);

  public void LateUpdate()
  {
    if (Transition.Running)
      return;
    foreach (GameObject entity in this.entities)
    {
      bool inView = this.cam.IsInCameraView(entity.transform.position, 0.1f);
      this.SetActiveness(entity.gameObject, inView);
    }
    for (int index = Mathf.CeilToInt((float) this.toDisable.Count * 0.1f) - 1; index >= 0; --index)
    {
      GameObject gameObject = this.toDisable[index];
      this.toDisable.RemoveAt(index);
      gameObject.gameObject.SetActive(false);
    }
  }

  public void SetActiveness(GameObject obj, bool inView)
  {
    if (inView)
    {
      if (obj.activeSelf && !this.toDisable.Contains(obj))
        return;
      obj.SetActive(true);
      this.toDisable.Remove(obj);
    }
    else
    {
      if (!obj.activeSelf || this.toDisable.Contains(obj))
        return;
      this.toDisable.Add(obj);
    }
  }
}
