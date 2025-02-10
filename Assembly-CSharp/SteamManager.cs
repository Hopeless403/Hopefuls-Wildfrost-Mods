// Decompiled with JetBrains decompiler
// Type: SteamManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using Steamworks;
using Steamworks.Ugc;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SteamManager : MonoBehaviour
{
  private const int appId = 1811990;

  public static bool init { get; private set; }

  private async void Awake()
  {
    try
    {
      SteamClient.Init(1811990U);
      if (SteamClient.RestartAppIfNecessary(1811990U))
        GameManager.Quit();
      else
        SteamManager.init = true;
    }
    catch (Exception ex)
    {
      Debug.LogError((object) string.Format("Steam failed to initialize! ({0})", (object) ex));
      Debug.Log((object) string.Format("Steam failed to initialize! ({0})", (object) ex));
      GameManager.Quit();
    }
    List<string> steamFiles = new List<string>();
    int i = 1;
    while (true)
    {
      Query query = Query.All;
      query = query.WhereUserSubscribed();
      ResultPage? pageAsync = await query.GetPageAsync(i);
      if (pageAsync.HasValue && pageAsync?.Entries.Any<Steamworks.Ugc.Item>())
      {
        foreach (Steamworks.Ugc.Item entry in pageAsync?.Entries)
        {
          Steamworks.Ugc.Item pageEntry = entry;
          string directory = pageEntry.Directory;
          if (directory == null)
          {
            int num = await pageEntry.DownloadAsync() ? 1 : 0;
            directory = pageEntry.Directory;
          }
          steamFiles.Add(directory);
          pageEntry = new Steamworks.Ugc.Item();
        }
        ++i;
      }
      else
        break;
    }
    foreach (string path in steamFiles)
      Bootstrap.LoadModAtPath(path);
    steamFiles = (List<string>) null;
  }

  private void OnEnable()
  {
    if (!SteamManager.init)
      return;
    Debug.Log((object) string.Format("Steam Initialized {0} ({1})", (object) SteamClient.Name, (object) SteamClient.SteamId));
  }

  private void OnDisable() => SteamClient.Shutdown();
}
