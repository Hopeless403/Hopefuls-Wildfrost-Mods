// Decompiled with JetBrains decompiler
// Type: CardScriptAddRandomHealth
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Add Random Health", menuName = "Card Scripts/Add Health")]
public class CardScriptAddRandomHealth : CardScript
{
  [SerializeField]
  public Vector2Int healthRange;

  public override void Run(CardData target)
  {
    if (!target.hasHealth)
      return;
    target.hp += this.healthRange.Random();
    target.hp = Mathf.Max(1, target.hp);
  }
}
