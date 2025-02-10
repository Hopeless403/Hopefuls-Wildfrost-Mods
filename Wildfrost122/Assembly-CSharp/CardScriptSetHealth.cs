// Decompiled with JetBrains decompiler
// Type: CardScriptSetHealth
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Set Health", menuName = "Card Scripts/Set Health")]
public class CardScriptSetHealth : CardScript
{
  [SerializeField]
  private Vector2Int healthRange;

  public override void Run(CardData target)
  {
    if (!target.hasHealth)
      return;
    target.hp = this.healthRange.Random();
    target.hp = Mathf.Max(1, target.hp);
  }
}
