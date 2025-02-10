// Decompiled with JetBrains decompiler
// Type: CollectionModifier
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using UnityEngine;

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
