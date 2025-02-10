// Decompiled with JetBrains decompiler
// Type: PlatformSpecific
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.Serialization;

#nullable disable
public class PlatformSpecific : MonoBehaviour
{
  [SerializeField]
  public bool editor = true;
  [SerializeField]
  public bool windows = true;
  [SerializeField]
  public bool @switch = true;
  [SerializeField]
  public bool android = true;
  [SerializeField]
  public bool iOs = true;
  [FormerlySerializedAs("mustBeRelease")]
  [SerializeField]
  public bool release;
  [SerializeField]
  public bool demo;
  [SerializeField]
  public bool notDemo;

  public void Awake()
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
