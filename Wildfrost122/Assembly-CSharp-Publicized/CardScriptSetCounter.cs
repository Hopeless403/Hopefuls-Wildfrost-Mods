// Decompiled with JetBrains decompiler
// Type: CardScriptSetCounter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "Set Counter", menuName = "Card Scripts/Set Counter")]
public class CardScriptSetCounter : CardScript
{
  [SerializeField]
  public Vector2Int counterRange;

  public override void Run(CardData target)
  {
    if (target.counter < 1)
      return;
    target.counter = this.counterRange.Random();
    target.counter = Mathf.Max(1, target.counter);
  }
}
