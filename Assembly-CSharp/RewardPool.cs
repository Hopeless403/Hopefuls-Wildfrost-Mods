// Decompiled with JetBrains decompiler
// Type: RewardPool
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Reward Pool", fileName = "RewardPool")]
public class RewardPool : ScriptableObject
{
  public string type;
  public int copies = 1;
  public List<DataFile> list;
  public bool isGeneralPool;

  public enum Type
  {
    Items,
    Units,
    Charms,
  }
}
