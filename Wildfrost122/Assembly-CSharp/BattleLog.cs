// Decompiled with JetBrains decompiler
// Type: BattleLog
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using UnityEngine.Localization;

#nullable disable
[Serializable]
public struct BattleLog
{
  public LocalizedString textKey;
  public object[] args;
  public BattleLogType type;
}
