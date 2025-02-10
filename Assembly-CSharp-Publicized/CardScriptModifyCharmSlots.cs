// Decompiled with JetBrains decompiler
// Type: CardScriptModifyCharmSlots
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

[CreateAssetMenu(fileName = "Modify Upgrade Slots", menuName = "Card Scripts/Modify Upgrade Slots")]
public class CardScriptModifyCharmSlots : CardScript
{
  [SerializeField]
  public int addCharmSlots;

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
