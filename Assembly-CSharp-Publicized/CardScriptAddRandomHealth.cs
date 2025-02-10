// Decompiled with JetBrains decompiler
// Type: CardScriptAddRandomHealth
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

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
