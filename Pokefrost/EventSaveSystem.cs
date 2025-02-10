// Decompiled with JetBrains decompiler
// Type: Pokefrost.EventSaveSystem
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  internal static class EventSaveSystem
  {
    private static Dictionary<string, int> eventProgress;

    private static bool FileName(CampaignData data, out string fileName)
    {
      fileName = (string) null;
      string name = data?.GameMode?.name;
      string profile = SaveSystem.GetProfile();
      if (profile == null || name == null)
        return false;
      fileName = Path.Combine(Pokefrost.Pokefrost.instance.ModDirectory, profile + "_" + name + "_quest.txt");
      return true;
    }

    private static void LoadProgress(CampaignData data)
    {
      EventSaveSystem.eventProgress = new Dictionary<string, int>();
      try
      {
        string fileName;
        if (!EventSaveSystem.FileName(data, out fileName) || !File.Exists(fileName))
          return;
        string[] strArray1 = File.ReadAllLines(fileName);
        int result;
        if (int.TryParse(strArray1[0], out result) && result == data.Seed)
        {
          for (int index = 1; index < strArray1.Length; ++index)
          {
            string[] strArray2 = strArray1[index].Split(' ');
            EventSaveSystem.eventProgress[strArray2[0]] = int.Parse(strArray2[1]);
          }
        }
        else
          File.Delete(fileName);
      }
      catch (Exception ex)
      {
        EventSaveSystem.eventProgress = new Dictionary<string, int>();
        Debug.Log((object) ex.Message);
      }
    }

    private static void SaveProgress(CampaignData data)
    {
      string fileName;
      if (EventSaveSystem.eventProgress == null || EventSaveSystem.eventProgress.Count == 0 || !EventSaveSystem.FileName(data, out fileName))
        return;
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.AppendLine(data.Seed.ToString());
      foreach (string key in EventSaveSystem.eventProgress.Keys)
        stringBuilder.AppendLine(string.Format("{0} {1}", (object) key, (object) EventSaveSystem.eventProgress[key]));
      File.WriteAllText(fileName, stringBuilder.ToString());
    }

    public static void Add(string key, int value)
    {
      if (EventSaveSystem.eventProgress == null)
        EventSaveSystem.LoadProgress(Campaign.Data);
      EventSaveSystem.eventProgress[key] = value;
      EventSaveSystem.SaveProgress(Campaign.Data);
    }

    public static int Get(string key)
    {
      EventSaveSystem.LoadProgress(Campaign.Data);
      int num;
      return EventSaveSystem.eventProgress.TryGetValue(key, out num) ? num : -1;
    }
  }
}
