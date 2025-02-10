// Decompiled with JetBrains decompiler
// Type: DisableForReleaseBuild
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
public class DisableForReleaseBuild : MonoBehaviour
{
  [SerializeField]
  public bool disableGameObject = true;
  [SerializeField]
  public bool disableComponent;

  public void OnEnable()
  {
    if (this.disableGameObject)
      this.gameObject.SetActive(false);
    if (!this.disableComponent)
      return;
    this.enabled = false;
  }
}
