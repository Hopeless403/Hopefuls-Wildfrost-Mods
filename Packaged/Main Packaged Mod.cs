using Deadpan.Enums.Engine.Components.Modding;
using FMODUnity;
using HarmonyLib;
using LibAPNG;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace WildfrostHopeMod.Packaged
{
    public static class LibAPNGHelpers
    {
        public struct FrameInfo(Frame frame)
        {
            public uint left = frame.fcTLChunk.XOffset;
            public uint top = frame.fcTLChunk.YOffset;
            public uint width = frame.fcTLChunk.Width;
            public uint height = frame.fcTLChunk.Height;
            public int delay = frame.fcTLChunk.DelayNum;
            public DisposeOps disposeOp = frame.fcTLChunk.DisposeOp;
            public BlendOps blendOp = frame.fcTLChunk.BlendOp;
            public Dictionary<string, object> imageData = [];
            public Dictionary<string, object> imageElement = [];

            public uint IDATlen = frame.IDATChunks.First().Length;
            public int IHDRw = frame.IHDRChunk.Width;
            public int IHDRh = frame.IHDRChunk.Height;
        }
        public struct IdatInfo(IDATChunk chunk)
        {

        }

        public static string Info(this Frame frame)
        {
            var info = new FrameInfo(frame);
            return JsonConvert.SerializeObject(info, 0);
        }
    }
    public enum fcTL
    {
        SequenceNumber = 0,
        Width = 4,
        Height = 8,
        XOffset = 12,
        YOffset = 16,
        DelayNum = 20,
        DelayDen = 22,
        DisposeOp = 24,
        BlendOp = 25,
    }
    public class PackagedMod : WildfrostMod
    {
        public static PackagedMod Mod;
        public PackagedMod(string modDirectory) : base(modDirectory)
        {
            Mod = this;
        }
        public override string GUID => "hope.wildfrost.Packaged";
        public override string[] Depends => [];
        public override string Title => "Packaged 2";
        public override string Description => $"Last update: {DateTime.Now}";
        public override TMP_SpriteAsset SpriteAsset => base.SpriteAsset;
        public static GameObject behaviour;

        public override void Load()
        {
            _ = new int[] { 1, 2, 3 }[0..1].Length;
            base.Load();

            var apng = new APNG(Path.Combine(ModDirectory, "APNGs", "Cursor.png"));

            if (!apng.DefaultImageIsAnimated)
                File.WriteAllBytes("0.png", apng.DefaultImage.GetStream().ToArray());

            foreach (Frame frame in apng.Frames)
            {
                Debug.Log(frame.Info());
                var chunk = new fcTLChunk(frame.fcTLChunk);
                Debug.LogWarning((int)Convert.ToUInt32(400));

                chunk.ModifyChunkData((int)fcTL.YOffset, Helper.ConvertEndian((uint)113));
                chunk.ModifyChunkData((int)fcTL.Height, Helper.ConvertEndian((uint)175));
                chunk = new fcTLChunk(chunk);

                frame.fcTLChunk = chunk;
                Debug.LogWarning(frame.Info());

                //Debug.LogWarning(frame.Info());
                File.WriteAllBytes(
                                   Path.Combine(ModDirectory, "APNGs", frame.fcTLChunk.SequenceNumber + ".png"),
                                   frame.GetStream().ToArray());
            }

        }
    }
}