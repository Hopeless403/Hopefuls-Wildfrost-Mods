// Decompiled with JetBrains decompiler
// Type: CameraMover
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
public class CameraMover : GameSystem
{
  [SerializeField]
  public CameraMover.Translation[] battlePhasePositions;

  public void OnEnable()
  {
    global::Events.OnBattlePhaseStart += new UnityAction<Battle.Phase>(this.BattlePhaseStart);
    global::Events.OnSceneChanged += new UnityAction<Scene>(this.SceneChange);
  }

  public void OnDisable()
  {
    global::Events.OnBattlePhaseStart -= new UnityAction<Battle.Phase>(this.BattlePhaseStart);
    global::Events.OnSceneChanged -= new UnityAction<Scene>(this.SceneChange);
  }

  public void BattlePhaseStart(Battle.Phase phase)
  {
    CameraMover.Translation translation = ((IEnumerable<CameraMover.Translation>) this.battlePhasePositions).FirstOrDefault<CameraMover.Translation>((Func<CameraMover.Translation, bool>) (a => a.name == phase.ToString().ToLower()));
    if (translation == null)
      return;
    LeanTween.cancel(this.gameObject);
    LeanTween.moveLocal(this.gameObject, translation.position, translation.dur).setEase(translation.ease);
    LeanTween.rotateLocal(this.gameObject, translation.rotation, translation.dur).setEase(translation.ease);
  }

  public void SceneChange(Scene scene)
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
