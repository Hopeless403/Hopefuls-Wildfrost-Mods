// Decompiled with JetBrains decompiler
// Type: LeaderReroll.RerollComponent
// Assembly: LeaderReroll, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B49BAD01-7FF8-40B0-BDD0-8A9F0E6D0D3B
// Assembly location: C:\Users\harri\Downloads\LeaderReroll.dll

using Il2CppSystem.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace LeaderReroll
{
  public class RerollComponent : MonoBehaviour
  {
    private CharacterSelectScreen screen;
    private static readonly bool[] allowedFactions = new bool[3]
    {
      true,
      true,
      true
    };
    private static readonly string[] factionNames = new string[3]
    {
      "Snowdwellers",
      "Shadermancers",
      "Clunkmasters"
    };

    private void Awake() => this.screen = ((Component) this).GetComponent<CharacterSelectScreen>();

    private void OnGUI()
    {
      GUILayout.BeginArea(new Rect(10f, 10f, 160f, 400f));
      for (int index = 0; index < RerollComponent.allowedFactions.Length; ++index)
      {
        RerollComponent.allowedFactions[index] = GUILayout.Toggle(RerollComponent.allowedFactions[index], RerollComponent.factionNames[index], Array.Empty<GUILayoutOption>());
        if (((IEnumerable<bool>) RerollComponent.allowedFactions).All<bool>((Func<bool, bool>) (x => !x)))
          RerollComponent.allowedFactions[index] = true;
      }
      this.screen.options = (int) GUILayout.HorizontalSlider((float) this.screen.options, 1f, 7f, Array.Empty<GUILayoutOption>());
      DefaultInterpolatedStringHandler interpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 2);
      interpolatedStringHandler.AppendLiteral("Reroll ");
      interpolatedStringHandler.AppendFormatted<int>(this.screen.options);
      interpolatedStringHandler.AppendLiteral(" Leader");
      interpolatedStringHandler.AppendFormatted(this.screen.options == 1 ? "" : "s");
      if (GUILayout.Button(interpolatedStringHandler.ToStringAndClear(), Array.Empty<GUILayoutOption>()))
      {
        Plugin.Log.LogInfo((object) "Rerolling...");
        List<KeyValuePair<ClassData, CharacterSelectScreen.LeaderPool>> list = new List<KeyValuePair<ClassData, CharacterSelectScreen.LeaderPool>>();
        foreach (KeyValuePair<ClassData, CharacterSelectScreen.LeaderPool> leaderPool in this.screen.leaderPools)
          list.Add(leaderPool);
        this.screen.leaderPools.Clear();
        for (int index = 0; index < list.Count; ++index)
        {
          if (RerollComponent.allowedFactions[index])
            this.screen.leaderPools.Add(list[index].Key, list[index].Value);
        }
        this.screen.Reroll();
        this.screen.leaderPools.Clear();
        foreach (KeyValuePair<ClassData, CharacterSelectScreen.LeaderPool> keyValuePair in list)
          this.screen.leaderPools.Add(keyValuePair.Key, keyValuePair.Value);
      }
      GUILayout.EndArea();
    }
  }
}
