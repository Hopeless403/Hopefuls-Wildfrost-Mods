// Decompiled with JetBrains decompiler
// Type: SetOtherActive
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

#nullable disable
public class SetOtherActive : MonoBehaviour
{
  [SerializeField]
  public GameObject other;
  [SerializeField]
  public bool setOnEnable = true;
  [SerializeField]
  public float delay;
  [SerializeField]
  public bool setOnDisable;

  public void OnEnable()
  {
    if ((double) this.delay > 0.0)
      this.StartCoroutine(SetOtherActive.SetActiveAfter(this.other, this.setOnEnable, this.delay));
    else
      this.other.SetActive(this.setOnEnable);
  }

  public static IEnumerator SetActiveAfter(GameObject obj, bool active, float delay)
  {
    yield return (object) new WaitForSeconds(delay);
    obj.SetActive(active);
  }

  public void OnDisable()
  {
    this.StopAllCoroutines();
    this.other.SetActive(this.setOnDisable);
  }
}
