// Decompiled with JetBrains decompiler
// Type: PlatformSpecific
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.Serialization;

public class PlatformSpecific : MonoBehaviour
{
  [SerializeField]
  private bool editor = true;
  [SerializeField]
  private bool windows = true;
  [SerializeField]
  private bool @switch = true;
  [FormerlySerializedAs("mustBeRelease")]
  [SerializeField]
  private bool release;
  [SerializeField]
  private bool demo;
  [SerializeField]
  private bool notDemo;

  private void Awake()
  {
    bool flag = true;
    if (!this.windows)
      flag = false;
    if (this.demo)
      flag = false;
    if (flag)
      return;
    this.gameObject.SetActive(false);
  }
}
