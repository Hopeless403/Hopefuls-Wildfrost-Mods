// Decompiled with JetBrains decompiler
// Type: LeaderReroll.Plugin
// Assembly: LeaderReroll, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B49BAD01-7FF8-40B0-BDD0-8A9F0E6D0D3B
// Assembly location: C:\Users\harri\Downloads\LeaderReroll.dll

using BepInEx;
using BepInEx.Logging;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;
using Il2CppInterop.Runtime.Injection;
using System.Reflection;

namespace LeaderReroll
{
  [BepInPlugin("com.evacipated.wildfrost.leaderreroll", "Leader Reroll", "1.0.0")]
  public class Plugin : BasePlugin
  {
    internal static ManualLogSource Log;

    public virtual void Load()
    {
      Plugin.Log = this.Log;
      ClassInjector.RegisterTypeInIl2Cpp<RerollComponent>();
      Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), (string) null);
    }
  }
}
