// Decompiled with JetBrains decompiler
// Type: TutorialParentSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections.Generic;
using UnityEngine;

public class TutorialParentSystem : GameSystem
{
  protected float delay;
  private const float delayBetween = 0.0f;
  protected TutorialParentSystem.Phase currentPhase;
  protected List<TutorialParentSystem.Phase> phases;

  protected virtual void OnEnable()
  {
  }

  protected virtual void OnDisable()
  {
    if (this.currentPhase == null)
      return;
    this.currentPhase.enabled = false;
    this.currentPhase = (TutorialParentSystem.Phase) null;
  }

  protected virtual void Update()
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

  protected abstract class Phase
  {
    private bool _enabled;

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

    protected virtual void OnEnable()
    {
    }

    protected virtual void OnDisable()
    {
    }

    protected static bool FreeMoveAction(PlayAction action) => action is ActionMove actionMove && Battle.IsOnBoard(actionMove.entity) && Battle.IsOnBoard(actionMove.toContainers);

    protected static bool InspectAction(PlayAction action) => action is ActionInspect;
  }
}
