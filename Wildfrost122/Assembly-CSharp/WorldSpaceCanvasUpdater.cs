// Decompiled with JetBrains decompiler
// Type: WorldSpaceCanvasUpdater
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

#nullable disable
public abstract class WorldSpaceCanvasUpdater : MonoBehaviourRect
{
  private void OnEnable()
  {
    WorldSpaceCanvasFitScreenSystem.Register(this);
    this.UpdateSize();
  }

  private void OnDisable() => WorldSpaceCanvasFitScreenSystem.Unregister(this);

  public virtual void UpdateSize()
  {
  }
}
