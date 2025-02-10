// Decompiled with JetBrains decompiler
// Type: UnitTarget
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
public class UnitTarget : MonoBehaviour
{
  [SerializeField]
  private GameObject aimlessOverlay;
  [SerializeField]
  private GameObject frenzyUnderlay;

  public void SetAimless(bool aimless) => this.aimlessOverlay.SetActive(aimless);

  public void SetFrenzy(bool frenzy) => this.frenzyUnderlay.SetActive(frenzy);
}
