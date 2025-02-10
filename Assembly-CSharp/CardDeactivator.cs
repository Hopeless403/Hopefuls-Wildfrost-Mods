// Decompiled with JetBrains decompiler
// Type: CardDeactivator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CardDeactivator : MonoBehaviour
{
  private readonly List<GameObject> entities = new List<GameObject>();
  private readonly List<GameObject> toDisable = new List<GameObject>();
  private Camera _cam;

  private Camera cam => this._cam ?? (this._cam = Camera.main);

  private void OnEnable()
  {
    global::Events.OnEntityCreated += new UnityAction<Entity>(this.EntityCreated);
    global::Events.OnEntityDestroyed += new UnityAction<Entity>(this.EntityDestroyed);
  }

  private void OnDisable()
  {
    global::Events.OnEntityCreated -= new UnityAction<Entity>(this.EntityCreated);
    global::Events.OnEntityDestroyed -= new UnityAction<Entity>(this.EntityDestroyed);
  }

  private void EntityCreated(Entity entity) => this.entities.Add(entity.gameObject);

  private void EntityDestroyed(Entity entity) => this.entities.Remove(entity.gameObject);

  private void LateUpdate()
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

  private void SetActiveness(GameObject obj, bool inView)
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
