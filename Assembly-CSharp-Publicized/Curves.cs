// Decompiled with JetBrains decompiler
// Type: Curves
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Curves : MonoBehaviourSingleton<Curves>
{
  public List<Curve> list;

  public static AnimationCurve Get(string name) => MonoBehaviourSingleton<Curves>.instance.list.First<Curve>((Func<Curve, bool>) (a => a.name == name)).curve;
}
