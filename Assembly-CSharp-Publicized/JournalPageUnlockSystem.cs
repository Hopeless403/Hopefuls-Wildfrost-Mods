﻿// Decompiled with JetBrains decompiler
// Type: JournalPageUnlockSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections.Generic;
using UnityEngine;

public class JournalPageUnlockSystem : GameSystem
{
  [SerializeField]
  public JournalPageData[] pages;

  public void OnEnable() => Events.OnCampaignLoadPreset += new Events.UnityActionRef<string[]>(this.InsertJournalPages);

  public void OnDisable() => Events.OnCampaignLoadPreset -= new Events.UnityActionRef<string[]>(this.InsertJournalPages);

  public void InsertJournalPages(ref string[] lines)
  {
    List<string> unlockedList = MetaprogressionSystem.GetUnlockedList();
    foreach (JournalPageData page in this.pages)
    {
      if (page.unlockOnMap && !unlockedList.Contains(page.unlock.name) && JournalPageUnlockSystem.IsLegal(page))
      {
        int startIndex = 0;
        for (int index = lines[0].Length - 1; index >= 0; --index)
        {
          if ((int) lines[2][index] == (int) page.mapTierIndex && ((int) lines[0][index] == (int) page.mapAfterLetter || (int) lines[1][index] == (int) page.mapAfterLetter))
          {
            startIndex = index + 1;
            break;
          }
        }
        lines[0] = lines[0].Insert(startIndex, page.mapNodeType.letter);
        lines[1] = lines[1].Insert(startIndex, " ");
        lines[2] = lines[2].Insert(startIndex, lines[2][startIndex - 1].ToString());
        lines[3] = lines[3].Insert(startIndex, lines[3][startIndex - 1].ToString());
      }
    }
  }

  public static bool IsLegal(JournalPageData page) => page.legalGameModes.Contains<GameMode>(Campaign.Data.GameMode) && page.legalTribes.Contains<ClassData>(References.PlayerData.classData) && JournalPageUnlockSystem.HasRequiredStormPoints(page) && JournalPageUnlockSystem.HasRequiredModifiers(page);

  public static bool HasRequiredStormPoints(JournalPageData page) => page.requiresStormPoints <= 0 || StormBellManager.GetCurrentStormPoints(StormBellManager.GetActiveStormBells()) >= page.requiresStormPoints;

  public static bool HasRequiredModifiers(JournalPageData page)
  {
    GameModifierData[] requiresModifiers = page.requiresModifiers;
    if (requiresModifiers == null || requiresModifiers.Length <= 0)
      return true;
    return Campaign.Data.Modifiers != null && Campaign.Data.Modifiers.ContainsAll<GameModifierData>((IEnumerable<GameModifierData>) page.requiresModifiers);
  }

  public static CampaignGenerator.Node CreateNode(
    float x,
    float y,
    string type,
    int positionIndex)
  {
    Vector2 vector2 = Dead.Random.Vector2();
    x += vector2.x;
    y += vector2.y;
    return new CampaignGenerator.Node(x, y, 1f, 0, positionIndex, 0, type);
  }
}
