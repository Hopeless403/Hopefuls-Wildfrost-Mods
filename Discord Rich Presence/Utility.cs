using DiscordRPC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WildfrostHopeMod.Discord_Rich_Presence
{
    internal static class Utility
    {
        public static string GetAssetName(this string s) => s.Replace(' ', '_').Replace('.', '_').ToLower();
        internal static void SetStatus(string state, string details = null, Timestamps timestamp = null, string largeImageKey = null, string largeImageText = null, string smallImageKey = null, string smallImageText = null)
        {
            if (WildfrostRichPresence.client == null) return;
            timestamp ??= WildfrostRichPresence.startTimestamp;
            WildfrostRichPresence.client.SetPresence(new RichPresence()
            {
                Assets = new Assets()
                {
                    LargeImageKey = largeImageKey,
                    LargeImageText = largeImageText,
                    SmallImageKey = smallImageKey,
                    SmallImageText = smallImageText,
                },
                Details = details,
                State = state,
                Timestamps = timestamp
            });
        }
        internal static RichPresence StatusBuilder(string state, string details = null, Timestamps timestamp = null, string largeImageKey = null, string largeImageText = null, string smallImageKey = null, string smallImageText = null)
        {
            if (WildfrostRichPresence.client == null) return null;
            timestamp ??= WildfrostRichPresence.startTimestamp;
            return new RichPresence()
            {
                Assets = new Assets()
                {
                    LargeImageKey = largeImageKey,
                    LargeImageText = largeImageText,
                    SmallImageKey = smallImageKey,
                    SmallImageText = smallImageText,
                },
                Details = details,
                State = state,
                Timestamps = timestamp
            };
        }
    }
}
