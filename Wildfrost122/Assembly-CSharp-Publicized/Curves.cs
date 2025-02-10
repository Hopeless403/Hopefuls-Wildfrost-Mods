// Decompiled with JetBrains decompiler
// Type: Curves
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
public class Curves : MonoBehaviourSingleton<Curves>
{
  public List<Curve> list;

  public static AnimationCurve Get(string name)
  {
    return MonoBehaviourSingleton<Curves>.instance.list.First<Curve>((Func<Curve, bool>) (a => a.name == name)).curve;
  }
}
