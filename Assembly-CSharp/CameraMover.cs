// Decompiled with JetBrains decompiler
// Type: CameraMover
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class CameraMover : GameSystem
{
  [SerializeField]
  private CameraMover.Translation[] battlePhasePositions;

  private void OnEnable()
  {
    global::Events.OnBattlePhaseStart += new UnityAction<Battle.Phase>(this.BattlePhaseStart);
    global::Events.OnSceneChanged += new UnityAction<Scene>(this.SceneChange);
  }

  private void OnDisable()
  {
    global::Events.OnBattlePhaseStart -= new UnityAction<Battle.Phase>(this.BattlePhaseStart);
    global::Events.OnSceneChanged -= new UnityAction<Scene>(this.SceneChange);
  }

  private void BattlePhaseStart(Battle.Phase phase)
  {
    CameraMover.Translation translation = ((IEnumerable<CameraMover.Translation>) this.battlePhasePositions).FirstOrDefault<CameraMover.Translation>((Func<CameraMover.Translation, bool>) (a => a.name == phase.ToString().ToLower()));
    if (translation == null)
      return;
    LeanTween.cancel(this.gameObject);
    LeanTween.moveLocal(this.gameObject, translation.position, translation.dur).setEase(translation.ease);
    LeanTween.rotateLocal(this.gameObject, translation.rotation, translation.dur).setEase(translation.ease);
  }

  private void SceneChange(Scene scene)
  {
    LeanTween.cancel(this.gameObject);
    this.transform.localPosition = Vector3.zero;
    this.transform.localEulerAngles = Vector3.zero;
  }

  [Serializable]
  public class Translation
  {
    public string name;
    public Vector3 position;
    public Vector3 rotation;
    public LeanTweenType ease;
    public float dur;
  }
}
