// Decompiled with JetBrains decompiler
// Type: CameraAnimationSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CameraAnimationSystem : GameSystem
{
  public Transform target;
  public CameraAnimationSystem.Animation[] animations;
  public Dictionary<string, CameraAnimationSystem.Animation> lookup;
  public List<CameraAnimationSystem.RunCurve> running = new List<CameraAnimationSystem.RunCurve>();

  public void OnEnable()
  {
    this.lookup = new Dictionary<string, CameraAnimationSystem.Animation>();
    foreach (CameraAnimationSystem.Animation animation in this.animations)
      this.lookup[animation.name] = animation;
    this.running.Clear();
    global::Events.OnCameraAnimation += new UnityAction<string>(this.Run);
  }

  public void OnDisable() => global::Events.OnCameraAnimation -= new UnityAction<string>(this.Run);

  public void Update()
  {
    int count = this.running.Count;
    if (count <= 0)
      return;
    Vector3 zero1 = Vector3.zero;
    Vector3 zero2 = Vector3.zero;
    float deltaTime = Time.deltaTime;
    for (int index = count - 1; index >= 0; --index)
    {
      CameraAnimationSystem.RunCurve runCurve = this.running[index];
      runCurve.Update(deltaTime);
      zero1 += runCurve.GetPosOffset();
      zero2 += runCurve.GetRotOffset();
      if (runCurve.IsDone)
        this.running.RemoveAt(index);
    }
    this.target.localPosition = zero1;
    this.target.localEulerAngles = zero2;
  }

  public void Run(string name)
  {
    if (!this.lookup.ContainsKey(name))
      return;
    this.Run(this.lookup[name]);
  }

  public void Run(CameraAnimationSystem.Animation animation)
  {
    foreach (CameraAnimationSystem.Curve curve in animation.curves)
      this.running.Add(new CameraAnimationSystem.RunCurve(curve));
  }

  [Serializable]
  public struct Animation
  {
    public string name;
    public CameraAnimationSystem.Curve[] curves;
  }

  [Serializable]
  public struct Curve
  {
    public AnimationCurve curve;
    public Vector3 moveAmount;
    public Vector3 rotateAmount;
    public Vector2 durationRange;
  }

  public class RunCurve
  {
    public CameraAnimationSystem.Curve curve;
    public float time;
    public float duration;
    public float value;

    public bool IsDone => (double) this.time >= (double) this.duration;

    public RunCurve(CameraAnimationSystem.Curve curve)
    {
      this.curve = curve;
      this.duration = curve.durationRange.PettyRandom();
    }

    public void Update(float delta)
    {
      this.time += delta;
      this.value = this.curve.curve.Evaluate(this.time / this.duration);
    }

    public Vector3 GetPosOffset() => this.curve.moveAmount * this.value;

    public Vector3 GetRotOffset() => this.curve.rotateAmount * this.value;
  }
}
