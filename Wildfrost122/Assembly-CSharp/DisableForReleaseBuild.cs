// Decompiled with JetBrains decompiler
// Type: DisableForReleaseBuild
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
public class DisableForReleaseBuild : MonoBehaviour
{
  [SerializeField]
  private bool disableGameObject = true;
  [SerializeField]
  private bool disableComponent;

  private void OnEnable()
  {
    if (this.disableGameObject)
      this.gameObject.SetActive(false);
    if (!this.disableComponent)
      return;
    this.enabled = false;
  }
}
