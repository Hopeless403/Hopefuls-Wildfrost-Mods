// Decompiled with JetBrains decompiler
// Type: JournalNameHistory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using Dead;
using System;
using System.Collections.Generic;
using UnityEngine;

public static class JournalNameHistory
{
  public const int maxEntries = 26;
  public const float fadePrevious = 0.035f;
  public static readonly Vector2 startPos = new Vector2(-1.733333f, 3f);
  public static readonly Vector2 spacing = new Vector2(1.733333f, 1f);
  public static readonly Vector2 bounds = new Vector2(1.733333f, -3f);
  public static readonly Vector2 randomOffset = new Vector2(0.5f, 0.25f);
  public const float randomAngle = 3f;

  public static void AddName(string name)
  {
    JournalNameHistory.Name name1 = new JournalNameHistory.Name(name, JournalNameHistory.randomOffset, 3f);
    List<JournalNameHistory.Name> nameList1 = SaveSystem.LoadProgressData<List<JournalNameHistory.Name>>("leaderNameHistory") ?? new List<JournalNameHistory.Name>();
    Vector2 vector2_1;
    if (nameList1.Count <= 0)
    {
      vector2_1 = JournalNameHistory.startPos;
    }
    else
    {
      List<JournalNameHistory.Name> nameList2 = nameList1;
      vector2_1 = nameList2[nameList2.Count - 1].position;
    }
    Vector2 vector2_2 = vector2_1;
    if (nameList1.Count > 0)
    {
      vector2_2.y -= JournalNameHistory.spacing.y;
      if ((double) vector2_2.y < (double) JournalNameHistory.bounds.y)
      {
        vector2_2.y = JournalNameHistory.startPos.y;
        vector2_2.x += JournalNameHistory.spacing.x;
        if ((double) vector2_2.x > (double) JournalNameHistory.bounds.x)
          vector2_2.x = JournalNameHistory.startPos.x;
      }
    }
    name1.position = vector2_2;
    nameList1.Add(name1);
    SaveSystem.SaveProgressData<List<JournalNameHistory.Name>>("leaderNameHistory", nameList1);
  }

  public static void FadePrevious()
  {
    List<JournalNameHistory.Name> nameList = SaveSystem.LoadProgressData<List<JournalNameHistory.Name>>("leaderNameHistory");
    if (nameList == null || nameList.Count <= 0)
      return;
    while (nameList.Count > 25)
      nameList.RemoveAt(0);
    foreach (JournalNameHistory.Name name in nameList)
      name.opacity -= 0.035f;
    SaveSystem.SaveProgressData<List<JournalNameHistory.Name>>("leaderNameHistory", nameList);
  }

  public static void MostRecentNameKilled()
  {
    List<JournalNameHistory.Name> nameList1 = SaveSystem.LoadProgressData<List<JournalNameHistory.Name>>("leaderNameHistory");
    if (nameList1 == null || nameList1.Count <= 0)
      return;
    List<JournalNameHistory.Name> nameList2 = nameList1;
    nameList2[nameList2.Count - 1].killed = true;
    SaveSystem.SaveProgressData<List<JournalNameHistory.Name>>("leaderNameHistory", nameList1);
  }

  public static void MostRecentNameMissing()
  {
    List<JournalNameHistory.Name> nameList1 = SaveSystem.LoadProgressData<List<JournalNameHistory.Name>>("leaderNameHistory");
    if (nameList1 == null || nameList1.Count <= 0)
      return;
    List<JournalNameHistory.Name> nameList2 = nameList1;
    nameList2[nameList2.Count - 1].missing = true;
    SaveSystem.SaveProgressData<List<JournalNameHistory.Name>>("leaderNameHistory", nameList1);
  }

  [Serializable]
  public class Name
  {
    public string text;
    public bool killed;
    public bool missing;
    public float opacity;
    public Vector2 position;
    public Vector2 offset;
    public float angle;

    public Name()
    {
    }

    public Name(string text, Vector2 randomOffset, float randomAngle)
    {
      this.text = text;
      this.opacity = 1f;
      this.offset = new Vector2(randomOffset.x * PettyRandom.Range(-1f, 1f), randomOffset.y * PettyRandom.Range(-1f, 1f));
      this.angle = randomAngle * PettyRandom.Range(-1f, 1f);
    }
  }
}
