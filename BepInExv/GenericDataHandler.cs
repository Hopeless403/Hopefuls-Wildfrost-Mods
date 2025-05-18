using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;
using NaughtyAttributes;
using System.Reflection;
using System;
using static Rewired.Utils.Classes.Data.TypeWrapper;
using System.Text.RegularExpressions;
using Locale = UnityEngine.Localization.Locale;
using Il2CppMono.Unity;
using Debug = UnityEngine.Debug;
using FMOD;
using Il2CppSystem.Reflection;
using MemberInfo = System.Reflection.MemberInfo;
using PropertyInfo = System.Reflection.PropertyInfo;

namespace WildfrostHopeMod.CommandsConsole
{
    
    public partial class ConsoleCustom
    {
        public partial class CommandDataBuilderOf
        {
            public class GenericDataHandler : DataHandler<DataFile>
            {
                public override HashSet<string> ManagedFields => [
                    nameof(DataFile.m_CachedPtr),
                    nameof(DataFile.WasCollected),
                    nameof(DataFile.hideFlags),
                    ];

                public override string Info(DataFile data)
                {
                    int tabDepth = 0;
                    string name = data.name;

                    Type actualType = data.GetType();
                    Type sourceType = actualType;
                    while (sourceType.BaseType != typeof(DataFile)) sourceType = sourceType.BaseType;

                    StringBuilder builder = new StringBuilder().AppendLine();

                    //builder.AppendLine("// Remind me @Hopeful to make a proper thing for this using API methods");
                    builder.AppendLine("");
                    builder.AppendLine("");

                    builder.AppendLineDepth(tabDepth, $"new {sourceType.FullName}Builder(this)"); 
                    tabDepth++;

                    if (sourceType == actualType)
                        builder.AppendLineDepth(tabDepth,$".Create({Print(name)})");
                    else
                        builder.AppendLineDepth(tabDepth,$".Create<{actualType.Name}>({Print(name)})");

                    var unmanagedFields = GetUnmanagedFields(data);
                    /*Debug.LogError("unmanaged:");
                    foreach (var f in unmanagedFields)
                        Debug.Log(f.Name);*/


                    bool usesScriptableObjects = false;
                    if (unmanagedFields.Any())
                    {
                        if (actualType == sourceType)
                            builder.AppendLineDepth(tabDepth, $".SubscribeToAfterAllBuildEvent(data =>\n\t{{");
                        else
                            builder.AppendLineDepth(tabDepth, $".SubscribeToAfterAllBuildEvent<{actualType.Name}>(data =>\n\t{{"); 
                        tabDepth++;
                        
                        var defaultInstance = InstantiateDefault(data);
                        if (defaultInstance == null) UnityEngine.Debug.LogError("WHY IS INSTANCE NULL??");
                        foreach (var field in unmanagedFields)
                        {
                            //var defaultFieldValue = (field as PropertyInfo)?.GetValue(defaultInstance);
                            var dataFieldValue = (field as PropertyInfo)?.GetValue(data);

                            if (/*Equals(dataFieldValue, defaultFieldValue)
                                || */dataFieldValue == null
                                || (dataFieldValue is string str && str.IsNullOrWhitespace())
                                || (dataFieldValue is LocalizedString lstr && lstr.IsEmpty)
                                || (dataFieldValue is IEnumerable<object> ienum && !ienum.Any())
                                )
                                continue;

                            if ((dataFieldValue is ScriptableObject obj && obj is not DataFile)
                              || (dataFieldValue is IEnumerable<ScriptableObject> objEnum && objEnum is not IEnumerable<DataFile>))
                                usesScriptableObjects = true;

                            builder.AppendLineDepth(tabDepth, $"data.{field.Name} = {Print(dataFieldValue, tabDepth, ignoreFirstTab: true)};");
                        }
                        defaultInstance.Destroy();
                        tabDepth--;
                        builder.AppendLineDepth(tabDepth,$"}})");
                    }
                    tabDepth--;



                    builder = AppendCodeDependencies(builder, actualType);
                    if (false & usesScriptableObjects)
                    {
                        builder.AppendLine("");
                        builder.AppendLine("#region Code dependencies");
                        builder.AppendLine("""
                            public class Scriptable<T> where T : ScriptableObject, new()
                            {
                                readonly Action<T> modifier;
                                public Scriptable() { }
                                public Scriptable(Action<T> modifier) { this.modifier = modifier; }
                                public static implicit operator T(Scriptable<T> scriptable)
                                {
                                    T result = ScriptableObject.CreateInstance<T>();
                                    scriptable.modifier?.Invoke(result);
                                    return result;
                                }
                            }
                            """);
                        builder.AppendLine("#endregion");
                    }
                    return builder.ToString();
                }
            }
        }
    }
}