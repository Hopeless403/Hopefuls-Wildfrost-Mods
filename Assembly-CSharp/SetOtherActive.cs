// Decompiled with JetBrains decompiler
// Type: SetOtherActive
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

public class SetOtherActive : MonoBehaviour
{
  [SerializeField]
  private GameObject other;
  [SerializeField]
  private bool setOnEnable = true;
  [SerializeField]
  private float delay;
  [SerializeField]
  private bool setOnDisable;

  private void OnEnable()
  {
    if ((double) this.delay > 0.0)
      this.StartCoroutine(SetOtherActive.SetActiveAfter(this.other, this.setOnEnable, this.delay));
    else
      this.other.SetActive(this.setOnEnable);
  }

  private static IEnumerator SetActiveAfter(GameObject obj, bool active, float delay)
  {
    yield return (object) new WaitForSeconds(delay);
    obj.SetActive(active);
  }

  private void OnDisable()
  {
    this.StopAllCoroutines();
    this.other.SetActive(this.setOnDisable);
  }
}
