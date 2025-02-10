// Decompiled with JetBrains decompiler
// Type: LTSeq
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using UnityEngine;

public class LTSeq
{
  public LTSeq previous;
  public LTSeq current;
  public LTDescr tween;
  public float totalDelay;
  public float timeScale;
  public int debugIter;
  public uint counter;
  public bool toggle;
  public uint _id;

  public int id => (int) this._id | (int) this.counter << 16;

  public void reset()
  {
    this.previous = (LTSeq) null;
    this.tween = (LTDescr) null;
    this.totalDelay = 0.0f;
  }

  public void init(uint id, uint global_counter)
  {
    this.reset();
    this._id = id;
    this.counter = global_counter;
    this.current = this;
  }

  public LTSeq addOn()
  {
    this.current.toggle = true;
    LTSeq current = this.current;
    this.current = LeanTween.sequence();
    this.current.previous = current;
    current.toggle = false;
    this.current.totalDelay = current.totalDelay;
    this.current.debugIter = current.debugIter + 1;
    return this.current;
  }

  public float addPreviousDelays()
  {
    LTSeq previous = this.current.previous;
    return previous != null && previous.tween != null ? this.current.totalDelay + previous.tween.time : this.current.totalDelay;
  }

  public LTSeq append(float delay)
  {
    this.current.totalDelay += delay;
    return this.current;
  }

  public LTSeq append(System.Action callback) => this.append(LeanTween.delayedCall(0.0f, callback));

  public LTSeq append(Action<object> callback, object obj)
  {
    this.append(LeanTween.delayedCall(0.0f, callback).setOnCompleteParam(obj));
    return this.addOn();
  }

  public LTSeq append(GameObject gameObject, System.Action callback)
  {
    this.append(LeanTween.delayedCall(gameObject, 0.0f, callback));
    return this.addOn();
  }

  public LTSeq append(GameObject gameObject, Action<object> callback, object obj)
  {
    this.append(LeanTween.delayedCall(gameObject, 0.0f, callback).setOnCompleteParam(obj));
    return this.addOn();
  }

  public LTSeq append(LTDescr tween)
  {
    this.current.tween = tween;
    this.current.totalDelay = this.addPreviousDelays();
    tween.setDelay(this.current.totalDelay);
    return this.addOn();
  }

  public LTSeq insert(LTDescr tween)
  {
    this.current.tween = tween;
    tween.setDelay(this.addPreviousDelays());
    return this.addOn();
  }

  public LTSeq setScale(float timeScale)
  {
    this.setScaleRecursive(this.current, timeScale, 500);
    return this.addOn();
  }

  public void setScaleRecursive(LTSeq seq, float timeScale, int count)
  {
    if (count <= 0)
      return;
    this.timeScale = timeScale;
    seq.totalDelay *= timeScale;
    if (seq.tween != null)
    {
      if ((double) seq.tween.time != 0.0)
        seq.tween.setTime(seq.tween.time * timeScale);
      seq.tween.setDelay(seq.tween.delay * timeScale);
    }
    if (seq.previous == null)
      return;
    this.setScaleRecursive(seq.previous, timeScale, count - 1);
  }

  public LTSeq reverse() => this.addOn();
}
