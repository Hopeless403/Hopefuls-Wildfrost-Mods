// Decompiled with JetBrains decompiler
// Type: UnitTarget
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
public class UnitTarget : MonoBehaviour
{
  [SerializeField]
  public GameObject aimlessOverlay;
  [SerializeField]
  public GameObject frenzyUnderlay;

  public void SetAimless(bool aimless) => this.aimlessOverlay.SetActive(aimless);

  public void SetFrenzy(bool frenzy) => this.frenzyUnderlay.SetActive(frenzy);
}
