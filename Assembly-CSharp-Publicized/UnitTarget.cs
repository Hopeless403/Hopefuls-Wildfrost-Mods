// Decompiled with JetBrains decompiler
// Type: UnitTarget
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

public class UnitTarget : MonoBehaviour
{
  [SerializeField]
  public GameObject aimlessOverlay;
  [SerializeField]
  public GameObject frenzyUnderlay;

  public void SetAimless(bool aimless) => this.aimlessOverlay.SetActive(aimless);

  public void SetFrenzy(bool frenzy) => this.frenzyUnderlay.SetActive(frenzy);
}
