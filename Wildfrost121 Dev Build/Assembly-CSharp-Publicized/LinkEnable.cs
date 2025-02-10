// Decompiled with JetBrains decompiler
// Type: LinkEnable
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

#nullable disable
public class LinkEnable : MonoBehaviour
{
  public GameObject linkTo;

  public void OnEnable() => this.StartCoroutine(this.EnableAfterEndOfFrame());

  public IEnumerator EnableAfterEndOfFrame()
  {
    yield return (object) new WaitForEndOfFrame();
    this.linkTo.gameObject.SetActive(true);
  }

  public void OnDisable()
  {
    this.StopAllCoroutines();
    this.linkTo.gameObject.SetActive(false);
  }
}
