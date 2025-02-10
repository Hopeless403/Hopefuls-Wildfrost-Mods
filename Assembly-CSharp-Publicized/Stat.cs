// Decompiled with JetBrains decompiler
// Type: Stat
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using Dead;
using System;
using UnityEngine;

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

  public static Stat operator +(Stat a, int b) => new Stat(a.safeCurrent.Value + b, a.safeMax.Value);

  public static Stat operator -(Stat a, int b) => new Stat(a.safeCurrent.Value - b, a.safeMax.Value);

  public static Stat operator *(Stat a, int b) => new Stat(a.safeCurrent.Value * b, a.safeMax.Value);

  public static Stat operator +(Stat a, SafeInt b) => new Stat(a.safeCurrent.Value + b.Value, a.safeMax.Value);

  public static Stat operator -(Stat a, SafeInt b) => new Stat(a.safeCurrent.Value - b.Value, a.safeMax.Value);

  public static Stat operator *(Stat a, SafeInt b) => new Stat(a.safeCurrent.Value * b.Value, a.safeMax.Value);

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

  public override string ToString() => string.Format("{0}/{1}", (object) this.safeCurrent.Value, (object) this.safeMax.Value);

  public override bool Equals(object obj) => obj is int num ? this.safeCurrent.Value == num : base.Equals(obj);

  public override int GetHashCode() => base.GetHashCode();
}
