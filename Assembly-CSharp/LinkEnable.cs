// Decompiled with JetBrains decompiler
// Type: LinkEnable
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

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
