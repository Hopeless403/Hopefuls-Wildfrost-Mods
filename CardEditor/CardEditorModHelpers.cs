using Deadpan.Enums.Engine.Components.Modding;
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using UnityEngine;

namespace CardEditor;
internal static class CardEditorModHelpers
{
    public static string PrefixGUID(this WildfrostMod mod, string name) => Extensions.PrefixGUID(name, mod);
    public static PropertyInfo[] GetAllFields<T>(T t, Type type = null)
    {
        return (type ?? t.GetType()).GetProperties((BindingFlags)0x1FFFFFD);//.Concat(typeof(T).GetFields((BindingFlags)0x1FFFFFF)).ToArray();
    }
    public static T PrintAllFields<T>(T t, Type type = null)
    {
        foreach (var field in GetAllFields(t, type))
        {
            try { Debug.Log($"{field.Name}: {field.GetValue(t) ?? "null"}"); }
            catch { Debug.Log($"{field.Name} failed"); }
        }
        return t;
    }
    public static Texture2D MakeReadable(this Texture2D texture)
    {
        return MakeReadable(texture, new Rect(0, 0, texture.width, texture.height));
    }
    public static Texture2D MakeReadable(this Texture2D texture, Rect cropRect)
    {
        return MakeReadable(texture, cropRect, Mathf.FloorToInt(cropRect.width), Mathf.FloorToInt(cropRect.height));
    }
    public static Texture2D MakeReadable(this Texture2D texture, Rect cropRect, bool squarePadding)
    {
        int length = Mathf.Max((int)cropRect.width, (int)cropRect.height);
        int dstWidth = squarePadding ? length : (int)cropRect.width;
        int dstHeight = squarePadding ? length : (int)cropRect.height;
        return MakeReadable(texture, cropRect, dstWidth, dstHeight);
    }
    public static Texture2D MakeReadable(this Texture2D texture, Rect cropRect, int dstWidth, int dstHeight)
    {
        int xOffset = (dstWidth - (int)cropRect.width) / 2;
        int yOffset = (dstHeight - (int)cropRect.height) / 2;
        return MakeReadable(texture, cropRect, dstWidth, dstHeight, xOffset, yOffset);
    }
    /// <summary>
    /// Convert textures to a readable texture, crop part of it, and add padding
    /// </summary>
    /// <param name="texture">sprite.texture</param>
    /// <param name="cropRect">sprite.textureRect</param>
    /// <param name="dstWidth">sprite.rect.width</param>
    /// <param name="dstHeight">sprite.rect.height</param>
    /// <param name="leftOffset">sprite.textureRectOffset.x</param>
    /// <param name="belowOffset">sprite.textureRectOffset.y</param>
    /// <returns></returns>
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