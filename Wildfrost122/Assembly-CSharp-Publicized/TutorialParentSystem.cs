// Decompiled with JetBrains decompiler
// Type: TutorialParentSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections.Generic;
using UnityEngine;

#nullable disable
public class TutorialParentSystem : GameSystem
{
  public float delay;
  public const float delayBetween = 0.0f;
  public TutorialParentSystem.Phase currentPhase;
  public List<TutorialParentSystem.Phase> phases;

  public virtual void OnEnable()
  {
  }

  public virtual void OnDisable()
  {
    if (this.currentPhase == null)
      return;
    this.currentPhase.enabled = false;
    this.currentPhase = (TutorialParentSystem.Phase) null;
  }

  public virtual void Update()
  {
    if ((double) this.delay > 0.0)
    {
      this.delay -= Time.deltaTime;
    }
    else
    {
      if (this.phases == null || this.phases.Count <= 0)
        return;
      if (this.currentPhase == null)
      {
        this.currentPhase = this.phases[0];
        this.phases.RemoveAt(0);
        this.currentPhase.enabled = true;
      }
      else
      {
        if (this.currentPhase.enabled)
          return;
        this.currentPhase = (TutorialParentSystem.Phase) null;
        this.delay = 0.0f;
        if (this.phases.Count <= 0)
          return;
        this.delay += this.phases[0].delay;
      }
    }
  }

  public abstract class Phase
  {
    public bool _enabled;

    public bool enabled
    {
      get => this._enabled;
      set
      {
        bool enabled = this._enabled;
        this._enabled = value;
        if (this._enabled)
        {
          if (enabled)
            return;
          this.OnEnable();
        }
        else
        {
          if (!enabled)
            return;
          this.OnDisable();
        }
      }
    }

    public virtual float delay => 0.0f;

    public virtual void OnEnable()
    {
    }

    public virtual void OnDisable()
    {
    }

    public static bool FreeMoveAction(PlayAction action)
    {
      return action is ActionMove actionMove && Battle.IsOnBoard(actionMove.entity) && Battle.IsOnBoard(actionMove.toContainers);
    }

    public static bool InspectAction(PlayAction action) => action is ActionInspect;
  }
}
