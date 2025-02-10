// Decompiled with JetBrains decompiler
// Type: UINavigationLayer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

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

  public void OnEnable() => MonoBehaviourSingleton<UINavigationSystem>.instance.RegisterNavigationLayer(this);

  public void OnDisable() => MonoBehaviourSingleton<UINavigationSystem>.instance.UnregisterNavigationLayer(this);

  public override bool Equals(object other) => other is UINavigationLayer uiNavigationLayer && (int) uiNavigationLayer.id == (int) this.id;
}
