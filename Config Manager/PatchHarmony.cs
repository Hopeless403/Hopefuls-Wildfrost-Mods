using Deadpan.Enums.Engine.Components.Modding;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WildfrostHopeMod
{
    public partial class ConfigManager : WildfrostMod
    {
        [HarmonyPatch(typeof(WildfrostMod.DebugLoggerTextWriter), nameof(WildfrostMod.DebugLoggerTextWriter.WriteLine))]
        class PatchHarmony
        {
            static bool Prefix() { Postfix(); return false; }
            static void Postfix() => HarmonyLib.Tools.Logger.ChannelFilter = HarmonyLib.Tools.Logger.LogChannel.Warn | HarmonyLib.Tools.Logger.LogChannel.Error;
        }
        public ConfigManager(string modDirectory) : base(modDirectory)
        {
            instance = this;
            HarmonyInstance.PatchAll(typeof(PatchHarmony));
        }
    }
}
