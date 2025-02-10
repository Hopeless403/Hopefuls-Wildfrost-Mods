using BepInEx;
using BepInEx.Configuration;
using BepInEx.Core.Logging.Interpolation;
using BepInEx.Logging;
using BepInEx.Unity.IL2CPP;
using BepInEx.Unity.IL2CPP.Utils;
using Dead;
using HarmonyLib;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Injection;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.SceneManagement;
using WildfrostModMiya;

namespace WildFrostModHope;
[BepInPlugin("WildFrost.Hope.TribeAdder", "Tribe Adder", "0.1.0.0")]
[BepInDependency("WildFrost.Miya.WildfrostAPI")]
public class WildFrostTribeAdder : BasePlugin
{
    public static string ModsFolder = typeof(WildFrostAPIMod).Assembly.Location.Replace("WildfrostModMiya.dll", "");
    internal static WildFrostTribeAdder Instance;
    internal static List<ClassData> ClassDataAdditions = new List<ClassData>();
    private WildFrostAPIMod.APIGameObject _GameObject;





    public override void Load()
    {
    }

    public class APIGameObject : MonoBehaviour
    {
        public void Update()
        {
            ClassDataAdditions = new List<ClassData>();
            ClassAdder.LaunchEvent();
        }
    }
}