// Decompiled with JetBrains decompiler
// Type: RewardPool
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections.Generic;
using UnityEngine;

#nullable disable
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
