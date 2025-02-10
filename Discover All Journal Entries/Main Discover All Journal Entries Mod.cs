using Deadpan.Enums.Engine.Components.Modding;
using HarmonyLib;
using UnityEngine;

namespace WildfrostHopeMod
{
    [HarmonyPatch]
    public partial class DiscoverAllMod : WildfrostMod
    {
        public static DiscoverAllMod instance;
        public DiscoverAllMod(string modDirectory) : base(modDirectory) => instance = this;
        public override string GUID => "hope.wildfrost.discoverAll";
        public override string[] Depends => [];
        public override string Title => "All Journal Entries";
        public override string Description => "Shows more of the cards you can come across in the journal. You can toggle a config to actually see all entries - this doesn't affect your progression!" 
            + "\r\n\r\n\r\nBe warned when using this with mods that add MANY cards :p";

        [ConfigItem(false, null, "Discover All")]
        public bool setDiscovered;
        [ConfigItem(false, """
            Mods hide cards by not giving them a sprite, or by naming their sprites "Nothing"
            """, "Show hidden cards")]
        public bool hiddenCards;

        /// <summary>
        /// Discover all journal cards
        /// </summary>
        [HarmonyPatch(typeof(JournalCardManager), nameof(JournalCardManager.CreateCards), typeof(int))]
        static void Postfix(JournalCardManager __instance)
        {
            if (!instance.setDiscovered)
                return;

            Debug.LogWarning($"[{instance.Title}] >>> Discovering journal cards");
            foreach (var icon in __instance.cardIcons)
                icon.SetDiscovered(icon.cardData.title, __instance);
        }

        




        /// <summary>
        /// Recover clunkers & tribe flags
        /// </summary>
        [HarmonyPatch(typeof(References), nameof(References.Classes), MethodType.Getter)]
        static void Postfix(ref ClassData[] __result) 
            => __result = AddressableLoader.GetGroup<ClassData>("ClassData").ToArray();


        
    }
}