﻿// Decompiled with JetBrains decompiler
// Type: Sparkle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.UI;

#nullable disable
[RequireComponent(typeof (Image))]
public class Sparkle : MonoBehaviourRect
{
  public Vector2 moveSpeed = new Vector2(0.1f, -1f);
  public Vector2 moveSway = new Vector2(0.6f, 0.3f);
  public Vector2 moveSwayTime = new Vector2(0.62f, 0.49f);
  public Vector3 rotation = new Vector3(0.0f, 0.0f, 0.0f);
  public float time;
  public Image _image;
  public float _size;

  public Image image
  {
    get
    {
      if ((Object) this._image == (Object) null)
        this._image = this.GetComponent<Image>();
      return this._image;
    }
  }

  public float size
  {
    get => this._size;
    set
    {
      this._size = value;
      this.rectTransform.sizeDelta = new Vector2(this._size, this._size);
    }
  }

  public Color color
  {
    get => this.image.color;
    set => this.image.color = value;
  }

  public Sprite sprite
  {
    get => this.image.sprite;
    set => this.image.sprite = value;
  }

  public void Start()
  {
    LeanTween.cancel(this.gameObject);
    LeanTween.scale(this.gameObject, Vector3.one * 0.5f, Random.Range(1.5f, 1.75f)).setEase(LeanTweenType.easeInOutSine).setLoopPingPong();
  }

  public void Update()
  {
    this.time += Time.deltaTime;
    this.transform.localPosition = this.transform.localPosition.Add((this.moveSpeed + this.moveSway * this.moveSwayTime * Mathf.Sin(this.time)) * this.size * Time.deltaTime);
    this.transform.localEulerAngles = this.transform.localEulerAngles.Add(this.rotation * Time.deltaTime);
  }
}
