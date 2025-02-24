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
        /// <summary>
        /// Convert `ref Type` and `out Type` to `Type`
        /// </summary>
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
                if (original == null)
                {
                    return true;
                }
                if (prefixes.Count + postfixes.Count + finalizers.Count + ilmanipulators.Count == 0)
                {
                    return true;
                }
                
                AccessTools.DeclaredMethod(typeof(HarmonyManipulator), "WriteTranspiledMethod").Invoke(null, parameters: [ctx, original, transpilers, debug]);
                

                var iLEmitter = Activator.CreateInstance(ilEmitterType, ctx.IL);
                var label = AccessTools.DeclaredMethod(typeof(HarmonyManipulator), "MakeReturnLabel").Invoke(null, parameters: [iLEmitter]);

                Dictionary<string, VariableDefinition> variables = new Dictionary<string, VariableDefinition>();
                foreach (object item in prefixes.Union(postfixes).Union(finalizers))
                {
                    MethodInfo method = (MethodInfo)item.GetType().GetField("method").GetValue(item);

                    /// If "__args" is a named variable in the HarmonyPatch (postfix etc),
                    /// Assign an empty `object[]` to the value of __args when the patch is called
                    /// (Later, this value is changed to the actual args)
                    //
                    ParameterInfo[] parameters = method.GetParameters();
                    ParameterInfo parameterInfo = parameters.FirstOrDefault((ParameterInfo p) => p.Name == ARGS_ARRAY_VAR);
                    if (parameterInfo != null)
                    {
                        if ((object)parameterInfo.ParameterType != typeof(object[]))
                        {
                            throw new InvalidHarmonyPatchArgumentException($"Patch {method.FullDescription()} defines __args list, but only type `object[]` is permitted", original, method);
                        }

                        variables[ARGS_ARRAY_VAR] = (VariableDefinition)AccessTools.DeclaredMethod(ilEmitterType, "DeclareVariable")?.Invoke(iLEmitter, parameters: [typeof(object[])]);
                    }
                    //

                    if (method.DeclaringType == null || variables.ContainsKey(method.DeclaringType.FullName))
                    {
                        continue;
                    }

                    foreach (ParameterInfo item2 in method.GetParameters().Where(patchParam => patchParam.Name == STATE_VAR))
                    {
                        variables[method.DeclaringType.FullName] = (VariableDefinition)AccessTools.DeclaredMethod(ilEmitterType, "DeclareVariable")?.Invoke(iLEmitter, parameters: [item2.ParameterType.OpenRefType()]);
                    }
                }

                //Debug.LogWarning("TO RUN: " + AccessTools.DeclaredMethod(typeof(HarmonyManipulator), "WritePrefixes").FullDescription());
                //Debug.LogWarning("TO USE: " + (iLEmitter, original, label, variables, prefixes, debug));
                //return true;

                int num = 0 | (((bool)AccessTools.DeclaredMethod(typeof(HarmonyManipulator), "WritePrefixes").Invoke(null, parameters: [iLEmitter, original, label, variables, prefixes, debug])) ? 1 : 0);
                AccessTools.DeclaredMethod(typeof(HarmonyManipulator), "WritePostfixes").Invoke(null, parameters: [iLEmitter, original, label, variables, postfixes, debug]);
                int num2 = num | (((bool)AccessTools.DeclaredMethod(typeof(HarmonyManipulator), "WriteFinalizers").Invoke(null, parameters: [iLEmitter, original, label, variables, finalizers, debug])) ? 1 : 0);
                AccessTools.DeclaredMethod(ilEmitterType, "MarkLabel")?.Invoke(iLEmitter, parameters: [label]);

                Instruction instruction = (Instruction)AccessTools.DeclaredMethod(ilEmitterType, "SetOpenLabelsTo")?.Invoke(iLEmitter, parameters: [ctx.Instrs[ctx.Instrs.Count - 1]]);
                if (num2 != 0)
                {
                    instruction.OpCode = OpCodes.Ret;
                }

                //
                /// If "__args" is a named variable in the HarmonyPatch (postfix etc),
                /// (and an `object[]` was declared in the variables, earlier)
                /// ...
                if (variables.TryGetValue(ARGS_ARRAY_VAR, out VariableDefinition value))
                {
                    /// Before any custom instructions run (such as prefixes)
                    /// insert our code which grabs the initial values of args
                    /// (ensuring that the values aren't changed by prefixes)
                    ilEmitterType.GetField("emitBefore").SetValue(iLEmitter, ctx.Instrs[0]);

                    /// Create an `object[]` array to the top of the stack
                    /// whose values are the initial values of the args
                    /// except for `out` variables which get default values
                    EmitInitArgsArray(iLEmitter, original);

                    /// Pops a value from the stack and stores it in local variable at `value`
                    /// thereby replacing the `__args` variable with the `object[]` containing the args
                    Emit(iLEmitter, OpCodes.Stloc, value);
                }
                //

                List<MethodInfo> ilmanipulatorMethods = ilmanipulators.Select(item => (MethodInfo)item.GetType().GetField("method").GetValue(item)).ToList();
                AccessTools.DeclaredMethod(typeof(HarmonyManipulator), "ApplyILManipulators").Invoke(null, parameters: [ctx, original, ilmanipulatorMethods, label]);

                return false;
            }
            catch (Exception ex)
            {
                Debug.LogError($"!!!!!!!!!!!! Failed to patch {original.FullDescription()}: {ex}");
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
                    // Initialize the default values ('references) for `out` parameters
                    //  For structs, that's just a default value
                    //  For numbers, that's a reference to a 0
                    //  Otherwise, that's a null reference
                    EmitOutParameter(iLEmitter, i + num, parameterInfo.ParameterType.OpenRefType());
                }
            }

            // ?Equivalent to `new object[parameters.Length]`
            /// Pushes an int32 onto the evaluation stack with value `parameters.Length`
            Emit(iLEmitter, OpCodes.Ldc_I4, parameters.Length);
            /// Create a new array with elements of type `typeof(object)`
            /// ?with length equal to the current top int32 on the evaluation stack, which is `parameters.Length`
            Emit(iLEmitter, OpCodes.Newarr, typeof(object));

            for (int j = 0; j < parameters.Length; j++)
            {
                Type parameterType = parameters[j].ParameterType;
                Type type = parameterType.OpenRefType(); // actual element type

                /// Duplicate the value on the top of the stack
                /// which duplicates the `object[]` array
                Emit(iLEmitter, OpCodes.Dup);
                /// Pushes an int32 onto the evaluation stack with value `j`
                Emit(iLEmitter, OpCodes.Ldc_I4, j);
                /// Load argument numbered `j + num` onto the stack
                Emit(iLEmitter, OpCodes.Ldarg, j + num);

                if (parameterType.IsByRef)
                {
                    if (AccessTools.IsStruct(type))
                    {
                        /// Copies the value type object pointed to by an address to the top of the evaluation stack, as type `type`
                        Emit(iLEmitter, OpCodes.Ldobj, type);
                    }
                    else
                    {
                        Emit(iLEmitter, type.GetCecilLoadOpCode());
                    }
                }

                if (type.IsValueType)
                {
                    /// Box the value to its boxed form of type `type`
                    Emit(iLEmitter, OpCodes.Box, type);
                }

                /// Replace array element at index with the ref value on the stack.
                Emit(iLEmitter, OpCodes.Stelem_Ref);

                /*
                 * Array.CreateInstance(typeof(object), parameters.Length);
                 */
            }
        }

        /// <summary>
        /// Initialize the default values for `out` parameters
        /// </summary>
        private static void EmitOutParameter(object iLEmitter, int arg, Type t)
        {
            t = t.OpenRefType(); // actual element typ
            /// Load argument numbered `arg` onto the stack
            Emit(iLEmitter, OpCodes.Ldarg, arg);

            if (AccessTools.IsStruct(t))
            {
                /// Initialize the type `t` at address destination
                /// which is argument numbered `arg` on the stack
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

                Emit(iLEmitter, opcode, (int)num);
                Emit(iLEmitter, opcode2);
            }
            else
            {
                /// Push a null reference on the stack.
                /// Store value of type object `ref (type O)` into memory at address.
                Emit(iLEmitter, OpCodes.Ldnull);
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
        public static Exception EmitCallParameterFinalizer(Exception __exception, object il, MethodBase original, MethodInfo patch, Dictionary<string, VariableDefinition> variables, bool allowFirsParamPassthrough)
        {
            if (__exception.Message != $"Parameter __args does not contain a valid index")
                //return __exception;
                return null;

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
