// Decompiled with JetBrains decompiler
// Type: TinyJson.JSONWriter
// Assembly: WildfrostModMiya, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 51F56119-3F77-414A-8824-BFF112DF055A
// Assembly location: C:\Users\harri\Downloads\Wildfrost v1.0.4\BepInEx\plugins\WildfrostModMiya.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;

namespace TinyJson
{
  public static class JSONWriter
  {
    public static string ToJson(this object item)
    {
      StringBuilder stringBuilder = new StringBuilder();
      JSONWriter.AppendValue(stringBuilder, item);
      return stringBuilder.ToString();
    }

    private static void AppendValue(StringBuilder stringBuilder, object item)
    {
      if (item == null)
      {
        stringBuilder.Append("null");
      }
      else
      {
        Type type = item.GetType();
        if (type == typeof (string) || type == typeof (char))
        {
          stringBuilder.Append('"');
          string str = item.ToString();
          for (int index1 = 0; index1 < str.Length; ++index1)
          {
            if (str[index1] < ' ' || str[index1] == '"' || str[index1] == '\\')
            {
              stringBuilder.Append('\\');
              int index2 = "\"\\\n\r\t\b\f".IndexOf(str[index1]);
              if (index2 >= 0)
                stringBuilder.Append("\"\\nrtbf"[index2]);
              else
                stringBuilder.AppendFormat("u{0:X4}", (object) (uint) str[index1]);
            }
            else
              stringBuilder.Append(str[index1]);
          }
          stringBuilder.Append('"');
        }
        else if (type == typeof (byte) || type == typeof (sbyte))
          stringBuilder.Append(item.ToString());
        else if (type == typeof (short) || type == typeof (ushort))
          stringBuilder.Append(item.ToString());
        else if (type == typeof (int) || type == typeof (uint))
          stringBuilder.Append(item.ToString());
        else if (type == typeof (long) || type == typeof (ulong))
          stringBuilder.Append(item.ToString());
        else if (type == typeof (float))
          stringBuilder.Append(((float) item).ToString((IFormatProvider) CultureInfo.InvariantCulture));
        else if (type == typeof (double))
          stringBuilder.Append(((double) item).ToString((IFormatProvider) CultureInfo.InvariantCulture));
        else if (type == typeof (Decimal))
          stringBuilder.Append(((Decimal) item).ToString((IFormatProvider) CultureInfo.InvariantCulture));
        else if (type == typeof (bool))
          stringBuilder.Append((bool) item ? "true" : "false");
        else if (type == typeof (DateTime))
        {
          stringBuilder.Append('"');
          stringBuilder.Append(((DateTime) item).ToString((IFormatProvider) CultureInfo.InvariantCulture));
          stringBuilder.Append('"');
        }
        else if (type.IsEnum)
        {
          stringBuilder.Append('"');
          stringBuilder.Append(item.ToString());
          stringBuilder.Append('"');
        }
        else if (item is IList)
        {
          stringBuilder.Append('[');
          bool flag = true;
          IList list = item as IList;
          for (int index = 0; index < list.Count; ++index)
          {
            if (flag)
              flag = false;
            else
              stringBuilder.Append(',');
            JSONWriter.AppendValue(stringBuilder, list[index]);
          }
          stringBuilder.Append(']');
        }
        else if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof (Dictionary<,>))
        {
          if (type.GetGenericArguments()[0] != typeof (string))
          {
            stringBuilder.Append("{}");
          }
          else
          {
            stringBuilder.Append('{');
            IDictionary dictionary = item as IDictionary;
            bool flag = true;
            foreach (object key in (IEnumerable) dictionary.Keys)
            {
              if (flag)
                flag = false;
              else
                stringBuilder.Append(',');
              stringBuilder.Append('"');
              stringBuilder.Append((string) key);
              stringBuilder.Append("\":");
              JSONWriter.AppendValue(stringBuilder, dictionary[key]);
            }
            stringBuilder.Append('}');
          }
        }
        else
        {
          stringBuilder.Append('{');
          bool flag = true;
          FieldInfo[] fields = type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.FlattenHierarchy);
          for (int index = 0; index < fields.Length; ++index)
          {
            if (!fields[index].IsDefined(typeof (IgnoreDataMemberAttribute), true))
            {
              object obj = fields[index].GetValue(item);
              if (obj != null)
              {
                if (flag)
                  flag = false;
                else
                  stringBuilder.Append(',');
                stringBuilder.Append('"');
                stringBuilder.Append(JSONWriter.GetMemberName((MemberInfo) fields[index]));
                stringBuilder.Append("\":");
                JSONWriter.AppendValue(stringBuilder, obj);
              }
            }
          }
          PropertyInfo[] properties = type.GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.FlattenHierarchy);
          for (int index = 0; index < properties.Length; ++index)
          {
            if (properties[index].CanRead && !properties[index].IsDefined(typeof (IgnoreDataMemberAttribute), true))
            {
              object obj = properties[index].GetValue(item, (object[]) null);
              if (obj != null)
              {
                if (flag)
                  flag = false;
                else
                  stringBuilder.Append(',');
                stringBuilder.Append('"');
                stringBuilder.Append(JSONWriter.GetMemberName((MemberInfo) properties[index]));
                stringBuilder.Append("\":");
                JSONWriter.AppendValue(stringBuilder, obj);
              }
            }
          }
          stringBuilder.Append('}');
        }
      }
    }

    private static string GetMemberName(MemberInfo member)
    {
      if (member.IsDefined(typeof (DataMemberAttribute), true))
      {
        DataMemberAttribute customAttribute = (DataMemberAttribute) Attribute.GetCustomAttribute(member, typeof (DataMemberAttribute), true);
        if (!string.IsNullOrEmpty(customAttribute.Name))
          return customAttribute.Name;
      }
      return member.Name;
    }
  }
}
