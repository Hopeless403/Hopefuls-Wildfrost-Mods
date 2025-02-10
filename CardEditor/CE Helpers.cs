using Deadpan.Enums.Engine.Components.Modding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using static CardEditor.CardEditorMod;

namespace CardEditor
{
    public static class Helpers
    {
        public static void Log(object message) => Debug.Log(instance != null ? $"[{instance.Title}] {message}" : message);
        public static void LogWarning(object message) => Debug.LogWarning(instance != null ? $"[{instance.Title} Warning] {message}" : message);
        public static void LogError(object message) => Debug.LogError(instance != null ? $"[{instance.Title} Error] {message}" : message);

    }
}
