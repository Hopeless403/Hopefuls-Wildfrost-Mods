// Decompiled with JetBrains decompiler
// Type: UnitTarget
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

public class UnitTarget : MonoBehaviour
{
  [SerializeField]
  private GameObject aimlessOverlay;
  [SerializeField]
  private GameObject frenzyUnderlay;

  public void SetAimless(bool aimless) => this.aimlessOverlay.SetActive(aimless);

  public void SetFrenzy(bool frenzy) => this.frenzyUnderlay.SetActive(frenzy);
}
