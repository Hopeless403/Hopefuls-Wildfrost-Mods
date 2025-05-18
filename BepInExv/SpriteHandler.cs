using System.IO;
using System.Linq;
using System.Reflection;
using UnityEngine;

public static class SpriteHandler
{
    public static void ExportSprite(Sprite sprite)
    {
        if (sprite.texture.width <= 0 || sprite.texture.height <= 0)
            return;

        int targetHeight = (int)sprite.rect.height;
        int targetWidth = (int)sprite.rect.width;
        int padAbove = Mathf.RoundToInt(sprite.textureRectOffset.y);
        int padLeft = Mathf.RoundToInt(sprite.textureRectOffset.x);

        var texture = sprite.texture.MakeReadable(sprite.textureRect, targetWidth, targetHeight, padLeft, padAbove);

        texture.SaveAsPNG(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), ($"{sprite.name}.png")));

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

        var texture = sprite.texture.MakeReadable(sprite.textureRect, targetWidth, targetHeight, padLeft, padAbove);

        texture.SaveAsPNG(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), ($"{card.name} ({card.title}).png")));

    }
    public static Texture2D MakeReadable(this Texture2D texture, Rect cropRect, int dstWidth, int dstHeight, int leftOffset, int belowOffset)
    {
        // Create a transparent texture with the destination dimensions
        Texture2D texture2D = new(dstWidth, dstHeight, TextureFormat.RGBA32, mipChain: false);
        texture2D.SetPixels(Enumerable.Range(0, dstWidth * dstHeight).Select(_ => Color.clear).ToArray());

        // Allocate a temporary RenderTexture with the original image dimensions
        RenderTexture active = RenderTexture.active;
        RenderTexture temporary = RenderTexture.GetTemporary(texture.width, texture.height, 32);

        // Copy the original Texture onto the temporary RenderTexture set active
        Graphics.Blit(texture, temporary);
        RenderTexture.active = temporary;

        // Copy the cropped part
        texture2D.ReadPixels(new Rect(cropRect.x, temporary.height - cropRect.y - cropRect.height, cropRect.width, cropRect.height),
            //0, 0);
            //(dstWidth - (int)cropRect.width) / 2, 0);
            leftOffset, belowOffset);
        texture2D.Apply();
        RenderTexture.active = active;
        RenderTexture.ReleaseTemporary(temporary);
        return texture2D;
    }
    public static void SaveAsPNG(this Texture2D _texture, string _fullPath)
    {
        byte[] _bytes = _texture.EncodeToPNG();
        File.WriteAllBytes(_fullPath, _bytes);
        Debug.Log(_bytes.Length / 1024 + "Kb was saved as: " + _fullPath);
    }
}