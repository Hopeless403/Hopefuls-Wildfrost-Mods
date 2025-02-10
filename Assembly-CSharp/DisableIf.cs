// Decompiled with JetBrains decompiler
// Type: DisableIf
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

public class DisableIf : MonoBehaviour
{
  [SerializeField]
  private bool not;
  [SerializeField]
  private bool RELEASE;
  [SerializeField]
  private bool DEMO;
  [SerializeField]
  private bool CHALLENGES;
  [SerializeField]
  private bool BATTLE_LOG;
  [SerializeField]
  private bool ANALYTICS;
  [SerializeField]
  private bool JOURNAL_PAGES;
  [SerializeField]
  private bool HARD_MODE;
  [SerializeField]
  private bool CANNOT_EXIT;
  [SerializeField]
  private bool BETA;
  [SerializeField]
  private bool NEW_FROST_BELLS;
  [SerializeField]
  private bool destroy;

  private void OnEnable()
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

  private void Disable()
  {
    if (this.destroy)
      this.gameObject.DestroyImmediate();
    else
      this.gameObject.SetActive(false);
  }
}
