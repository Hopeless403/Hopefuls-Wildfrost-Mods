// Decompiled with JetBrains decompiler
// Type: AvatarPoser
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using Dead;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AvatarPoser : MonoBehaviour
{
  [SerializeField]
  public Image faceImage;
  [SerializeField]
  public Image bodyImage;
  [SerializeField]
  [Range(0.0f, 2f)]
  public float pingStrength = 1f;
  [SerializeField]
  public Vector2 poseTime = new Vector2(1.5f, 2f);
  [SerializeField]
  public AvatarPoser.Pose[] poses;
  public readonly Dictionary<string, AvatarPoser.Pose> poseLookup = new Dictionary<string, AvatarPoser.Pose>();
  public Sprite baseFaceSprite;
  public Sprite baseBodySprite;
  public Vector3 scale;
  public float reset;

  public void Awake()
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

  public void Update()
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

  public void Ping()
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
