// Decompiled with JetBrains decompiler
// Type: UINavigationLayer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
public class UINavigationLayer : MonoBehaviour
{
  public static uint idMax;
  public uint id;
  public bool isOverrideLayer = true;
  public bool setStartingItem = true;
  public bool allowOutsideVisibleSelection;
  public bool allowLayerToBeAppliedAtRuntime = true;
  public bool forceHover = true;

  public void Awake() => this.id = UINavigationLayer.idMax++;

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
