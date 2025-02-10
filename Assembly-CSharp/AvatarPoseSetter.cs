// Decompiled with JetBrains decompiler
// Type: AvatarPoseSetter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using System.Collections;
using UnityEngine;

public class AvatarPoseSetter : MonoBehaviour
{
  [SerializeField]
  private bool onAwake;
  [SerializeField]
  [HideIf("onAwake")]
  private bool onEnable = true;
  [SerializeField]
  private AvatarPoser poser;
  [SerializeField]
  private string[] poseOptions = new string[2]
  {
    "",
    "Greet"
  };
  [SerializeField]
  private Vector2 delay = new Vector2(0.5f, 1.5f);

  private void Awake()
  {
    if (!this.onAwake)
      return;
    this.StartCoroutine(this.Run());
  }

  private void OnEnable()
  {
    if (this.onAwake || !this.onEnable)
      return;
    this.StartCoroutine(this.Run());
  }

  private void OnDisable() => this.StopAllCoroutines();

  private IEnumerator Run()
  {
    yield return (object) new WaitForSeconds(this.delay.PettyRandom());
    if ((bool) (Object) this.poser && this.poseOptions != null && this.poseOptions.Length != 0)
      this.poser.Set(this.poseOptions.RandomItem<string>());
  }
}
