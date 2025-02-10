// Decompiled with JetBrains decompiler
// Type: PositionBasedOnScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

#nullable disable
public class PositionBasedOnScene : MonoBehaviour
{
  [SerializeField]
  public PositionBasedOnScene.ScenePosition[] positions;
  public bool hasRectTransform;
  public RectTransform rt;
  public Transform t;

  public void OnEnable()
  {
    this.t = this.transform;
    if (this.t is RectTransform t)
    {
      this.hasRectTransform = true;
      this.rt = t;
    }
    global::Events.OnSceneChanged += new UnityAction<Scene>(this.ActiveSceneChanged);
  }

  public void OnDisable()
  {
    global::Events.OnSceneChanged -= new UnityAction<Scene>(this.ActiveSceneChanged);
  }

  public void ActiveSceneChanged(Scene to)
  {
    PositionBasedOnScene.ScenePosition scenePosition = ((IEnumerable<PositionBasedOnScene.ScenePosition>) this.positions).FirstOrDefault<PositionBasedOnScene.ScenePosition>((Func<PositionBasedOnScene.ScenePosition, bool>) (a => a.sceneName == to.name));
    if (scenePosition == null)
      return;
    this.SetPosition(scenePosition.position);
  }

  public void SetPosition(Vector3 pos)
  {
    if (this.hasRectTransform)
      this.rt.anchoredPosition = (Vector2) pos;
    else
      this.t.localPosition = pos;
  }

  [Serializable]
  public class ScenePosition
  {
    [SerializeField]
    public string sceneName;
    [SerializeField]
    public Vector3 position;
  }
}
