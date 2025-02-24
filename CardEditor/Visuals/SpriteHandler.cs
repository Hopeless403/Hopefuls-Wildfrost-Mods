using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityExplorer.UI;

namespace CardEditor.Visuals
{
    public class SpriteHandler
    {
        static Texture2D Resize(Texture2D texture2D, int targetX, int targetY)
        {
            RenderTexture rt = new RenderTexture(targetX, targetY, 24);
            RenderTexture.active = rt;
            Graphics.Blit(texture2D, rt);
            Texture2D result = new Texture2D(targetX, targetY);
            result.ReadPixels(new Rect(0, 0, targetX, targetY), 0, 0);
            result.Apply();
            return result;
        }
        public static void ExportSprite(Sprite sprite, string name)
        {
            if (sprite == null || sprite.texture.width <= 0 || sprite.texture.height <= 0)
                return;

            try
            {
                int targetHeight = (int)sprite.rect.height;
                int targetWidth = (int)sprite.rect.width;
                int padAbove = Mathf.RoundToInt(sprite.textureRectOffset.y);
                int padLeft = Mathf.RoundToInt(sprite.textureRectOffset.x);

                if (name.StartsWith("battle_") || name.StartsWith("tribe_") || name.StartsWith("map_"))
                {
                    CardEditorMod.texture = sprite.texture.MakeReadable(sprite.textureRect, true);
                    Debug.LogError(CardEditorMod.texture.width);
                    int targetLength = Mathf.Clamp(CardEditorMod.texture.width, 512, 1024);
                    CardEditorMod.texture = Resize(CardEditorMod.texture, targetLength, targetLength);
                }
                else 
                    CardEditorMod.texture = sprite.texture.MakeReadable(sprite.textureRect, targetWidth, targetHeight, padLeft, padAbove);

                System.IO.Directory.CreateDirectory(CardEditorMod.instance.ImagesDirectory);
                CardEditorMod.texture.SaveAsPNG(CardEditorMod.instance.ImagePath($"{name}.png"));
                Debug.LogWarning("Saved " + name);
            }
            catch { }
        }
        public static void ExportSprite(Sprite sprite)
        {
            ExportSprite(sprite, sprite?.name);
        }

        public static void ExportSprite(CardData card, bool inspectAfter = false)
        {
            if (!card.mainSprite || card.mainSprite.name == "Nothing")
                return;

            Sprite sprite = card.mainSprite;

            int targetHeight = (int)sprite.rect.height;
            int targetWidth = (int)sprite.rect.width;
            int padAbove = Mathf.RoundToInt(sprite.textureRectOffset.y);
            int padLeft = Mathf.RoundToInt(sprite.textureRectOffset.x);

            CardEditorMod.texture = sprite.texture.MakeReadable(sprite.textureRect, targetWidth, targetHeight, padLeft, padAbove);

            System.IO.Directory.CreateDirectory(CardEditorMod.instance.ImagesDirectory);
            CardEditorMod.texture.SaveAsPNG(CardEditorMod.instance.ImagePath($"{card.name} ({card.title}).png"));

            if (!inspectAfter)
                return;

            CardEditorMod.texture.name = DateTime.Now.ToString();
            UnityExplorer.InspectorManager.Inspect(CardEditorMod.texture);
            UIManager.ShowMenu = true;
        }
    }
}
