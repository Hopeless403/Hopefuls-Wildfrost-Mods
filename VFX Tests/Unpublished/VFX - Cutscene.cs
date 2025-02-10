using Deadpan.Enums.Engine.Components.Modding;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UIElements;
using Dir = System.IO.Directory;
using WildfrostHopeMod.Utils;
using WildfrostHopeMod.Utils.mgGIF;
using UnityEngine.UI;
using UnityEngine.Localization.SmartFormat.Extensions;
using UnityEngine.Networking;
using TMPro;
using System.Threading;
using UnityEngine.Events;

namespace WildfrostHopeMod.VFX;

public interface ICutscene
{
    public string Path { get; }
    public string Name { get; }
    /// <summary>
    /// Number of frames
    /// </summary>
    public int Length { get; internal set; }
    public bool Load();
    public bool Show();
}

public class GifCutscene : ICutscene
{
    public GifCutscene(string path)
    {
        Debug.LogWarning("CUTSCENE LOADER: " + path);
        Path = path;
    }
    public string Path { get; }
    public string Name => System.IO.Path.GetFileNameWithoutExtension(Path);
    public int Length { get; set; }
    public List<Texture> Frames { get; set; }
    public List<float> Delays { get; set; }
    public bool Load()
    {
        if (Path == null || !File.Exists(Path))
            throw new FileNotFoundException($"[VFX Tools] {Path} doesn't exist! Make sure to include \".gif\"");

        Debug.LogError("Load vs GIF: " + Path);

        byte[] data = new byte[0];
        new Action(() => data = File.ReadAllBytes(Path)).TimedInvoke();

        new Action(() =>
        {
            List<Texture2D> frames = new();
            List<float> delays = new();
            float delay = 1 / 24;
            using (var decoder = new Utils.mgGIF.Decoder(data))
            {
                var img = decoder.NextImage();
                int count = 0;
                while (img != null)
                {
                    Texture2D texture = img.CreateTexture();
                    texture.name = $"{Name}_p{count++}";
                    frames.Add(texture);
                    delays.Add(delay = img.Delay / 1000f);
                    img = decoder.NextImage();
                }
            }
            Length = frames.Count;
            Frames = frames.Cast<Texture>().ToList();
            Delays = delays.ToList();
        }).TimedInvoke();

        if (Frames.Count == 0)
        {
            Debug.LogError($"[VFX Tools] {Path} cannot be read!");
            return false;
        }
        Debug.LogWarning($"[VFX Tools] Created prefab: [{Name}]!");
        return true;
    }
    public bool Show()
    {
        if (Length <= 0)
        {
            Debug.LogError($"[VFX Tools] There wasn't a valid cutscene!");
            return false;
        }
        if (Frames.Count != Delays.Count)
        {
            Debug.LogError($"[VFX Tools] Frame count mismatch!");
            return false;
        }
        if (!VFXMod.Mod.gifCutscene)
        {
            Debug.LogError($"[VFX Tools] No valid cutscene renderer!");
            return false;
        }
        CoroutineManager.Start(VFXMod.Mod.gifCutscene.ShowRoutine(this));
        return true;
    }
}

public class GifCutsceneRenderer : MonoBehaviour
{
    public List<Texture> Frames { get; internal set; }
    public List<float> Delays { get; internal set; }
    Texture currentFrame = null;
    public IEnumerator ShowRoutine(GifCutscene cutscene)
    {
        Frames = cutscene.Frames;
        Delays = cutscene.Delays;

        currentFrame = Frames.FirstOrDefault();
        yield return currentFrame;
    }


    void Update()
    {
        if (currentFrame == null)
            return;

        //Debug.Log(currentFrame);
        Graphics.Blit(currentFrame, Camera.main.targetTexture);
        Camera.main.Render();
        
    }/*
    void LateUpdate()
    {
        if (currentFrame == null)
            return;

        Debug.LogWarning(currentFrame);
        Graphics.Blit(currentFrame, Camera.main.targetTexture);
    }*/
}