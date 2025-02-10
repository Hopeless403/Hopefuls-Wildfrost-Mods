// Decompiled with JetBrains decompiler
// Type: PlatformSpecific
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.Serialization;

#nullable disable
public class PlatformSpecific : MonoBehaviour
{
  [SerializeField]
  private bool editor = true;
  [SerializeField]
  private bool windows = true;
  [SerializeField]
  private bool @switch = true;
  [SerializeField]
  private bool android = true;
  [SerializeField]
  private bool iOs = true;
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
