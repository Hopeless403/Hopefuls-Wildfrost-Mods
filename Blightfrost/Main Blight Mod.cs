using BetaJester.EnumGenerator;
using Deadpan.Enums.Engine.Components.Modding;
using FMODUnity;
using HarmonyLib;
using System;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using TMPro;
using UnityEngine;
using WildfrostHopeMod.Utils;
using WildfrostHopeMod.VFX;


public class Blightfrost : WildfrostMod
{
    public static Paths Paths;
    public static Blightfrost Mod;
    public Blightfrost(string modDirectory) : base(modDirectory)
    {
        Mod = this; Paths = new Paths(ModDirectory);
    }
    public override string GUID => "hope.wildfrost.blightfrost";
    public override string[] Depends => new string[] { "hope.wildfrost.vfx" };
    public override string Title => "Blightfrost";
    public override string Description => "Far from Land's End, the cowardice of the young white priestesses collects its debt";
    public override TMP_SpriteAsset SpriteAsset => base.SpriteAsset;
    public static GameObject behaviour;
    public GIFLoader loader;

    public override void Load()
    {
        loader ??= new GIFLoader(ImagesDirectory, GIFLoader.PlayType.loopingAnimation);
        loader.RegisterAllAsApplyEffect();
        Debug.LogWarning(AppDomain.CurrentDomain.BaseDirectory);

        Debug.LogWarning(GetType().Assembly.Location);

        base.Load();

        behaviour = new GameObject("BlightfrostBehaviour");
        GameObject.DontDestroyOnLoad(behaviour);
        behaviour.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset |
                              HideFlags.HideInInspector | HideFlags.NotEditable;

        var e = behaviour.AddComponent<BlightfrostBehaviour>();
    }

    public override void Unload()
    {
        base.Unload();
        GameObject.Destroy(behaviour);
        behaviour = null;
    }
}

public class BlightfrostBehaviour : MonoBehaviour
{
    internal void Start()
    {
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftAlt))
        {
        }

        if (Input.GetKey(KeyCode.LeftControl) && Input.GetKeyDown(KeyCode.T))
        {
        }
    }
}