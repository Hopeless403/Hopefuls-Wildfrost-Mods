using Deadpan.Enums.Engine.Components.Modding;

public class TemplateMod : WildfrostMod
    {
    [HarmonyLib.HarmonyPatch(typeof(CheckAchievements), "Start")]
    class PatchAchievements { static bool Prefix() => false; }
    public TemplateMod(string modDirectory) : base(modDirectory) { }
        public override string GUID => "hope.wildfrost.ACHIEVEMENT_16";
        public override string[] Depends => [];
        public override string Title => "ACHIEVEMENT_16";
        public override string Description => "Here's your ACHIEVEMENT_16";
    }

