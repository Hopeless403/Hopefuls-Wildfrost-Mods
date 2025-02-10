using System;
using System.Collections.Generic;
using System.Diagnostics;
using BepInEx;
using BepInEx.Logging;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Linq;
using HarmonyLib;
using static StatusEffectBonusDamageEqualToX;
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using BepInEx.ConsoleUtil;
using HarmonyLib;
using Microsoft.Win32.SafeHandles;
using MonoMod.Utils;
using UnityInjector.ConsoleUtil;

namespace BCE
{
    public class console
    {
        public static DiskLogListener DiskLogListener;
        public static readonly MethodInfo[] methods = [
            AccessTools.Method("SafeConsole:set_BackgroundColor"),
            AccessTools.Method("Kon:set_BackgroundColor")
            ];
        public static readonly ConsoleColor[] defaults = [
            ConsoleColor.White,
            ConsoleColor.Black,
            ];

        public static void Init()
        {
            if (DiskLogListener != null) return;
            foreach (var listener in BepInEx.Logging.Logger.Listeners)
            {
                if (listener.GetType() == typeof(DiskLogListener))
                {
                    DiskLogListener = (DiskLogListener)listener;
                }
            }
        }
        public static void WriteDisk(string text)
        {
            DiskLogListener?.LogWriter.Write(text);
        }
        public static void WriteLineDisk(string text)
        {
            DiskLogListener?.LogWriter.WriteLine(text);
        }
        public static void WriteLine(string text, ConsoleColor consoleColor, ConsoleColor backgroundColor = ConsoleColor.Black)
        {
            Init();
            ConsoleManager.SetConsoleColor(consoleColor);
            ConsoleManager.StandardOutStream.WriteLine(text);
            if (backgroundColor != default) foreach (var method in methods)
                method.Invoke(null, [backgroundColor]);
            WriteLineDisk(text);
            ConsoleManager.SetConsoleColor(defaults[0]);
            if (backgroundColor != default) foreach (var method in methods)
                method.Invoke(null, [defaults[1]]);
        }
        public static void Write(string text, ConsoleColor consoleColor, ConsoleColor backgroundColor = ConsoleColor.Black)
        {
            Init();
            ConsoleManager.SetConsoleColor(consoleColor);
            ConsoleManager.StandardOutStream.Write(text);
            if (backgroundColor != default) foreach (var method in methods)
                method.Invoke(null, [backgroundColor]);
            WriteDisk(text);
            ConsoleManager.SetConsoleColor(defaults[0]);
            if (backgroundColor != default) foreach (var method in methods)
                method.Invoke(null, [defaults[1]]);
        }
        public static void WriteLineRainbow(string text)
        {
            ConsoleColor[] gay = [
                ConsoleColor.DarkRed,
                ConsoleColor.Red,
                ConsoleColor.Yellow,
                ConsoleColor.Green,
                ConsoleColor.Blue,
                ConsoleColor.DarkMagenta,
                ConsoleColor.Magenta,
                ];
            int i = 0;
            foreach (char c in text)
                Write(c.ToString(), gay[i++ % gay.Length]);
            Write("\n", ConsoleColor.Black);
        }
    }

    public static class MatcherExtensions
    {

        public static void LogILPre(this CodeMatcher _matcher, int lines = 1, int pre = 5, int post = 5, [CallerLineNumber] int lineNumber = 0)
        {
            _DumpMatcher(_matcher, lines, pre, post, lineNumber, 1, GetCallerMethod());
        }
        public static void LogILPost(this CodeMatcher _matcher, int lines = 1, int pre = 5, int post = 5, [CallerLineNumber] int lineNumber = 0)
        {
            _DumpMatcher(_matcher, lines, pre, post, lineNumber, 2, GetCallerMethod());
        }
        public static void LogIL(this CodeMatcher _matcher, int lines = 1, int pre = 5, int post = 5, [CallerLineNumber] int lineNumber = 0)
        {
            _DumpMatcher(_matcher, lines, pre, post, lineNumber, 0, GetCallerMethod());
        }

        public static void Log(this IEnumerable<CodeInstruction> instructions, string method, int start = 0, int count = 0, [CallerLineNumber] int lineNumber = 0)
        {
            var list = instructions.ToList();
            var caller = $"IL for {method} - {GetCallerMethod()} on line {lineNumber}";
            var len = Mathf.Max(caller.Length + 2, 120);
            var pad = len - caller.Length;
            pad /= 2;
            if (list.Count == 0) console.WriteLine($"Instructions Log: List is empty | {GetCallerMethod()} on line {lineNumber}", ConsoleColor.Red);
            if (count == 0) count = list.Count;
            if (start > list.Count) start = 0;


            for (var i = start; i < count + start && i < list.Count; i++)
            {
                var z = list[i];
                var opcode = string.Format("{0,-10}", z.opcode);
                var operand = string.Format("{0,-60}", z.operand);
                console.Write($"  {i}  {opcode} {operand}", ConsoleColor.DarkGray);
                console.WriteLine($" // {z.operand?.GetType()}", ConsoleColor.DarkGreen);
            }
        }


