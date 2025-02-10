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
        public static void ExportSprite(Sprite sprite)
        {
            if (sprite.texture.width <= 0 || sprite.texture.height <= 0)
                return;

            int targetHeight = (int)sprite.rect.height;
            int targetWidth = (int)sprite.rect.width;
            int padAbove = Mathf.RoundToInt(sprite.textureRectOffset.y);
            int padLeft = Mathf.RoundToInt(sprite.textureRectOffset.x);

            CardEditorMod.texture = sprite.texture.MakeReadable(sprite.textureRect, targetWidth, targetHeight, padLeft, padAbove);

            System.IO.Directory.CreateDirectory(CardEditorMod.instance.ImagesDirectory);
            CardEditorMod.texture.SaveAsPNG(CardEditorMod.instance.ImagePath($"{sprite.name}.png"));
            Debug.LogWarning("Saved " + sprite.name);
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
