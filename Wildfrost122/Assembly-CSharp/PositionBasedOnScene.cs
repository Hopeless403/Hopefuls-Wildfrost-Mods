// Decompiled with JetBrains decompiler
// Type: PositionBasedOnScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

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
  private PositionBasedOnScene.ScenePosition[] positions;
  private bool hasRectTransform;
  private RectTransform rt;
  private Transform t;

  private void OnEnable()
  {
    this.t = this.transform;
    if (this.t is RectTransform t)
    {
      this.hasRectTransform = true;
      this.rt = t;
    }
    global::Events.OnSceneChanged += new UnityAction<Scene>(this.ActiveSceneChanged);
  }

  private void OnDisable()
  {
    global::Events.OnSceneChanged -= new UnityAction<Scene>(this.ActiveSceneChanged);
  }

  private void ActiveSceneChanged(Scene to)
  {
    PositionBasedOnScene.ScenePosition scenePosition = ((IEnumerable<PositionBasedOnScene.ScenePosition>) this.positions).FirstOrDefault<PositionBasedOnScene.ScenePosition>((Func<PositionBasedOnScene.ScenePosition, bool>) (a => a.sceneName == to.name));
    if (scenePosition == null)
      return;
    this.SetPosition(scenePosition.position);
  }

  private void SetPosition(Vector3 pos)
  {
    if (this.hasRectTransform)
      this.rt.anchoredPosition = (Vector2) pos;
    else
      this.t.localPosition = pos;
  }

  [Serializable]
  private class ScenePosition
  {
    [SerializeField]
    internal string sceneName;
    [SerializeField]
    internal Vector3 position;
  }
}
