// Decompiled with JetBrains decompiler
// Type: UnlockReadyIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
public class UnlockReadyIcon : MonoBehaviour
{
  public void OnEnable() => this.Check();

  public void Check() => this.Set(MetaprogressionSystem.AnyUnlocksReady());

  public void Set(bool unlocksReady) => this.gameObject.SetActive(unlocksReady);
}
