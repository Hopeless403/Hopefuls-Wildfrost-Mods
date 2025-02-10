// Decompiled with JetBrains decompiler
// Type: ScriptableCardsInHand
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Scriptable Amount/Cards In Hand", fileName = "CardsInHand")]
public class ScriptableCardsInHand : ScriptableAmount
{
  public override int Get(Entity entity) => References.Player.handContainer.Count;
}
