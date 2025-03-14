﻿// Decompiled with JetBrains decompiler
// Type: Stat
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using Dead;
using System;
using UnityEngine;

#nullable disable
[Serializable]
public struct Stat
{
  public static readonly Stat Default = new Stat(1, 0);
  [SerializeField]
  public SafeInt safeCurrent;
  [SerializeField]
  public SafeInt safeMax;

  public int current
  {
    get => this.safeCurrent.Value;
    set => this.safeCurrent = new SafeInt(value);
  }

  public int max
  {
    get => this.safeMax.Value;
    set => this.safeMax = new SafeInt(value);
  }

  public Stat(int value)
  {
    this.safeCurrent = new SafeInt(value);
    this.safeMax = new SafeInt(value);
  }

  public Stat(int current, int max)
  {
    this.safeCurrent = new SafeInt(current);
    this.safeMax = new SafeInt(max);
  }

  public void Max() => this.safeCurrent.Value = this.safeMax.Value;

  public static Stat operator +(Stat a, int b)
  {
    return new Stat(a.safeCurrent.Value + b, a.safeMax.Value);
  }

  public static Stat operator -(Stat a, int b)
  {
    return new Stat(a.safeCurrent.Value - b, a.safeMax.Value);
  }

  public static Stat operator *(Stat a, int b)
  {
    return new Stat(a.safeCurrent.Value * b, a.safeMax.Value);
  }

  public static Stat operator +(Stat a, SafeInt b)
  {
    return new Stat(a.safeCurrent.Value + b.Value, a.safeMax.Value);
  }

  public static Stat operator -(Stat a, SafeInt b)
  {
    return new Stat(a.safeCurrent.Value - b.Value, a.safeMax.Value);
  }

  public static Stat operator *(Stat a, SafeInt b)
  {
    return new Stat(a.safeCurrent.Value * b.Value, a.safeMax.Value);
  }

  public static bool operator ==(Stat a, int b) => a.safeCurrent.Value == b;

  public static bool operator !=(Stat a, int b) => a.safeCurrent.Value != b;

  public static bool operator >(Stat a, int b) => a.safeCurrent.Value > b;

  public static bool operator >=(Stat a, int b) => a.safeCurrent.Value >= b;

  public static bool operator <(Stat a, int b) => a.safeCurrent.Value < b;

  public static bool operator <=(Stat a, int b) => a.safeCurrent.Value <= b;

  public static bool operator ==(int a, Stat b) => a == b.safeCurrent.Value;

  public static bool operator !=(int a, Stat b) => a != b.safeCurrent.Value;

  public static bool operator >(int a, Stat b) => a > b.safeCurrent.Value;

  public static bool operator >=(int a, Stat b) => a >= b.safeCurrent.Value;

  public static bool operator <(int a, Stat b) => a < b.safeCurrent.Value;

  public static bool operator <=(int a, Stat b) => a <= b.safeCurrent.Value;

  public override string ToString()
  {
    return string.Format("{0}/{1}", (object) this.safeCurrent.Value, (object) this.safeMax.Value);
  }

  public override bool Equals(object obj)
  {
    return obj is int num ? this.safeCurrent.Value == num : base.Equals(obj);
  }

  public override int GetHashCode() => base.GetHashCode();
}
