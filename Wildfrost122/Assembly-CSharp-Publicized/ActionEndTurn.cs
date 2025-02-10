// Decompiled with JetBrains decompiler
// Type: ActionEndTurn
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

#nullable disable
public class ActionEndTurn : PlayAction
{
  public readonly Character character;

  public ActionEndTurn(Character character) => this.character = character;

  public override bool IsRoutine => false;

  public override void Process() => this.character.endTurn = true;
}
