// Decompiled with JetBrains decompiler
// Type: UnlockReadyIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
public class UnlockReadyIcon : MonoBehaviour
{
  public void OnEnable() => this.Check();

  public void Check() => this.Set(MetaprogressionSystem.AnyUnlocksReady());

  public void Set(bool unlocksReady) => this.gameObject.SetActive(unlocksReady);
}
