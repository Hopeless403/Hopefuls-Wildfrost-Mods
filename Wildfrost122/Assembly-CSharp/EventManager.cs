// Decompiled with JetBrains decompiler
// Type: EventManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
public class EventManager : MonoBehaviour
{
  public static EventManager instance;
  public Transform eventRoutineHolder;
  [SerializeField]
  private TweenUI enterTween;

  private void Awake() => EventManager.instance = this;

  public static Transform EventRoutineHolder => EventManager.instance.eventRoutineHolder;

  private void OnEnable()
  {
    if (!GameManager.Ready)
      return;
    CinemaBarSystem.InInstant();
    this.enterTween.Fire();
  }

  private void OnDisable() => CinemaBarSystem.OutInstant();
}
