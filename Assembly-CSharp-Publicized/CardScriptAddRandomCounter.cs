// Decompiled with JetBrains decompiler
// Type: CardScriptAddRandomCounter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

[CreateAssetMenu(fileName = "Add Random Counter", menuName = "Card Scripts/Add Counter")]
public class CardScriptAddRandomCounter : CardScript
{
  [SerializeField]
  public Vector2Int counterRange;

  public override void Run(CardData target)
  {
    if (target.counter < 1)
      return;
    target.counter += this.counterRange.Random();
    target.counter = Mathf.Max(1, target.counter);
  }
}
