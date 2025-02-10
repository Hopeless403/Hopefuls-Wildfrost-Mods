using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using static Entity;
using static UnityEngine.ParticleSystem;

namespace WildfrostHopeMod.CommandsConsole
{
    public static class ConsoleExtensions
    {
        public static FieldInfo[] GetAllFields<T>(this T t, Type type = null)
            => (type ?? t.GetType()).GetFields((BindingFlags)0x1FFFFFD);//.Concat(typeof(T).GetFields((BindingFlags)0x1FFFFFF)).ToArray();

        public static T PrintAllProperties<T>(this T t, Type type = null)
        {
            foreach (var property in (type ?? t.GetType()).GetProperties((BindingFlags)0x1FFFFFD))
            {
                try { Debug.Log($"{property.Name}: {property.GetValue(t)}"); }
                catch { Debug.Log($"{property.Name} failed"); }
            }
            return t;
        }
        public static T PrintAllFields<T>(this T t, Type type = null)
        {
            foreach (var field in t.GetAllFields(type))
            {
                try { Debug.Log($"{field.Name}: {field.GetValue(t) ?? "null"}"); }
                catch { Debug.Log($"{field.Name} failed"); }
            }
            return t;
        }
    }
}
