// Decompiled with JetBrains decompiler
// Type: EventManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

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
