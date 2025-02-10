// Decompiled with JetBrains decompiler
// Type: TinyJson.JSONParser
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
  public static class JSONParser
  {
    [ThreadStatic]
    private static Stack<List<string>> splitArrayPool;
    [ThreadStatic]
    private static StringBuilder stringBuilder;
    [ThreadStatic]
    private static Dictionary<Type, Dictionary<string, FieldInfo>> fieldInfoCache;
    [ThreadStatic]
    private static Dictionary<Type, Dictionary<string, PropertyInfo>> propertyInfoCache;

    public static T FromJson<T>(this string json)
    {
      if (JSONParser.propertyInfoCache == null)
        JSONParser.propertyInfoCache = new Dictionary<Type, Dictionary<string, PropertyInfo>>();
      if (JSONParser.fieldInfoCache == null)
        JSONParser.fieldInfoCache = new Dictionary<Type, Dictionary<string, FieldInfo>>();
      if (JSONParser.stringBuilder == null)
        JSONParser.stringBuilder = new StringBuilder();
      if (JSONParser.splitArrayPool == null)
        JSONParser.splitArrayPool = new Stack<List<string>>();
      JSONParser.stringBuilder.Length = 0;
      for (int index = 0; index < json.Length; ++index)
      {
        char c = json[index];
        if (c == '"')
          index = JSONParser.AppendUntilStringEnd(true, index, json);
        else if (!char.IsWhiteSpace(c))
          JSONParser.stringBuilder.Append(c);
      }
      return (T) JSONParser.ParseValue(typeof (T), JSONParser.stringBuilder.ToString());
    }

    private static int AppendUntilStringEnd(bool appendEscapeCharacter, int startIdx, string json)
    {
      JSONParser.stringBuilder.Append(json[startIdx]);
      for (int index = startIdx + 1; index < json.Length; ++index)
      {
        if (json[index] == '\\')
        {
          if (appendEscapeCharacter)
            JSONParser.stringBuilder.Append(json[index]);
          JSONParser.stringBuilder.Append(json[index + 1]);
          ++index;
        }
        else
        {
          if (json[index] == '"')
          {
            JSONParser.stringBuilder.Append(json[index]);
            return index;
          }
          JSONParser.stringBuilder.Append(json[index]);
        }
      }
      return json.Length - 1;
    }

    private static List<string> Split(string json)
    {
      List<string> stringList = JSONParser.splitArrayPool.Count > 0 ? JSONParser.splitArrayPool.Pop() : new List<string>();
      stringList.Clear();
      if (json.Length == 2)
        return stringList;
      int num = 0;
      JSONParser.stringBuilder.Length = 0;
      for (int index = 1; index < json.Length - 1; ++index)
      {
        switch (json[index])
        {
          case '"':
            index = JSONParser.AppendUntilStringEnd(true, index, json);
            break;
          case ',':
          case ':':
            if (num == 0)
            {
              stringList.Add(JSONParser.stringBuilder.ToString());
              JSONParser.stringBuilder.Length = 0;
              break;
            }
            goto default;
          case '[':
          case '{':
            ++num;
            goto default;
          case ']':
          case '}':
            --num;
            goto default;
          default:
            JSONParser.stringBuilder.Append(json[index]);
            break;
        }
      }
      stringList.Add(JSONParser.stringBuilder.ToString());
      return stringList;
    }

    internal static object ParseValue(Type type, string json)
    {
      if (type == typeof (string))
      {
        if (json.Length <= 2)
          return (object) string.Empty;
        StringBuilder stringBuilder = new StringBuilder(json.Length);
        for (int index1 = 1; index1 < json.Length - 1; ++index1)
        {
          if (json[index1] == '\\' && index1 + 1 < json.Length - 1)
          {
            int index2 = "\"\\nrtbf/".IndexOf(json[index1 + 1]);
            if (index2 >= 0)
            {
              stringBuilder.Append("\"\\\n\r\t\b\f/"[index2]);
              ++index1;
              continue;
            }
            if (json[index1 + 1] == 'u' && index1 + 5 < json.Length - 1)
            {
              uint result = 0;
              if (uint.TryParse(json.Substring(index1 + 2, 4), NumberStyles.AllowHexSpecifier, (IFormatProvider) null, out result))
              {
                stringBuilder.Append((char) result);
                index1 += 5;
                continue;
              }
            }
          }
          stringBuilder.Append(json[index1]);
        }
        return (object) stringBuilder.ToString();
      }
      if (type.IsPrimitive)
        return Convert.ChangeType((object) json, type, (IFormatProvider) CultureInfo.InvariantCulture);
      if (type == typeof (Decimal))
      {
        Decimal result;
        Decimal.TryParse(json, NumberStyles.Float, (IFormatProvider) CultureInfo.InvariantCulture, out result);
        return (object) result;
      }
      if (type == typeof (DateTime))
      {
        DateTime result;
        DateTime.TryParse(json.Replace("\"", ""), (IFormatProvider) CultureInfo.InvariantCulture, DateTimeStyles.None, out result);
        return (object) result;
      }
      if (json == "null")
        return (object) null;
      if (type.IsEnum)
      {
        if (json[0] == '"')
          json = json.Substring(1, json.Length - 2);
        try
        {
          return Enum.Parse(type, json, false);
        }
        catch
        {
          return (object) 0;
        }
      }
      else
      {
        if (type.IsArray)
        {
          Type elementType = type.GetElementType();
          if (json[0] != '[' || json[json.Length - 1] != ']')
            return (object) null;
          List<string> stringList = JSONParser.Split(json);
          Array instance = Array.CreateInstance(elementType, stringList.Count);
          for (int index = 0; index < stringList.Count; ++index)
            instance.SetValue(JSONParser.ParseValue(elementType, stringList[index]), index);
          JSONParser.splitArrayPool.Push(stringList);
          return (object) instance;
        }
        if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof (List<>))
        {
          Type genericArgument = type.GetGenericArguments()[0];
          if (json[0] != '[' || json[json.Length - 1] != ']')
            return (object) null;
          List<string> stringList = JSONParser.Split(json);
          IList list = (IList) type.GetConstructor(new Type[1]
          {
            typeof (int)
          }).Invoke(new object[1]
          {
            (object) stringList.Count
          });
          for (int index = 0; index < stringList.Count; ++index)
            list.Add(JSONParser.ParseValue(genericArgument, stringList[index]));
          JSONParser.splitArrayPool.Push(stringList);
          return (object) list;
        }
        if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof (Dictionary<,>))
        {
          Type[] genericArguments = type.GetGenericArguments();
          Type type1 = genericArguments[0];
          Type type2 = genericArguments[1];
          if (type1 != typeof (string) || json[0] != '{' || json[json.Length - 1] != '}')
            return (object) null;
          List<string> stringList = JSONParser.Split(json);
          if (stringList.Count % 2 != 0)
            return (object) null;
          IDictionary dictionary = (IDictionary) type.GetConstructor(new Type[1]
          {
            typeof (int)
          }).Invoke(new object[1]
          {
            (object) (stringList.Count / 2)
          });
          for (int index = 0; index < stringList.Count; index += 2)
          {
            if (stringList[index].Length > 2)
            {
              string key = stringList[index].Substring(1, stringList[index].Length - 2);
              object obj = JSONParser.ParseValue(type2, stringList[index + 1]);
              dictionary[(object) key] = obj;
            }
          }
          return (object) dictionary;
        }
        if (type == typeof (object))
          return JSONParser.ParseAnonymousValue(json);
        return json[0] == '{' && json[json.Length - 1] == '}' ? JSONParser.ParseObject(type, json) : (object) null;
      }
    }

    private static object ParseAnonymousValue(string json)
    {
      if (json.Length == 0)
        return (object) null;
      if (json[0] == '{' && json[json.Length - 1] == '}')
      {
        List<string> stringList = JSONParser.Split(json);
        if (stringList.Count % 2 != 0)
          return (object) null;
        Dictionary<string, object> anonymousValue = new Dictionary<string, object>(stringList.Count / 2);
        for (int index = 0; index < stringList.Count; index += 2)
          anonymousValue[stringList[index].Substring(1, stringList[index].Length - 2)] = JSONParser.ParseAnonymousValue(stringList[index + 1]);
        return (object) anonymousValue;
      }
      if (json[0] == '[' && json[json.Length - 1] == ']')
      {
        List<string> stringList = JSONParser.Split(json);
        List<object> anonymousValue = new List<object>(stringList.Count);
        for (int index = 0; index < stringList.Count; ++index)
          anonymousValue.Add(JSONParser.ParseAnonymousValue(stringList[index]));
        return (object) anonymousValue;
      }
      if (json[0] == '"' && json[json.Length - 1] == '"')
        return (object) json.Substring(1, json.Length - 2).Replace("\\", string.Empty);
      if (char.IsDigit(json[0]) || json[0] == '-')
      {
        if (json.Contains("."))
        {
          double result;
          double.TryParse(json, NumberStyles.Float, (IFormatProvider) CultureInfo.InvariantCulture, out result);
          return (object) result;
        }
        int result1;
        int.TryParse(json, out result1);
        return (object) result1;
      }
      switch (json)
      {
        case "true":
          return (object) true;
        case "false":
          return (object) false;
        default:
          return (object) null;
      }
    }

    private static Dictionary<string, T> CreateMemberNameDictionary<T>(T[] members) where T : MemberInfo
    {
      Dictionary<string, T> memberNameDictionary = new Dictionary<string, T>((IEqualityComparer<string>) StringComparer.OrdinalIgnoreCase);
      for (int index = 0; index < members.Length; ++index)
      {
        T member = members[index];
        if (!member.IsDefined(typeof (IgnoreDataMemberAttribute), true))
        {
          string name = member.Name;
          if (member.IsDefined(typeof (DataMemberAttribute), true))
          {
            DataMemberAttribute customAttribute = (DataMemberAttribute) Attribute.GetCustomAttribute((MemberInfo) member, typeof (DataMemberAttribute), true);
            if (!string.IsNullOrEmpty(customAttribute.Name))
              name = customAttribute.Name;
          }
          memberNameDictionary.Add(name, member);
        }
      }
      return memberNameDictionary;
    }

    private static object ParseObject(Type type, string json)
    {
      object uninitializedObject = FormatterServices.GetUninitializedObject(type);
      List<string> stringList = JSONParser.Split(json);
      if (stringList.Count % 2 != 0)
        return uninitializedObject;
      Dictionary<string, FieldInfo> memberNameDictionary1;
      if (!JSONParser.fieldInfoCache.TryGetValue(type, out memberNameDictionary1))
      {
        memberNameDictionary1 = JSONParser.CreateMemberNameDictionary<FieldInfo>(type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.FlattenHierarchy));
        JSONParser.fieldInfoCache.Add(type, memberNameDictionary1);
      }
      Dictionary<string, PropertyInfo> memberNameDictionary2;
      if (!JSONParser.propertyInfoCache.TryGetValue(type, out memberNameDictionary2))
      {
        memberNameDictionary2 = JSONParser.CreateMemberNameDictionary<PropertyInfo>(type.GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.FlattenHierarchy));
        JSONParser.propertyInfoCache.Add(type, memberNameDictionary2);
      }
      for (int index = 0; index < stringList.Count; index += 2)
      {
        if (stringList[index].Length > 2)
        {
          string key = stringList[index].Substring(1, stringList[index].Length - 2);
          string json1 = stringList[index + 1];
          FieldInfo fieldInfo;
          if (memberNameDictionary1.TryGetValue(key, out fieldInfo))
          {
            fieldInfo.SetValue(uninitializedObject, JSONParser.ParseValue(fieldInfo.FieldType, json1));
          }
          else
          {
            PropertyInfo propertyInfo;
            if (memberNameDictionary2.TryGetValue(key, out propertyInfo))
              propertyInfo.SetValue(uninitializedObject, JSONParser.ParseValue(propertyInfo.PropertyType, json1), (object[]) null);
          }
        }
      }
      return uninitializedObject;
    }
  }
}
