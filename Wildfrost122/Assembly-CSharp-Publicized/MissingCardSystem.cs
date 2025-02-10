// Decompiled with JetBrains decompiler
// Type: MissingCardSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
public static class MissingCardSystem
{
  public static CardData Get() => AddressableLoader.Get<CardData>("CardData", "MissingCard");

  public static CardData GetClone(string cardDataName, bool runCreateScripts = true)
  {
    CardData cardData = MissingCardSystem.Get();
    if (!(bool) (UnityEngine.Object) cardData)
      return (CardData) null;
    CardData clone = cardData.Clone(runCreateScripts);
    clone.forceTitle = "Missing Card " + cardDataName;
    return clone;
  }

  public static CardData GetCloneWithId(
    string cardDataName,
    Vector3 random3,
    ulong id,
    bool runCreateScripts = true)
  {
    CardData cardData = MissingCardSystem.Get();
    if (!(bool) (UnityEngine.Object) cardData)
      return (CardData) null;
    CardData cloneWithId = cardData.Clone(random3, id, runCreateScripts);
    cloneWithId.forceTitle = "Missing Card " + cardDataName;
    return cloneWithId;
  }

  public static bool IsMissing(CardData cardData) => MissingCardSystem.IsMissing(cardData.name);

  public static bool IsMissing(CardSaveData cardSaveData)
  {
    return MissingCardSystem.IsMissing(cardSaveData.name);
  }

  public static bool IsMissing(string cardDataName)
  {
    CardData cardData = AddressableLoader.Get<CardData>("CardData", cardDataName);
    return !(bool) (UnityEngine.Object) cardData || cardData.name == "MissingCard";
  }

  public static bool HasMissingData(IEnumerable<string> cardDataNames)
  {
    foreach (string cardDataName in cardDataNames)
    {
      if (MissingCardSystem.IsMissing(cardDataName))
        return true;
    }
    return false;
  }

  public static bool HasMissingData(CardSaveData[] cardSaveDatas)
  {
    return MissingCardSystem.HasMissingData((IEnumerable<CardData>) cardSaveDatas.LoadList<CardData, CardSaveData>());
  }

  public static bool HasMissingData(IEnumerable<CardData> cardDataList)
  {
    return cardDataList.Any<CardData>((Func<CardData, bool>) (a => MissingCardSystem.IsMissing(a.name)));
  }
}
