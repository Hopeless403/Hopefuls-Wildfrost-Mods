// Decompiled with JetBrains decompiler
// Type: DisableForReleaseBuild
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

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
