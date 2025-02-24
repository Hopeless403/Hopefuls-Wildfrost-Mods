using HarmonyLib.Public.Patching;
using HarmonyLib;
using Mono.Cecil.Cil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;
using OpCodes = Mono.Cecil.Cil.OpCodes;
using MonoMod.Cil;
using OpCode = Mono.Cecil.Cil.OpCode;
using static UnityEngine.Rendering.DebugUI;

namespace WildfrostHopeMod.RemoveAchievements
{
    internal static class ExtensionsForHarmony
    {
        public static Type OpenRefType(this Type t)
        {
            if (t.IsByRef)
            {
                return t.GetElementType();
            }

            return t;
        }
        public static Mono.Cecil.Cil.OpCode GetCecilLoadOpCode(this Type t)
        {
            if (t.IsEnum)
            {
                return Mono.Cecil.Cil.OpCodes.Ldind_I4;
            }

            if (!loadOpCodes.TryGetValue(t, out var value))
            {
                return Mono.Cecil.Cil.OpCodes.Ldind_Ref;
            }

            return value;
        }
        public static Dictionary<Type, Mono.Cecil.Cil.OpCode> loadOpCodes = new Dictionary<Type, Mono.Cecil.Cil.OpCode>
        {
            [typeof(sbyte)] = Mono.Cecil.Cil.OpCodes.Ldind_I1,
            [typeof(byte)] = Mono.Cecil.Cil.OpCodes.Ldind_I1,
            [typeof(short)] = Mono.Cecil.Cil.OpCodes.Ldind_I2,
            [typeof(ushort)] = Mono.Cecil.Cil.OpCodes.Ldind_I2,
            [typeof(int)] = Mono.Cecil.Cil.OpCodes.Ldind_I4,
            [typeof(uint)] = Mono.Cecil.Cil.OpCodes.Ldind_I4,
            [typeof(long)] = Mono.Cecil.Cil.OpCodes.Ldind_I8,
            [typeof(ulong)] = Mono.Cecil.Cil.OpCodes.Ldind_I8,
            [typeof(float)] = Mono.Cecil.Cil.OpCodes.Ldind_R4,
            [typeof(double)] = Mono.Cecil.Cil.OpCodes.Ldind_R8
        };
        public static Mono.Cecil.Cil.OpCode GetCecilStoreOpCode(this Type t)
        {
            if (t.IsEnum)
            {
                return Mono.Cecil.Cil.OpCodes.Stind_I4;
            }

            if (!storeOpCodes.TryGetValue(t, out var value))
            {
                return Mono.Cecil.Cil.OpCodes.Stind_Ref;
            }

            return value;
        }
        public static Dictionary<Type, Mono.Cecil.Cil.OpCode> storeOpCodes = new Dictionary<Type, Mono.Cecil.Cil.OpCode>
        {
            [typeof(sbyte)] = Mono.Cecil.Cil.OpCodes.Stind_I1,
            [typeof(byte)] = Mono.Cecil.Cil.OpCodes.Stind_I1,
            [typeof(short)] = Mono.Cecil.Cil.OpCodes.Stind_I2,
            [typeof(ushort)] = Mono.Cecil.Cil.OpCodes.Stind_I2,
            [typeof(int)] = Mono.Cecil.Cil.OpCodes.Stind_I4,
            [typeof(uint)] = Mono.Cecil.Cil.OpCodes.Stind_I4,
            [typeof(long)] = Mono.Cecil.Cil.OpCodes.Stind_I8,
            [typeof(ulong)] = Mono.Cecil.Cil.OpCodes.Stind_I8,
            [typeof(float)] = Mono.Cecil.Cil.OpCodes.Stind_R4,
            [typeof(double)] = Mono.Cecil.Cil.OpCodes.Stind_R8
        };

        
    }

    [HarmonyPatch]
    internal class Patching_the_Patcher
    {
        private static readonly string ARGS_ARRAY_VAR = "__args";


        private static readonly string INSTANCE_PARAM = "__instance";

        private static readonly string ORIGINAL_METHOD_PARAM = "__originalMethod";

        private static readonly string RUN_ORIGINAL_PARAM = "__runOriginal";

        private static readonly string RESULT_VAR = "__result";

        private static readonly string STATE_VAR = "__state";

        private static readonly string EXCEPTION_VAR = "__exception";

        private static readonly string PARAM_INDEX_PREFIX = "__";

        private static readonly string INSTANCE_FIELD_PREFIX = "___";

        static Type ilEmitterType = AccessTools.TypeByName("HarmonyLib.Internal.Util.ILEmitter");

