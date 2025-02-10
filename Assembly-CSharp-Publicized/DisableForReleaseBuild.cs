// Decompiled with JetBrains decompiler
// Type: DisableForReleaseBuild
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

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
