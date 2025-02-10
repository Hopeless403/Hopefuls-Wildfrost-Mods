// Decompiled with JetBrains decompiler
// Type: LinkEnable
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

#nullable disable
public class LinkEnable : MonoBehaviour
{
  public GameObject linkTo;

  private void OnEnable() => this.StartCoroutine(this.EnableAfterEndOfFrame());

  private IEnumerator EnableAfterEndOfFrame()
  {
    yield return (object) new WaitForEndOfFrame();
    this.linkTo.gameObject.SetActive(true);
  }

  private void OnDisable()
  {
    this.StopAllCoroutines();
    this.linkTo.gameObject.SetActive(false);
  }
}
