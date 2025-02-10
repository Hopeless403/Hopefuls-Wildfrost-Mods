// Decompiled with JetBrains decompiler
// Type: UINavigationLayer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
public class UINavigationLayer : MonoBehaviour
{
  private static uint idMax;
  private uint id;
  public bool isOverrideLayer = true;
  public bool setStartingItem = true;
  public bool allowOutsideVisibleSelection;
  public bool allowLayerToBeAppliedAtRuntime = true;
  public bool forceHover = true;

  private void Awake() => this.id = UINavigationLayer.idMax++;

  public void OnEnable()
  {
    MonoBehaviourSingleton<UINavigationSystem>.instance.RegisterNavigationLayer(this);
  }

  public void OnDisable()
  {
    MonoBehaviourSingleton<UINavigationSystem>.instance.UnregisterNavigationLayer(this);
  }

  public override bool Equals(object other)
  {
    return other is UINavigationLayer uiNavigationLayer && (int) uiNavigationLayer.id == (int) this.id;
  }
}
