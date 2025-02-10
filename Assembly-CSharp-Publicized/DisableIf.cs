// Decompiled with JetBrains decompiler
// Type: DisableIf
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

public class DisableIf : MonoBehaviour
{
  [SerializeField]
  public bool not;
  [SerializeField]
  public bool RELEASE;
  [SerializeField]
  public bool DEMO;
  [SerializeField]
  public bool CHALLENGES;
  [SerializeField]
  public bool BATTLE_LOG;
  [SerializeField]
  public bool ANALYTICS;
  [SerializeField]
  public bool JOURNAL_PAGES;
  [SerializeField]
  public bool HARD_MODE;
  [SerializeField]
  public bool CANNOT_EXIT;
  [SerializeField]
  public bool BETA;
  [SerializeField]
  public bool NEW_FROST_BELLS;
  [SerializeField]
  public bool destroy;

  public void OnEnable()
  {
    bool flag = false;
    if (this.RELEASE)
      flag = true;
    if (this.CHALLENGES)
      flag = true;
    if (this.BATTLE_LOG)
      flag = true;
    if (this.JOURNAL_PAGES)
      flag = true;
    if (this.NEW_FROST_BELLS)
      flag = true;
    if ((!this.not || flag) && !(!this.not & flag))
      return;
    this.Disable();
  }

  public void Disable()
  {
    if (this.destroy)
      this.gameObject.DestroyImmediate();
    else
      this.gameObject.SetActive(false);
  }
}
