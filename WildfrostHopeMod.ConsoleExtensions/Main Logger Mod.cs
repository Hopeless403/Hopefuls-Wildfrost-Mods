using Deadpan.Enums.Engine.Components.Modding;
using FMODUnity;
using HarmonyLib;
using System;
using System.IO;
using TMPro;
using UnityEngine;
using BCE;
using BepInEx.Configuration;
using Dead;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace WildfrostHopeMod.ConsoleExtensions
{
    public class ConsoleModExtensions(string modDirectory) : WildfrostMod(modDirectory)
    {
        public static string _modDirectory;
        public override string GUID => "hope.wildfrost.console+";
        public override string[] Depends => ["kopie.wildfrost.console"];
        public override string Title => "Console in Colour";
        public override string Description => "Adds ability to log to console in colour. Use your own tags for more custom colours - define these in the overrides.txt.\r\n\r\nWithout any modifications, it just prints any lines from Debug.LogWarning with yellow, Debug.LogError with red, etc (see second image). If you define your own tags, such as \"Tutorial = Green\", any line of these forms will have green text\r\n[code]\r\nDebug.Log(\"[Tutorial] text 1\");\r\nDebug.LogWarning(\"[Tutorial] text 2\");\r\nDebug.LogError(\"[Tutorial] text 3\");\r\n[/code]\r\n\r\n[hr]\r\nYou can also do stuff via script using \"console.Write\" or \"console.WriteLine\"\r\n[b]Important[/b]: Note that \"console\" is lowercase\r\nexample:\r\n[code]\r\nforeach (var mod in Bootstrap.Mods)\r\n   console.WriteLine(mod.Title, RandomConsoleColor());\r\n[/code]\r\n\r\nor to make your eyes bleed,\r\n[code]\r\nstring result = \"\";\r\nforeach (var mod in Bootstrap.Mods)\r\n   result += mod.Title + '\\n';\r\nconsole.WriteLineRainbow(result);\r\n[/code]\r\n\r\n\r\n\r\nAlso provides something nice for HarmonyTranspilers :)";

        public static Dictionary<string, ConsoleColor> overrides = [];

        public override void Load()
        {
            _modDirectory = ModDirectory;
            base.Load();
            CreateOverrides();
            BepInEx.ConsoleManager.Initialize(false, true);
            BepInEx.ConsoleManager.CreateConsole();

            string result = "";
            foreach (var mod in Bootstrap.Mods)
                result += mod.Title + '\n';
            console.WriteLineRainbow(result);
            Debug.Log("[Your Tag] this is an example of an override");
            Debug.Log("[Tutorial] text 1");
            Debug.LogWarning("[Tutorial] text 2");
            Debug.LogError("[Tutorial] text 3");
            Debug.Log("text 4");
            Debug.LogWarning("text 5");
            Debug.LogError("text 6");

            foreach (var pair in overrides)
                Debug.Log($"[{pair.Key}] {pair.Value}");
        }
        static void CreateOverrides()
        {
            string path = Path.Combine(_modDirectory, "overrides.txt");
            if (!File.Exists(path))
            {
                File.WriteAllText(path, "Available colors: \r\nRed, \tDarkRed, \r\nBlue, \tDarkBlue,\r\nGreen, \tDarkGreen, \r\nCyan, \tDarkCyan, \r\nYellow,\tDarkYellow, \r\nMagenta,DarkMagenta, \r\nGray, \tDarkGray,\r\nWhite\r\n\r\n## Lines that look like \"[Log] text\" have the tag \"Log\", and use the color for Log\r\n## `Debug.Log()` will always use this tag. Use `console.WriteLine(\"[Your Tag] ...\")` for Your Tag\r\n## Define them below:\r\nFatal = Red\r\nError = DarkRed\r\nWarning = Yellow\r\nMessage = White\r\nInfo = DarkGray\r\nDebug = Gray\r\nYour Tag = DarkYellow");
            }
            string[] lines = File.ReadAllLines(path);
            bool startReading = false;
            foreach (var line in lines)
            {
                if (line.StartsWith("##")) startReading |= true;
                else if (startReading)
                {
                    string[] pair = line.Split(['='], 2).With("Gray");
                    string color = pair[1].Trim();
                    int index = typeof(ConsoleColor).GetEnumNames().ToList().IndexOf(color);
                    if (index != -1)
                    {
                        overrides[pair[0].Trim()] = (ConsoleColor)index;
                    }
                }
            }
        }

        [HarmonyPatch]
        class Patches
        {
            [HarmonyPatch(typeof(BepInEx.Paths), nameof(BepInEx.Paths.BepInExConfigPath), MethodType.Getter)]
            static bool Prefix(ref string __result)
            {
                __result = Path.Combine(_modDirectory, "BepInEx.cfg");
                return false;
            }
            [HarmonyPatch(typeof(WildfrostMod.DebugLoggerTextWriter), nameof(WildfrostMod.DebugLoggerTextWriter.WriteLine))]
            static bool Prefix() { Postfix(); return false; }
            [HarmonyPatch(typeof(WildfrostMod.DebugLoggerTextWriter), nameof(WildfrostMod.DebugLoggerTextWriter.WriteLine))]
            static void Postfix() => HarmonyLib.Tools.Logger.ChannelFilter = HarmonyLib.Tools.Logger.LogChannel.None;
        }
        [HarmonyPatch]
        class PatchesConsole
        {
            [HarmonyPatch(typeof(System.Console), nameof(System.Console.WriteLine), typeof(string))]
            static bool Prefix(string value)
            {
                string logLevel = new Regex(@"\[(.*?)\]").Match(value).Groups[1].Value;
                if (!overrides.TryGetValue(logLevel, out var color))
                    color = ConsoleColor.Gray;
                console.WriteLine(value, color);
                return false;
            }
            [HarmonyPatch(typeof(Debug), nameof(Debug.Log), typeof(object))]
            [HarmonyPatch(typeof(Debug), nameof(Debug.LogError), typeof(object))]
            [HarmonyPatch(typeof(Debug), nameof(Debug.LogWarning), typeof(object))]
            static bool Prefix(object message, MethodBase __originalMethod)
            {
                string value = message?.ToString() ?? "NULL";
                var match = new Regex(@"\[(.*?)\]").Match(value ?? "");
                string logLevel = "";
                if (match.Success)
                    logLevel = match.Groups[1].Value;

                if (!match.Success || !overrides.ContainsKey(logLevel) && !value.StartsWith($"[{logLevel}]"))
                {
                    logLevel = __originalMethod.Name switch
                    {
                        nameof(Debug.Log) => "Log",
                        nameof(Debug.LogError) => "Error",
                        nameof(Debug.LogWarning) => "Warning",
                        _ => ""
                    };
                    value = $"[{logLevel}] {value}";
                }

                if (!overrides.TryGetValue(logLevel, out var color))
                    color = ConsoleColor.Gray;

                console.WriteLine(value, color);
                return false;
            }
        }
    }

}