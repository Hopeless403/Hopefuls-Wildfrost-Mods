using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using HarmonyLib;
using UnityExplorer;
using UnityExplorer.UI;
using System.Text;
using NaughtyAttributes;
using UniverseLib;
using UnityEngine.Localization;
using TMPro;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityExplorer.Inspectors;
using UnityExplorer.CacheObject;
using UnityExplorer.CacheObject.Views;
using Unity.Burst.Intrinsics;

namespace WildfrostHopeMod.CommandsConsole;

internal static class StringBuilderExt
{
    internal static StringBuilder AppendLineDepth(this StringBuilder builder, int tabDepth, object obj)
        => builder.AppendLine(new string('\t', tabDepth) + obj.ToString());
    internal static StringBuilder AppendDepth(this StringBuilder builder, int tabDepth, object obj)
        => builder.Append(new string('\t', tabDepth) + obj.ToString());
}
public partial class ConsoleCustom
{


        class MemberInfoComparer : IEqualityComparer<MemberInfo>
        {
            public bool Equals(MemberInfo x, MemberInfo y)
                => x.ToString() == y.ToString();

            public int GetHashCode(MemberInfo obj)
                => obj.ToString().GetHashCode();

        }

        // memoization pog
        static readonly Dictionary<Type, List<MemberInfo>> typeMembers = [];
        static readonly Dictionary<MemberInfo, object> defaultValues = [];
        internal static List<PropertyInfo> FindFields(Type dataType)
        {
            if (!typeof(ScriptableObject).IsAssignableFrom(dataType) || dataType == typeof(ScriptableObject))
                return [];
            if (!typeMembers.ContainsKey(dataType))
            {
                PropertyInfo[] members = dataType.GetProperties().Where(p => p.CanWrite).ToArray();

                HashSet<string> names = members.Select(m => m.Name).ToHashSet();
                var fields = members
                    .Where(f
                    => !names.Contains("add_" + f.Name) // deal with events
                    //&& f is FieldInfo field
                    /*&& (field.IsPublic || field.GetCustomAttribute<SerializeField>() != null)
                    && (field.GetCustomAttribute<HideInInspector>() == null)
                    && (field.GetCustomAttribute<ReadOnlyAttribute>() == null) // unstable; use with debug mode probably
                    */);

                typeMembers[dataType] = FindFields(dataType.BaseType).Concat(fields).Distinct(new MemberInfoComparer()).ToList();

                /*try
                {
                    var assemblyResolver = new ICSharpCode.Decompiler.Metadata.UniversalAssemblyResolver(
                                mainAssemblyFileName: dataType.Assembly.Location,
                                throwOnError: false,
                                targetFramework: ".NET Framework,Version=4.7.2");
                    string workshop = Application.dataPath;
                    int i = workshop.IndexOf("Steam/steamapps/");
                    string local = System.IO.Path.Combine(Application.streamingAssetsPath, "Mods");

                    if (i != -1)
                        workshop = workshop[..i] + $"Steam/steamapps/workshop/content/{SteamManager.appId}";
                    System.IO.Directory.GetDirectories(workshop).Update(assemblyResolver.AddSearchDirectory);
                    System.IO.Directory.GetDirectories(local).Update(assemblyResolver.AddSearchDirectory);

                    var decompiler = new ICSharpCode.Decompiler.CSharp.CSharpDecompiler(
                        fileName: dataType.Assembly.Location,
                        assemblyResolver: assemblyResolver,
                        settings: new ICSharpCode.Decompiler.DecompilerSettings(ICSharpCode.Decompiler.CSharp.LanguageVersion.Latest)
                        );
                    string decompiled = decompiler.DecompileTypeAsString(new(dataType.FullName));

                    foreach (var field in fields)
                    {
                        // match for parts of the string that go like
                        // field;
                        // field = yadayada;
                        // field = yadayada{
                        //  };
                        Match match = new Regex($@"{field.Name};|{field.Name} = ([^;]*)*;").Match(decompiled);
                        if (match.Success)
                        {
                            defaultValues[field] = match.Captures[0].Value.Replace(field.Name, "");
                        }
                    }
                }
                catch { }*/
            }

            return typeMembers[dataType].OfType<PropertyInfo>().ToList();
        }
        internal static string GetTypeFields(Type dataType)
        {
            StringBuilder builder = new();
            builder.AppendLine(dataType.FullDescription());
            foreach (var field in FindFields(dataType))
            {
                /*var headerAttr = field.GetCustomAttribute<HeaderAttribute>();
                if (headerAttr != null && !headerAttr.header.IsNullOrWhitespace())
                    builder.AppendLine($"\n// {headerAttr.header}");

                var infoboxAttr = field.GetCustomAttribute<InfoBoxAttribute>();
                if (infoboxAttr != null && !infoboxAttr.Text.IsNullOrWhitespace())
                    builder.AppendLine($"\n// {infoboxAttr.Text}");*/

                if (defaultValues.TryGetValue(field, out var defaultValue))
                    builder.AppendLine($"{field}{defaultValue}");
                else
                    builder.AppendLine($"{field};");
                //builder.AppendLine($"({field.ReflectedType})\t{field}");
            }
            Debug.LogWarning(builder.ToString());
            return builder.ToString();
        }
    }
