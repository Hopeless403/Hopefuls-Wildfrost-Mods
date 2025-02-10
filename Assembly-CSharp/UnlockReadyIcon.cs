// Decompiled with JetBrains decompiler
// Type: UnlockReadyIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

public class UnlockReadyIcon : MonoBehaviour
{
  private void OnEnable() => this.Check();

  private void Check() => this.Set(MetaprogressionSystem.AnyUnlocksReady());

  public void Set(bool unlocksReady) => this.gameObject.SetActive(unlocksReady);
}
