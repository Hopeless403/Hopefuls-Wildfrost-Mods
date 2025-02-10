// Decompiled with JetBrains decompiler
// Type: AvatarPoser
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using Dead;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class AvatarPoser : MonoBehaviour
{
  [SerializeField]
  private Image faceImage;
  [SerializeField]
  private Image bodyImage;
  [SerializeField]
  [Range(0.0f, 2f)]
  private float pingStrength = 1f;
  [SerializeField]
  private Vector2 poseTime = new Vector2(1.5f, 2f);
  [SerializeField]
  private AvatarPoser.Pose[] poses;
  private readonly Dictionary<string, AvatarPoser.Pose> poseLookup = new Dictionary<string, AvatarPoser.Pose>();
  private Sprite baseFaceSprite;
  private Sprite baseBodySprite;
  private Vector3 scale;
  private float reset;

  private void Awake()
  {
    this.scale = this.transform.localScale;
    this.poseLookup.Clear();
    foreach (AvatarPoser.Pose pose in this.poses)
      this.poseLookup[pose.name] = pose;
    if ((bool) (UnityEngine.Object) this.faceImage)
      this.baseFaceSprite = this.faceImage.sprite;
    if (!(bool) (UnityEngine.Object) this.bodyImage)
      return;
    this.baseBodySprite = this.bodyImage.sprite;
  }

  private void Update()
  {
    if ((double) this.reset <= 0.0)
      return;
    this.reset -= Time.deltaTime;
    if ((double) this.reset > 0.0)
      return;
    if ((bool) (UnityEngine.Object) this.faceImage)
      this.faceImage.sprite = this.baseFaceSprite;
    if ((bool) (UnityEngine.Object) this.bodyImage)
      this.bodyImage.sprite = this.baseBodySprite;
    this.Ping();
  }

  public void Set(string poseName)
  {
    AvatarPoser.Pose pose;
    if (!this.poseLookup.TryGetValue(poseName, out pose))
      return;
    if ((bool) (UnityEngine.Object) this.faceImage && pose.setFace)
      this.faceImage.sprite = pose.face[PettyRandom.Range(0, pose.face.Length - 1)];
    if ((bool) (UnityEngine.Object) this.bodyImage && pose.setBody)
      this.bodyImage.sprite = pose.body[PettyRandom.Range(0, pose.body.Length - 1)];
    this.reset = this.poseTime.PettyRandom();
    this.Ping();
  }

  private void Ping()
  {
    if ((double) this.pingStrength <= 0.0)
      return;
    LeanTween.cancel(this.gameObject);
    float num = (float) (1.0 + 0.05000000074505806 * (double) this.pingStrength);
    this.transform.localScale = new Vector3(num * this.scale.x, 1f / num * this.scale.y, this.scale.z);
    LeanTween.scale(this.gameObject, this.scale, 1f).setEase(LeanTweenType.easeOutElastic);
  }

  [Serializable]
  public struct Pose
  {
    public string name;
    public bool setFace;
    public Sprite[] face;
    public bool setBody;
    public Sprite[] body;
  }
}
