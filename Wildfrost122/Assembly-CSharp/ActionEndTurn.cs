// Decompiled with JetBrains decompiler
// Type: ActionEndTurn
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

#nullable disable
public class ActionEndTurn : PlayAction
{
  public readonly Character character;

  public ActionEndTurn(Character character) => this.character = character;

  public override bool IsRoutine => false;

  public override void Process() => this.character.endTurn = true;
}
