// Decompiled with JetBrains decompiler
// Type: AvatarPoseSetter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using System.Collections;
using UnityEngine;

public class AvatarPoseSetter : MonoBehaviour
{
  [SerializeField]
  public bool onAwake;
  [SerializeField]
  [HideIf("onAwake")]
  public bool onEnable = true;
  [SerializeField]
  public AvatarPoser poser;
  [SerializeField]
  public string[] poseOptions = new string[2]{ "", "Greet" };
  [SerializeField]
  public Vector2 delay = new Vector2(0.5f, 1.5f);

  public void Awake()
  {
    if (!this.onAwake)
      return;
    this.StartCoroutine(this.Run());
  }

  public void OnEnable()
  {
    if (this.onAwake || !this.onEnable)
      return;
    this.StartCoroutine(this.Run());
  }

  public void OnDisable() => this.StopAllCoroutines();

  public IEnumerator Run()
  {
    yield return (object) new WaitForSeconds(this.delay.PettyRandom());
    if ((bool) (Object) this.poser && this.poseOptions != null && this.poseOptions.Length != 0)
      this.poser.Set(this.poseOptions.RandomItem<string>());
  }
}
