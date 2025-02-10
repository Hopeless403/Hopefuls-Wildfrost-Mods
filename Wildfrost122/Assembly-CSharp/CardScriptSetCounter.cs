// Decompiled with JetBrains decompiler
// Type: CardScriptSetCounter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Set Counter", menuName = "Card Scripts/Set Counter")]
public class CardScriptSetCounter : CardScript
{
  [SerializeField]
  private Vector2Int counterRange;

  public override void Run(CardData target)
  {
    if (target.counter < 1)
      return;
    target.counter = this.counterRange.Random();
    target.counter = Mathf.Max(1, target.counter);
  }
}
