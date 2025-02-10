// Decompiled with JetBrains decompiler
// Type: Curves
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Curves : MonoBehaviourSingleton<Curves>
{
  public List<Curve> list;

  public static AnimationCurve Get(string name) => MonoBehaviourSingleton<Curves>.instance.list.First<Curve>((Func<Curve, bool>) (a => a.name == name)).curve;
}
