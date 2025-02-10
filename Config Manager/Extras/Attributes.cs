using HarmonyLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace WildfrostHopeMod
{
    public class HideInConfigManagerAttribute : Attribute { }

    [AttributeUsage(AttributeTargets.Field, AllowMultiple = true)]
    public abstract class ConditionalConfigAttribute : Attribute
    {
        public readonly string listeningTo;
        public readonly object[] acceptedValues;
        public readonly float? floatMin;
        public readonly float? floatMax;
        public (float min, float max) range { get; private set; }
        public int priority = 0;

        public ConditionalConfigAttribute(string listeningTo, params object[] acceptedValues)
        {
            this.listeningTo = listeningTo;
            this.acceptedValues = acceptedValues;
        }
        public ConditionalConfigAttribute(string listeningTo, float min, float max)
        {
            this.listeningTo = listeningTo;
            range = (min, max);
            floatMin = range.min;
            floatMax = range.max;
        }
        public bool IsSatisfied(object value) => 
            (value is float f) ? new Vector2(range.min, range.max).InRange(f) : acceptedValues.Contains(value);
        internal bool IsSatisfied() => true;
    }

    public class HideIfConfigAttribute : ConditionalConfigAttribute
    {
        /// <param name="listeningTo">The field name of the dependent ConfigItem, where "public bool meow;" has field name "meow"</param>
        public HideIfConfigAttribute(string listeningTo, params object[] acceptedValues) : base(listeningTo, acceptedValues) { }

        /// <param name="listeningTo">The field name of the dependent ConfigItem, where "public bool meow;" has field name "meow"</param>
        public HideIfConfigAttribute(string listeningTo, float min, float max) : base(listeningTo, min, max) { }
    }

    public class ShowIfConfigAttribute : ConditionalConfigAttribute
    {
        /// <param name="listeningTo">The field name of the dependent ConfigItem, where "public bool meow;" has field name "meow"</param>
        public ShowIfConfigAttribute(string listeningTo, params object[] acceptedValues) : base(listeningTo, acceptedValues) { }

        /// <param name="listeningTo">The field name of the dependent ConfigItem, where "public bool meow;" has field name "meow"</param>
        public ShowIfConfigAttribute(string listeningTo, float min, float max) : base(listeningTo, min, max) { }
    }



    public class ConfigInputAttribute : Attribute { }


    /// <summary>
    /// Title to use for this config item in the journal
    /// </summary>
    public class ConfigManagerTitleAttribute : Attribute
    {
        public readonly string title;
        /// <summary>
        /// Title to use for this config item in the journal
        /// </summary>
        public ConfigManagerTitleAttribute(string title) => this.title = title;
    }
    /// <summary>
    /// Description to use for this config item in the journal. Shows as a popup
    /// </summary>
    public class ConfigManagerDescAttribute : Attribute
    {
        public readonly string desc;
        public readonly bool overridePreprocessing = false;

        /// <summary>
        /// Description to use for this config item in the journal. Shows as a popup
        /// </summary>
        public ConfigManagerDescAttribute(string desc)
        {
            this.desc = desc;
        }

        /// <summary>
        /// Description to use for this config item in the journal. Shows as a popup
        /// </summary>
        /// <param name="overridePreprocessing">If false, the game tries to highlight anything in "<...>", disabling other rich text tags</param>
        public ConfigManagerDescAttribute(string desc, bool overridePreprocessing = false)
        {
            this.desc = desc;
            this.overridePreprocessing = overridePreprocessing;
        }
    }
    /// <summary>
    /// Leave blank for the range (0,1)
    /// </summary>
    public class ConfigSliderAttribute : Attribute
    {
        public readonly Vector2 range = new Vector2(0, 1);
        public readonly float stepSize = 0;

        /// <summary>
        /// Use range (0, 1)
        /// </summary>
        public ConfigSliderAttribute() { }
        /// <summary>
        /// Use range (min, max)
        /// </summary>
        public ConfigSliderAttribute(float min, float max) => this.range = new Vector2(min, max);/*
        public ConfigSliderAttribute(float min, float max, float stepSize)
        {
            this.stepSize = stepSize;
            this.range = new Vector2(min, max);
        }
        public ConfigSliderAttribute(int min, int max) => new ConfigSliderAttribute((float)min, (float)max, 1);
        public ConfigSliderAttribute(int min, int max, int stepSize) => new ConfigSliderAttribute((float)min, (float)max, (float)stepSize);*/
    }



    public class ConfigOptionsAttribute : Attribute
    {
        public readonly Dictionary<string, object> lookup = new();
        public readonly object[] values = new object[0];
        public readonly Type type;

        /// <summary>
        /// Leave blank to use "Off" and "On" and correspoding bool values
        /// </summary>
        public ConfigOptionsAttribute() : this(new string[] { "Off", "On" }, false, true) { }
        /// <summary>
        /// Use the names and values of an enum for the options
        /// </summary>
        /// <param name="enumType"></param>
        public ConfigOptionsAttribute(Type enumType)
        {
            type = enumType;
            if (type.IsEnum)
                foreach (var val in values = enumType.GetEnumValues().Cast<object>().ToArray())
                    lookup[enumType.GetEnumName(val).Replace("_", " ")] = val;
        }
        public ConfigOptionsAttribute(params object[] values)
        {
            foreach (var value in values)
            {
                if (value is Array list)
                    foreach (var item in list)
                        this.values = this.values.With(item);
                else this.values = this.values.With(value);
            }
            type = this.values.FirstOrDefault().GetType();
            for (int i = 0; i < this.values.Length; i++)
            {
                if (this.values[i].GetType() != type)
                {
                    Debug.LogError($"[Config Manager] The type of [{this.values[i]}] isn't consistent with [{type.Name}]!");
                    continue;
                }

                lookup[this.values[i].ToString()] = this.values[i];
            }
        }
        public ConfigOptionsAttribute(string[] labels, params object[] values)
        {
            if (!values.Any())
            {
                this.values = labels;
                foreach (var label in labels) lookup[label] = label;
            }
            foreach (var value in values)
            {
                if (value is Array list)
                    foreach (var item in list)
                        this.values = this.values.With(item);
                else this.values = this.values.With(value);
            }
            type = this.values.FirstOrDefault().GetType();
            for (int i = 0; i < this.values.Length; i++)
            {
                if (this.values[i].GetType() != type)
                {
                    Debug.LogError($"[Config Manager] The type of [{this.values[i]}] isn't consistent with [{type.Name}]!");
                    continue;
                }
                if (i < labels.Length) lookup[labels[i]] = this.values[i];
                else lookup[this.values[i].ToString()] = this.values[i];
            }
        }
    }
}