        public static void _DumpMatcher(CodeMatcher _matcher, int lines = 1, int pre = 5, int post = 5, [CallerLineNumber] int lineNumber = 0, int type = 0, string callerMethod = "")
        {
            if (callerMethod == "") callerMethod = GetCallerMethod();
            var prefix = type == 1 ? "Pre" : type == 2 ? "Post" : "";
            var caller = $"{prefix}Transpile IL for {callerMethod} on line {lineNumber}";


            var len = Mathf.Max(caller.Length + 2, 120);
            var pad = len - caller.Length;
            pad /= 2;
            LogTop(len);

            System.Console.WriteLine(string.Format("{0," + pad + "}{1," + pad + "}", "", caller), ConsoleColor.DarkCyan);
            var matcher = _matcher.Clone();
            var step = lines + pre;
            while (matcher.Pos > 0 && step > 1)
            {
                matcher.Advance(-1);
                step--;
            }

            step = pre;
            while (matcher.Remaining > 0 && step > 0)
            {
                var z = matcher.Instruction;

                var opcode = string.Format("{0,-10}", z.opcode);
                var operand = string.Format("{0,-50}", z.operand);
                console.Write($"  {matcher.Pos}  {opcode} {operand}", ConsoleColor.DarkGray);
                console.WriteLine($" // {z.operand?.GetType()}", ConsoleColor.DarkGreen);
                matcher.Advance(1);
                step--;
            }
            step = lines;
            while (matcher.Remaining > 0 && step > 0)
            {
                var z = matcher.Instruction;
                var opcode = string.Format("{0,-10}", z.opcode);
                var operand = string.Format("{0,-50}", z.operand);
                console.Write($"  {matcher.Pos}  {opcode} {operand}", ConsoleColor.White);
                console.WriteLine($" // {z.operand?.GetType()}", ConsoleColor.DarkGreen);
                matcher.Advance(1);
                step--;
            }
            step = post;
            while (matcher.Remaining > 0 && step > 0)
            {
                var z = matcher.Instruction;
                var opcode = string.Format("{0,-10}", z.opcode);
                var operand = string.Format("{0,-50}", z.operand);
                console.Write($"  {matcher.Pos}  {opcode} {operand}", ConsoleColor.DarkGray);
                console.WriteLine($" // {z.operand?.GetType()}", ConsoleColor.DarkGreen);
                matcher.Advance(1);
                step--;
            }
            LogBot(len);
        }
        public static void LogTop(int width = 80)
        {
            var insert = width - 21;
            var insertLeft = Mathf.FloorToInt(insert / 2) - 2;
            var insertRight = insert - insertLeft - 4;
            console.Write("\r\n╔═", ConsoleColor.White);
            console.Write("═", ConsoleColor.Gray);
            console.Write("═", ConsoleColor.DarkGray);
            console.Write(SpaceString(insertLeft), ConsoleColor.Green);
            console.Write("*", ConsoleColor.Yellow);
            console.Write(".·", ConsoleColor.Gray);
            console.Write(":", ConsoleColor.DarkGray);
            console.Write("·.", ConsoleColor.Gray);
            console.Write("✧", ConsoleColor.DarkCyan);
            console.Write(" ✦ ", ConsoleColor.Cyan);
            console.Write("✧", ConsoleColor.DarkCyan);
            console.Write(".·", ConsoleColor.Gray);
            console.Write(":", ConsoleColor.DarkGray);
            console.Write("·.", ConsoleColor.Gray);
            console.Write("*", ConsoleColor.Yellow);
            console.Write(SpaceString(insertRight), ConsoleColor.Green);
            console.Write("═", ConsoleColor.DarkGray);
            console.Write("═", ConsoleColor.Gray);
            console.Write("═╗\r\n", ConsoleColor.White);
        }

        public static void LogBot(int width = 80)
        {
            var insert = width - 21;
            var insertLeft = Mathf.FloorToInt(insert / 2) - 2;
            var insertRight = insert - insertLeft - 4;
            console.Write("╚═", ConsoleColor.White);
            console.Write("═", ConsoleColor.Gray);
            console.Write("═", ConsoleColor.DarkGray);
            console.Write(SpaceString(insertLeft), ConsoleColor.Green);
            console.Write("*", ConsoleColor.Yellow);
            console.Write(".·", ConsoleColor.Gray);
            console.Write(":", ConsoleColor.DarkGray);
            console.Write("·.", ConsoleColor.Gray);
            console.Write("✧", ConsoleColor.DarkCyan);
            console.Write(" ✦ ", ConsoleColor.Cyan);
            console.Write("✧", ConsoleColor.DarkCyan);
            console.Write(".·", ConsoleColor.Gray);
            console.Write(":", ConsoleColor.DarkGray);
            console.Write("·.", ConsoleColor.Gray);
            console.Write("*", ConsoleColor.Yellow);
            console.Write(SpaceString(insertRight), ConsoleColor.Green);

            console.Write("═", ConsoleColor.DarkGray);
            console.Write("═", ConsoleColor.Gray);
            console.WriteLine("═╝", ConsoleColor.White);
        }

        public static string SpaceString(int spaces)
        {
            return new string(' ', spaces);
        }
        public static string GetCallerMethod()
        {
            var depth = 2;
            var stackTrace = new StackTrace();
            if (stackTrace.FrameCount <= depth) return "";

            var methodName = stackTrace.GetFrame(depth).GetMethod().Name;
            var reflectedType = stackTrace.GetFrame(depth).GetMethod().ReflectedType;
            if (reflectedType != null)
            {
                var classPath = reflectedType.ToString().Split('.');
                var className = classPath[classPath.Length - 1];
                if (className.Contains("+")) className = className.Split('+')[0];
                if (methodName == ".ctor") methodName = "<Constructor>";
                else
                {
                    if (methodName.Contains(">")) methodName = methodName.Split('>')[0];
                    methodName = methodName.Replace("<", "");
                }
                return className + ":" + methodName;
            }

            return "ERROR GETTING CALLER";
        }
    }
}