        [HarmonyPrefix]
        [HarmonyPatch(typeof(HarmonyManipulator), "MakePatched")]
        public static bool MakePatched(MethodBase original, ILContext ctx, List<object> prefixes, List<object> postfixes, List<object> transpilers, List<object> finalizers, List<object> ilmanipulators, bool debug)
        {
            //Debug.LogError("MADE PATCH??");
            try
            {
                if ((object)original == null)
                {
                    //throw new ArgumentException("original");
                    return true;
                }

                //Logger.Log(Logger.LogChannel.Info, () => "Running ILHook manipulator on " + original.FullDescription(), debug);
                //Debug.LogError($"GOT TRANSPILERER: {AccessTools.DeclaredMethod(typeof(HarmonyManipulator), "WriteTranspiledMethod")}");
                AccessTools.DeclaredMethod(typeof(HarmonyManipulator), "WriteTranspiledMethod").Invoke(null, parameters: [ctx, original, transpilers, debug]);
                //WriteTranspiledMethod(ctx, original, transpilers, debug);
                if (prefixes.Count + postfixes.Count + finalizers.Count + ilmanipulators.Count == 0)
                {
                    //Logger.Log(Logger.LogChannel.IL, () => "Generated patch (" + ctx.Method.FullName + "):\n" + ctx.Body.ToILDasmString(), debug);
                    return true;
                }

                //ILEmitter iLEmitter = new ILEmitter(ctx.IL);
                var iLEmitter = Activator.CreateInstance(ilEmitterType, ctx.IL);

                //ILEmitter.Label label = MakeReturnLabel(iLEmitter);
                var label = AccessTools.DeclaredMethod(typeof(HarmonyManipulator), "MakeReturnLabel").Invoke(null, parameters: [iLEmitter]);

                Dictionary<string, VariableDefinition> dictionary = new Dictionary<string, VariableDefinition>();
                foreach (object item in prefixes.Union(postfixes).Union(finalizers))
                {
                    MethodInfo method = (MethodInfo)item.GetType().GetField("method").GetValue(item);
                    //
                    ParameterInfo[] parameters = method.GetParameters();
                    ParameterInfo parameterInfo = parameters.FirstOrDefault((ParameterInfo p) => p.Name == ARGS_ARRAY_VAR);
                    if (parameterInfo != null)
                    {
                        if ((object)parameterInfo.ParameterType != typeof(object[]))
                        {
                            throw new InvalidHarmonyPatchArgumentException($"Patch {method.FullDescription()} defines __args list, but only type `object[]` is permitted", original, method);
                        }

                        //dictionary[ARGS_ARRAY_VAR] = il.DeclareVariable(typeof(object[]));
                        dictionary[ARGS_ARRAY_VAR] = (VariableDefinition)AccessTools.DeclaredMethod(ilEmitterType, "DeclareVariable")?.Invoke(iLEmitter, parameters: [typeof(object[])]);
                    }
                    //
                    if (method.DeclaringType == null || dictionary.ContainsKey(method.DeclaringType.FullName))
                    {
                        continue;
                    }

                    foreach (ParameterInfo item2 in from patchParam in method.GetParameters()
                                                    where patchParam.Name == STATE_VAR
                                                    select patchParam)
                    {
                        //dictionary[method.DeclaringType.FullName] = iLEmitter.DeclareVariable(item2.ParameterType.OpenRefType());
                        dictionary[method.DeclaringType.FullName] = (VariableDefinition)AccessTools.DeclaredMethod(ilEmitterType, "DeclareVariable")?.Invoke(iLEmitter, parameters: [item2.ParameterType.OpenRefType()]);
                    }
                }

                //Debug.LogError("TO WRITE PREFIXES");
                //int num = 0 | (WritePrefixes(iLEmitter, original, label, dictionary, prefixes, debug) ? 1 : 0);
                int num = 0 | (((bool)AccessTools.DeclaredMethod(typeof(HarmonyManipulator), "WritePrefixes").Invoke(null, parameters: [iLEmitter, original, label, dictionary, prefixes, debug])) ? 1 : 0);

                //Debug.LogError("TO WRITE PoSTFIXES");
                //WritePostfixes(iLEmitter, original, label, dictionary, postfixes, debug);
                AccessTools.DeclaredMethod(typeof(HarmonyManipulator), "WritePostfixes").Invoke(null, parameters: [iLEmitter, original, label, dictionary, postfixes, debug]);

                //int num2 = num | (WriteFinalizers(iLEmitter, original, label, dictionary, finalizers, debug) ? 1 : 0);
                int num2 = num | (((bool)AccessTools.DeclaredMethod(typeof(HarmonyManipulator), "WriteFinalizers").Invoke(null, parameters: [iLEmitter, original, label, dictionary, finalizers, debug])) ? 1 : 0);

                //iLEmitter.MarkLabel(label);
                AccessTools.DeclaredMethod(ilEmitterType, "MarkLabel")?.Invoke(iLEmitter, parameters: [label]);

                //Debug.LogError("GOT TO THE END!!");//return true;

                //Instruction instruction = iLEmitter.SetOpenLabelsTo(ctx.Instrs[ctx.Instrs.Count - 1]);
                Instruction instruction = (Instruction)AccessTools.DeclaredMethod(ilEmitterType, "SetOpenLabelsTo")?.Invoke(iLEmitter, parameters: [ctx.Instrs[ctx.Instrs.Count - 1]]);
                if (num2 != 0)
                {
                    instruction.OpCode = OpCodes.Ret;
                }

                //
                if (dictionary.TryGetValue(ARGS_ARRAY_VAR, out VariableDefinition value))
                {
                    //il.emitBefore = ctx.Instrs[0];
                    ilEmitterType.GetField("emitBefore").SetValue(iLEmitter, ctx.Instrs[0]);
                    EmitInitArgsArray(iLEmitter, original);
                    //il.Emit(OpCodes.Stloc, value);
                    Emit(iLEmitter, OpCodes.Stloc, value);
                }
                //

                //ApplyILManipulators(ctx, original, ilmanipulators.Select((PatchContext m) => m.method).ToList(), label);
                List<MethodInfo> ilmanipulatorMethods = ilmanipulators.Select(item => (MethodInfo)item.GetType().GetField("method").GetValue(item)).ToList();
                AccessTools.DeclaredMethod(typeof(HarmonyManipulator), "ApplyILManipulators").Invoke(null, parameters: [ctx, original, ilmanipulatorMethods, label]);

                //Logger.Log(Logger.LogChannel.IL, () => "Generated patch (" + ctx.Method.FullName + "):\n" + ctx.Body.ToILDasmString(), debug);
                //Debug.LogError($"GENERATED PATCH!! ({ctx.Method.FullName})");
                return false;
            }
            catch (Exception ex)
            {
                Debug.LogError($"Failed to patch {original.FullDescription()}: {ex}");
            }
            return true;
        }

        




