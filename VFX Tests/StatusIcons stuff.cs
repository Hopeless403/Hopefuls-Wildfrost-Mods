using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using WildfrostHopeMod.Utils;

namespace WildfrostHopeMod.VFX
{
    
    internal class StatusIconGenerator
    {
        public TMP_SpriteAsset spriteAsset;
        public StatusIconGenerator(string name, string directoryWithPNGs = null, Texture2D[] textures = null, Sprite[] sprites = null)
        {
            spriteAsset = HopeUtils.CreateSpriteAsset(name, directoryWithPNGs, textures, sprites);
        }
    }
}
