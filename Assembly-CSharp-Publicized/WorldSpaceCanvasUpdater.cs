// Decompiled with JetBrains decompiler
// Type: WorldSpaceCanvasUpdater
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

public abstract class WorldSpaceCanvasUpdater : MonoBehaviourRect
{
  public void OnEnable()
  {
    WorldSpaceCanvasFitScreenSystem.Register(this);
    this.UpdateSize();
  }

  public void OnDisable() => WorldSpaceCanvasFitScreenSystem.Unregister(this);

  public virtual void UpdateSize()
  {
  }
}