        // EMIT METHODS
        

        private static void EmitInitArgsArray(object iLEmitter, MethodBase original)
        {
            ParameterInfo[] parameters = original.GetParameters();
            int num = ((!original.IsStatic) ? 1 : 0);
            for (int i = 0; i < parameters.Length; i++)
            {
                ParameterInfo parameterInfo = parameters[i];
                if (parameterInfo.IsOut || parameterInfo.IsRetval)
                {
                    EmitOutParameter(iLEmitter, i + num, parameterInfo.ParameterType.OpenRefType());
                }
            }

            //il.Emit(OpCodes.Ldc_I4, parameters.Length);
            Emit(iLEmitter, OpCodes.Ldc_I4, parameters.Length);

            //il.Emit(OpCodes.Newarr, typeof(object));
            Emit(iLEmitter, OpCodes.Newarr, typeof(object));

            for (int j = 0; j < parameters.Length; j++)
            {
                Type parameterType = parameters[j].ParameterType;
                Type type = parameterType.OpenRefType();
                //il.Emit(OpCodes.Dup);
                Emit(iLEmitter, OpCodes.Dup);

                //il.Emit(OpCodes.Ldc_I4, j);
                Emit(iLEmitter, OpCodes.Ldc_I4, j);

                //il.Emit(OpCodes.Ldarg, j + num);
                Emit(iLEmitter, OpCodes.Ldarg, j + num);

                if (parameterType.IsByRef)
                {
                    if (AccessTools.IsStruct(type))
                    {
                        //il.Emit(OpCodes.Ldobj, type);
                        Emit(iLEmitter, OpCodes.Ldobj, type);
                    }
                    else
                    {
                        //il.Emit(type.GetCecilLoadOpCode());
                        Emit(iLEmitter, type.GetCecilLoadOpCode());
                    }
                }

                if (type.IsValueType)
                {
                    //il.Emit(OpCodes.Box, type);
                    Emit(iLEmitter, OpCodes.Box, type);
                }

                //il.Emit(OpCodes.Stelem_Ref);
                Emit(iLEmitter, OpCodes.Stelem_Ref);
            }
        }
        private static void EmitOutParameter(object iLEmitter, int arg, Type t)
        {
            t = t.OpenRefType();
            //il.Emit(OpCodes.Ldarg, arg);
            Emit(iLEmitter, OpCodes.Ldarg, arg);

            if (AccessTools.IsStruct(t))
            {
                //il.Emit(OpCodes.Initobj, t);
                Emit(iLEmitter, OpCodes.Initobj, t);
            }
            else if (AccessTools.IsValue(t))
            {
                double num = 0.0;
                OpCode opcode;
                OpCode opcode2;

                if (t == typeof(float))
                    (num, opcode, opcode2) = (0.0, OpCodes.Ldc_R4, OpCodes.Stind_R4);
                else if (t == typeof(double))
                    (num, opcode, opcode2) = (0.0, OpCodes.Ldc_R8, OpCodes.Stind_R8);
                else if (t == typeof(long))
                    (num, opcode, opcode2) = (0.0, OpCodes.Ldc_I8, OpCodes.Stind_I8);
                else
                    (num, opcode, opcode2) = (0.0, OpCodes.Ldc_I4, t.GetCecilStoreOpCode());

                //il.EmitUnsafe(opcode, num);
                Emit(iLEmitter, opcode, (int)num);
                //il.Emit(opcode2);
                Emit(iLEmitter, opcode2);
            }
            else
            {
                //il.Emit(OpCodes.Ldnull);
                Emit(iLEmitter, OpCodes.Ldnull);
                //il.Emit(OpCodes.Stind_Ref);
                Emit(iLEmitter, OpCodes.Stind_Ref);
            }
        }

