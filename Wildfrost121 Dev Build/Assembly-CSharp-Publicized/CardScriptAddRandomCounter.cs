// Decompiled with JetBrains decompiler
// Type: CardScriptAddRandomCounter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
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
