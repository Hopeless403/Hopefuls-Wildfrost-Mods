// Decompiled with JetBrains decompiler
// Type: CameraAnimationSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CameraAnimationSystem : GameSystem
{
  public Transform target;
  public CameraAnimationSystem.Animation[] animations;
  private Dictionary<string, CameraAnimationSystem.Animation> lookup;
  private List<CameraAnimationSystem.RunCurve> running = new List<CameraAnimationSystem.RunCurve>();

  private void OnEnable()
  {
    this.lookup = new Dictionary<string, CameraAnimationSystem.Animation>();
    foreach (CameraAnimationSystem.Animation animation in this.animations)
      this.lookup[animation.name] = animation;
    this.running.Clear();
    global::Events.OnCameraAnimation += new UnityAction<string>(this.Run);
  }

  private void OnDisable() => global::Events.OnCameraAnimation -= new UnityAction<string>(this.Run);

  private void Update()
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

  private void Run(string name)
  {
    if (!this.lookup.ContainsKey(name))
      return;
    this.Run(this.lookup[name]);
  }

  private void Run(CameraAnimationSystem.Animation animation)
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
    private CameraAnimationSystem.Curve curve;
    private float time;
    private float duration;
    private float value;

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
