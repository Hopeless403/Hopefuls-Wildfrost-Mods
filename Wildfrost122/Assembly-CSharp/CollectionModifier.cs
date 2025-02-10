// Decompiled with JetBrains decompiler
// Type: CollectionModifier
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "CollectionModifier", menuName = "Character/Collection Modifier")]
public class CollectionModifier : ScriptableObject
{
  public CollectionModifier.Modify[] list;

  [Serializable]
  public struct Modify
  {
    public int index;
    public float addWeight;
  }
}
