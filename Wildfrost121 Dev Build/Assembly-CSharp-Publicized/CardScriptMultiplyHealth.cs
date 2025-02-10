// Decompiled with JetBrains decompiler
// Type: CardScriptMultiplyHealth
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Multiply Health", menuName = "Card Scripts/Multiply Health")]
public class CardScriptMultiplyHealth : CardScript
{
  [SerializeField]
  public float multiply;
  [SerializeField]
  public bool roundUp;

  public override void Run(CardData target)
  {
    target.hp = this.roundUp ? Mathf.CeilToInt((float) target.hp * this.multiply) : Mathf.RoundToInt((float) target.hp * this.multiply);
    target.hp = Mathf.Max(1, target.hp);
  }
}
