using Deadpan.Enums.Engine.Components.Modding;
using FMODUnity;
using HarmonyLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static WildFlipper.WildFlipperMod;

namespace WildFlipper
{
    public static class Helpers
    {
        public static Y Edit<T, Y>(this T data) where T : DataFile where Y : DataFileBuilder<T, Y>, new()
        {
            Y y = new Y();
            y.Mod = data.ModAdded ?? (WildfrostMod)new InternalMod((string)null);
            y._data = data;
            return y;
        }
        public static CardDataBuilder Edit(this CardData data)
        {
            return data.Edit<CardData, CardDataBuilder>();
        }

        public static void Log(object message) => Debug.Log($"[{instance.Title}] {message}");
        public static void LogWarning(object message) => Debug.LogWarning($"[{instance.Title} Warning] {message}");
        public static void LogError(object message) => Debug.LogError($"[{instance.Title} Error] {message}");

        public static StatusEffectDataBuilder Create<T>(this StatusEffectDataBuilder builder, string name, Action<T> modifier) where T : StatusEffectData
        {
            if (modifier != null)
                return builder.Create<T>(name).SubscribeToAfterAllBuildEvent(d => modifier((T)d));
            else return builder.Create<T>(name);
        }

        public class Tags
        {
            public static string Keyword(string name) => $"<keyword={name.ToLower()}>";
        }
    }
}