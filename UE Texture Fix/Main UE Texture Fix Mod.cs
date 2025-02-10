using Deadpan.Enums.Engine.Components.Modding;
using HarmonyLib;
using UnityEngine;
using UnityExplorer.UI.Widgets;
using UniverseLib.Runtime;

namespace WildfrostHopeMod.UE_Texture_Fix
{
    [HarmonyPatch]
    public class UE_Texture_FixMod(string modDirectory) : WildfrostMod(modDirectory)
    {
        public override string GUID => "hope.wildfrost.ueTextureFix";
        public override string[] Depends => ["kopie.wildfrost.unityexplorer"];
        public override string Title => "UE Texture Fix";
        public override string Description => "Just fixes inspecting Texture2D / Sprite / Images with Unity Explorer. Nothing else.";


        [HarmonyPatch(typeof(TextureHelper), nameof(TextureHelper.CopyTexture),
            typeof(Texture), typeof(Rect), typeof(int), typeof(int), typeof(int))]
        static bool Prefix(ref Texture2D __result, Texture source, Rect dimensions, int dstX, int dstY)
        {
            Debug.LogWarning("Patching: " + source);
            if (source is Texture2D texture)
            {
                __result = texture;
            }
            return false;
        }
        [HarmonyPatch(typeof(Texture2DWidget), nameof(Texture2DWidget.OnBorrowed))]
        static void Postfix(ref bool ___shouldDestroyTexture) => ___shouldDestroyTexture = false;
    }
}