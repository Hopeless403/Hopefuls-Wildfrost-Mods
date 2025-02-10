// Decompiled with JetBrains decompiler
// Type: CardScriptAddRandomCounter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

[CreateAssetMenu(fileName = "Add Random Counter", menuName = "Card Scripts/Add Counter")]
public class CardScriptAddRandomCounter : CardScript
{
  [SerializeField]
  private Vector2Int counterRange;

  public override void Run(CardData target)
  {
    if (target.counter < 1)
      return;
    target.counter += this.counterRange.Random();
    target.counter = Mathf.Max(1, target.counter);
  }
}
