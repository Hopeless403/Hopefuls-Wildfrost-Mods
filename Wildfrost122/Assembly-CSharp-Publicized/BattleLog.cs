// Decompiled with JetBrains decompiler
// Type: BattleLog
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

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
