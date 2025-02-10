// Decompiled with JetBrains decompiler
// Type: EventManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
public class EventManager : MonoBehaviour
{
  public static EventManager instance;
  public Transform eventRoutineHolder;
  [SerializeField]
  public TweenUI enterTween;

  public void Awake() => EventManager.instance = this;

  public static Transform EventRoutineHolder => EventManager.instance.eventRoutineHolder;

  public void OnEnable()
  {
    if (!GameManager.Ready)
      return;
    CinemaBarSystem.InInstant();
    this.enterTween.Fire();
  }

  public void OnDisable() => CinemaBarSystem.OutInstant();
}
