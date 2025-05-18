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
using Deadpan.Enums.Engine.Components.Modding;
using ICSharpCode.Decompiler.CSharp.Syntax;

namespace WildfrostHopeMod.CommandsConsole
{
    
    public partial class ConsoleCustom
    {
        public partial class CommandDataBuilderOf
        {
            public class GenericDataHandler : DataHandler<DataFile>
            {
                public override HashSet<string> ManagedFields => [
                    nameof(DataFile.ModAdded),
                    ];

                public override string Info(DataFile data)
                {
                    int tabDepth = 0;
                    string name = data.name.Replace(data.ModAdded?.GUID + ".", "");

                    Type actualType = data.GetType();
                    Type sourceType = actualType;
                    while (sourceType.BaseType != typeof(DataFile)) sourceType = sourceType.BaseType;

                    StringBuilder builder = new StringBuilder().AppendLine();

                    builder.AppendLine("// Remind me @Hopeful to make a proper thing for this using API methods");
                    builder.AppendLine("");
                    builder.AppendLine("");

                    builder.AppendLineDepth(tabDepth, $"new {sourceType.FullName}Builder(this)"); 
                    tabDepth++;

                    if (sourceType == actualType)
                        builder.AppendLineDepth(tabDepth,$".Create({Print(name)})");
                    else
                        builder.AppendLineDepth(tabDepth,$".Create<{actualType.Name}>({Print(name)})");

                    var unmanagedFields = GetUnmanagedFields(data);
                    bool usesScriptableObjects = false;
                    if (unmanagedFields.Any())
                    {
                        if (actualType == sourceType)
                            builder.AppendLineDepth(tabDepth, $".SubscribeToAfterAllBuildEvent(data =>\n\t{{");
                        else
                            builder.AppendLineDepth(tabDepth, $".SubscribeToAfterAllBuildEvent<{actualType.Name}>(data =>\n\t{{"); 
                        tabDepth++;
                        
                        var defaultInstance = InstantiateDefault(data);

                        foreach (var field in unmanagedFields)
                        {
                            var defaultFieldValue = (field as FieldInfo)?.GetValue(defaultInstance);
                            var dataFieldValue = (field as FieldInfo)?.GetValue(data);

                            if (Equals(dataFieldValue, defaultFieldValue)
                                || dataFieldValue == null
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
                    if (usesScriptableObjects)
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