        public static void Emit(object iLEmitter, OpCode opcode)
        {
            emitMethods[typeof(void)].Invoke(iLEmitter, parameters: [opcode]);
        }
        public static void Emit(object iLEmitter, OpCode opcode, int value)
        {
            emitMethods[typeof(int)].Invoke(iLEmitter, parameters: [opcode, value]);
        }
        public static void Emit(object iLEmitter, OpCode opcode, Type value)
        {
            emitMethods[typeof(Type)].Invoke(iLEmitter, parameters: [opcode, value]);
        }
        public static void Emit(object iLEmitter, OpCode opcode, VariableDefinition value)
        {
            emitMethods[typeof(VariableDefinition)].Invoke(iLEmitter, parameters: [opcode, value]);
        }
        //public static Type ilEmitterType = AccessTools.TypeByName("HarmonyLib.Internal.Util.ILEmitter");
        public static readonly Dictionary<Type, MethodInfo> emitMethods = new Dictionary<Type, MethodInfo>
        {
            [typeof(void)] = ilEmitterType.GetMethod("Emit", [typeof(OpCode)]),
            [typeof(int)] = ilEmitterType.GetMethod("Emit", [typeof(OpCode), typeof(int)]),
            [typeof(Type)] = ilEmitterType.GetMethod("Emit", [typeof(OpCode), typeof(Type)]),
            [typeof(VariableDefinition)] = ilEmitterType.GetMethod("Emit", [typeof(OpCode), typeof(VariableDefinition)]),
        };




        [HarmonyFinalizer]
        [HarmonyPatch(typeof(HarmonyManipulator), "EmitCallParameter")]
        public static Exception EmitCallParameterFinalizer(object il, MethodBase original, MethodInfo patch, Dictionary<string, VariableDefinition> variables, bool allowFirsParamPassthrough)
        {
            //Debug.LogError("TRYING TO EMIT THE ARGS");

            List<ParameterInfo> list = patch.GetParameters().ToList();
            if (allowFirsParamPassthrough && (object)patch.ReturnType != typeof(void) && list.Count > 0 && (object)list[0].ParameterType == patch.ReturnType)
            {
                list.RemoveRange(0, 1);
            }

            if (list.Count > 0 && list.Last().Name == ARGS_ARRAY_VAR)
            {
                //Debug.LogWarning("FOUND AN ARGS PARAMETER???!!!");
                /*if (variables.TryGetValue(ARGS_ARRAY_VAR, out var value))
                {
                    //il.Emit(OpCodes.Ldloc, value);
                    ilEmitterType.GetMethod("Emit", [typeof(OpCode), typeof(VariableDefinition)]).Invoke(il, parameters: [OpCodes.Ldloc, value]);
                }
                else
                {
                    //il.Emit(OpCodes.Ldnull);
                    ilEmitterType.GetMethod("Emit", [typeof(OpCode)]).Invoke(il, parameters: [OpCodes.Ldnull]);
                }*/
            }

            //Debug.LogError("EMITTED THE ARGS");
            return null;
        }


        /*[HarmonyPostfix]
        [HarmonyPatch(typeof(HarmonyManipulator), "EmitCallParameter")]
        public static void Debugger(
        MethodBase __originalMethod,
        MethodBase original, MethodInfo patch, Dictionary<string, VariableDefinition> variables, bool allowFirsParamPassthrough)
        {
            Debug.LogError($"======== PATCHING THE PATCHER ========");
            Debug.LogError($"======== {original.FullDescription()} ========");

            foreach (var item in patch.GetParameters())
                Debug.Log((item.Name, item));
            foreach (var item in variables)
                Debug.LogWarning((item.Key, item.Value));
        }*/
    }
}
