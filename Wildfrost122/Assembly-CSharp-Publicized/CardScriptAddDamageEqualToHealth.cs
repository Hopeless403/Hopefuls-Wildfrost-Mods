// Decompiled with JetBrains decompiler
// Type: CardScriptAddDamageEqualToHealth
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Add Damage Equal To Health", menuName = "Card Scripts/Add Damage Equal To Health")]
public class CardScriptAddDamageEqualToHealth : CardScript
{
  public override void Run(CardData target) => target.damage += target.hp;
}
