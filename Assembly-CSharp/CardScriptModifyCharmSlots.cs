// Decompiled with JetBrains decompiler
// Type: CardScriptModifyCharmSlots
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

[CreateAssetMenu(fileName = "Modify Upgrade Slots", menuName = "Card Scripts/Modify Upgrade Slots")]
public class CardScriptModifyCharmSlots : CardScript
{
  [SerializeField]
  private int addCharmSlots;

  public override void Run(CardData target)
  {
    if (this.addCharmSlots == 0)
      return;
    object obj;
    if (target.customData != null && target.customData.TryGetValue("extraCharmSlots", out obj) && obj is int num)
      target.customData["extraCharmSlots"] = (object) (num + this.addCharmSlots);
    else
      target.SetCustomData("extraCharmSlots", (object) this.addCharmSlots);
  }
}
