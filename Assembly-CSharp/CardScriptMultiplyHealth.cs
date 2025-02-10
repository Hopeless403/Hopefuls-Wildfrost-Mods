// Decompiled with JetBrains decompiler
// Type: CardScriptMultiplyHealth
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

[CreateAssetMenu(fileName = "Multiply Health", menuName = "Card Scripts/Multiply Health")]
public class CardScriptMultiplyHealth : CardScript
{
  [SerializeField]
  private float multiply;
  [SerializeField]
  private bool roundUp;

  public override void Run(CardData target)
  {
    target.hp = this.roundUp ? Mathf.CeilToInt((float) target.hp * this.multiply) : Mathf.RoundToInt((float) target.hp * this.multiply);
    target.hp = Mathf.Max(1, target.hp);
  }
}
