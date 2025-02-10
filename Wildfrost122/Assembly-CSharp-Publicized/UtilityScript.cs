// Decompiled with JetBrains decompiler
// Type: UtilityScript
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using TMPro;
using UnityEngine;
using UnityEngine.AI;

#nullable disable
public static class UtilityScript
{
  public static string GetLogMessage(string source, string message)
  {
    return "[" + source + "] " + message;
  }

  public static MethodInfo GetMethodInfo<T>(Expression<Action<T>> expression)
  {
    if (expression.Body is MethodCallExpression body)
      return body.Method;
    throw new ArgumentException("Expression is not a method", nameof (expression));
  }

  public static Vector3 GenerateSineWave(
    Vector3 axis,
    Vector3 currentPosition,
    float frequency,
    float magnitude,
    float timeStep)
  {
    return currentPosition + axis * Mathf.Sin(timeStep * frequency) * magnitude;
  }

  public static float PlanarDistance(this Vector3 a, Vector3 b, Axis negatedAxis)
  {
    if (negatedAxis == Axis.All)
      return new Vector3(0.0f, 0.0f, a.z).Distance(new Vector3(0.0f, 0.0f, b.z));
    if (negatedAxis == Axis.All)
      return new Vector3(0.0f, a.y, 0.0f).Distance(new Vector3(0.0f, b.y, 0.0f));
    if (negatedAxis == Axis.All)
      return new Vector3(a.x, 0.0f, 0.0f).Distance(new Vector3(b.x, 0.0f, 0.0f));
    switch (negatedAxis)
    {
      case Axis.All:
        return Vector3.zero.Distance(Vector3.zero);
      case (Axis) 1:
      case (Axis) 3:
        return float.PositiveInfinity;
      case Axis.X:
        return new Vector3(0.0f, a.y, a.z).Distance(new Vector3(0.0f, b.y, b.z));
      case Axis.Y:
        return new Vector3(a.x, 0.0f, a.z).Distance(new Vector3(b.x, 0.0f, b.z));
      default:
        if (negatedAxis == Axis.Z)
          return new Vector3(a.x, a.y, 0.0f).Distance(new Vector3(b.x, b.y, 0.0f));
        goto case (Axis) 1;
    }
  }

  public static Vector2 GetAverage(List<Vector2> positions)
  {
    Vector2 zero = Vector2.zero;
    for (int index = 0; index < positions.Count; ++index)
      zero += positions[index];
    return zero / (float) positions.Count;
  }

  public static Vector3 RandomInRange(this Vector3 inVector)
  {
    return new Vector3(UnityEngine.Random.Range((float) (-(double) inVector.x / 2.0), inVector.x / 2f), UnityEngine.Random.Range((float) (-(double) inVector.y / 2.0), inVector.y / 2f), UnityEngine.Random.Range((float) (-(double) inVector.z / 2.0), inVector.z / 2f));
  }

  public static Vector3 PlanarDistanceVec3(this Vector3 a, Vector3 b, Axis negatedAxis)
  {
    if (negatedAxis == Axis.All)
      return new Vector3(0.0f, 0.0f, a.z) - new Vector3(0.0f, 0.0f, b.z);
    if (negatedAxis == Axis.All)
      return new Vector3(0.0f, a.y, 0.0f) - new Vector3(0.0f, b.y, 0.0f);
    if (negatedAxis == Axis.All)
      return new Vector3(a.x, 0.0f, 0.0f) - new Vector3(b.x, 0.0f, 0.0f);
    switch (negatedAxis)
    {
      case Axis.All:
        return Vector3.zero - Vector3.zero;
      case (Axis) 1:
      case (Axis) 3:
        return Vector3.positiveInfinity;
      case Axis.X:
        return new Vector3(0.0f, a.y, a.z) - new Vector3(0.0f, b.y, b.z);
      case Axis.Y:
        return new Vector3(a.x, 0.0f, a.z) - new Vector3(b.x, 0.0f, b.z);
      default:
        if (negatedAxis == Axis.Z)
          return new Vector3(a.x, a.y, 0.0f) - new Vector3(b.x, b.y, 0.0f);
        goto case (Axis) 1;
    }
  }

  public static Vector3 GetPlanar(this Vector3 a, Axis negatedAxis)
  {
    switch (negatedAxis)
    {
      case Axis.X:
        return new Vector3(0.0f, a.y, a.z);
      case Axis.Y:
        return new Vector3(a.x, 0.0f, a.z);
      case Axis.Z:
        return new Vector3(a.x, a.y, 0.0f);
      default:
        return new Vector3(float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity);
    }
  }

  public static float RoundAwayFromZero(this float f)
  {
    return (double) f < 0.0 ? Mathf.Floor(f) : Mathf.Ceil(f);
  }

  public static float AddToAverage(float average, int size, float value)
  {
    return ((float) size * average + value) / (float) (size + 1);
  }

  public static float SubtractFromAverage(float average, int size, float value)
  {
    return ((float) size * average - value) / (float) (size - 1);
  }

  public static float ReplaceInAverage(float average, int size, float oldValue, float newValue)
  {
    return ((float) size * average - oldValue + newValue) / (float) size;
  }

  public static float AddAveragesTogether(float averageA, int sizeA, float averageB, int sizeB)
  {
    return (float) ((double) sizeA * (double) averageA + (double) sizeB * (double) averageB) / (float) (sizeA + sizeB);
  }

  public static float GetNormalDistance(
    this Vector3 position,
    Vector3 startPosition,
    Vector3 destination)
  {
    float sqrMagnitude = startPosition.PlanarDistanceVec3(destination, Axis.Y).sqrMagnitude;
    return position.PlanarDistanceVec3(destination, Axis.Y).sqrMagnitude.RemapProportion(0.0f, sqrMagnitude, 0.0f, 1f);
  }

  public static string GetPathBasedOnOS()
  {
    if (Application.isEditor)
      return Application.persistentDataPath + "/";
    if (Application.platform == RuntimePlatform.WebGLPlayer)
      return Path.GetDirectoryName(Application.absoluteURL).Replace("\\", "/") + "/";
    return Application.isMobilePlatform || Application.isConsolePlatform ? Application.persistentDataPath : Application.persistentDataPath + "/";
  }

  public static string GetIdentifier(string userIdentifier, string uniqueObjectIdentifier)
  {
    return userIdentifier + "-" + uniqueObjectIdentifier;
  }

  public static Vector3 Lerp(this Vector3 a, Vector3 b, float time) => Vector3.Lerp(a, b, time);

  public static bool IsEmpty(this string input)
  {
    return string.IsNullOrEmpty(input) && string.IsNullOrWhiteSpace(input);
  }

  public static double ToEpoch(this DateTime dt)
  {
    return dt.Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
  }

  public static DateTime FromEpoch(this double epoch)
  {
    return new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddSeconds(epoch);
  }

  public static double ToEpochMs(this DateTime dt)
  {
    return dt.Subtract(new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds;
  }

  public static DateTime FromEpochMs(this double epoch)
  {
    return new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddMilliseconds(epoch);
  }

  public static float SecondsToMs(this float seconds) => seconds * 1000f;

  public static Texture2D AddWatermark(
    Texture2D textureToSave,
    Texture2D watermark,
    int startPositionX,
    int startPositionY,
    bool hideFadedPixels = false)
  {
    Texture2D texture2D = textureToSave.ToTexture2D();
    for (int x = startPositionX; x < texture2D.width; ++x)
    {
      for (int y = startPositionY; y < texture2D.height; ++y)
      {
        if (x - startPositionX < watermark.width && y - startPositionY < watermark.height)
        {
          Color pixel1 = texture2D.GetPixel(x, y);
          Color pixel2 = watermark.GetPixel(x - startPositionX, y - startPositionY);
          Color b = pixel2;
          double t = (double) pixel2.a / 1.0;
          Color color1 = Color.Lerp(pixel1, b, (float) t);
          Color color2 = new Color(color1.r, color1.g, color1.b, 1f);
          texture2D.SetPixel(x, y, color2);
        }
      }
    }
    texture2D.Apply();
    return texture2D;
  }

  public static float AngleDir(Vector3 fwd, Vector3 targetDir, Vector3 up)
  {
    float num = Vector3.Dot(Vector3.Cross(fwd, targetDir), up);
    if ((double) num > 0.0)
      return 1f;
    return (double) num < 0.0 ? -1f : 0.0f;
  }

  public static IEnumerable<string> ToCsv<T>(
    IEnumerable<T> objectlist,
    string separator = ",",
    bool header = true)
  {
    FieldInfo[] fields = typeof (T).GetFields();
    PropertyInfo[] properties = typeof (T).GetProperties();
    if (header)
      yield return string.Join(separator, ((IEnumerable<FieldInfo>) fields).Select<FieldInfo, string>((Func<FieldInfo, string>) (f => f.Name)).Concat<string>(((IEnumerable<PropertyInfo>) properties).Select<PropertyInfo, string>((Func<PropertyInfo, string>) (p => p.Name))).ToArray<string>());
    foreach (T obj in objectlist)
    {
      T o = obj;
      yield return string.Join(separator, ((IEnumerable<FieldInfo>) fields).Select<FieldInfo, string>((Func<FieldInfo, string>) (f => (f.GetValue((object) o) ?? (object) "").ToString())).Concat<string>(((IEnumerable<PropertyInfo>) properties).Select<PropertyInfo, string>((Func<PropertyInfo, string>) (p => (p.GetValue((object) o, (object[]) null) ?? (object) "").ToString()))).ToArray<string>());
    }
  }

  public static float SubtractValueFromMean(float inVal, float currentMean, float numOfValues)
  {
    return (float) (((double) currentMean * (double) numOfValues - (double) inVal) / ((double) numOfValues - 1.0));
  }

  public static float AddValueToMean(float inVal, float currentMean, float numOfValues)
  {
    return currentMean + (inVal - currentMean) / numOfValues;
  }

  public static Color RandomColour() => new Color(UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value);

  public static int RandomIndex<T>(this IEnumerable<T> list) => UnityEngine.Random.Range(0, list.Count<T>());

  public static T Next<T>(this IEnumerable<T> list, T anchor)
  {
    int num = list.ToList<T>().IndexOf(anchor);
    if (num >= list.Count<T>())
      return list.ElementAtOrDefault<T>(0);
    return num <= -1 ? list.ElementAtOrDefault<T>(list.Count<T>() - 1) : list.ElementAtOrDefault<T>(num + 1);
  }

  public static bool CompareArrays(int[,] arrayA, int[,] arrayB)
  {
    try
    {
      return arrayA.Rank == arrayB.Rank && Enumerable.Range(0, arrayA.Rank).All<int>((Func<int, bool>) (dimension => arrayA.GetLength(dimension) == arrayB.GetLength(dimension))) && ((IEnumerable) arrayA).Cast<int>().SequenceEqual<int>(((IEnumerable) arrayB).Cast<int>());
    }
    catch
    {
      return false;
    }
  }

  public static float RemapProportion(
    this float value,
    float currentMin,
    float currentMax,
    float newMin,
    float newMax)
  {
    return (float) (((double) value - (double) currentMin) / ((double) currentMax - (double) currentMin) * ((double) newMax - (double) newMin)) + newMin;
  }

  public static float Distance(this Vector3 thisVec, Vector3 compareVec)
  {
    return Vector3.Distance(thisVec, compareVec);
  }

  public static Vector3 Difference(this Vector3 a, Vector3 b) => a - b;

  public static bool InRange(this Vector2 inRange, float inNum, bool isInclusive = true)
  {
    return isInclusive ? (double) inNum >= (double) inRange.x && (double) inNum <= (double) inRange.y : (double) inNum > (double) inRange.x && (double) inNum < (double) inRange.y;
  }

  public static T RandomEnumValue<T>(Likelihood likelihood)
  {
    Array values = Enum.GetValues(typeof (T));
    float[] source = new float[values.Length];
    source[0] = 100f;
    for (int y = 1; y < values.Length; ++y)
      source[y] = 100f / (float) Math.Pow(2.0, (double) y);
    if ((double) source[values.Length - 1] > 1.0)
      source[values.Length - 1] = 1f;
    float[] array = ((IEnumerable<float>) source).Reverse<float>().ToArray<float>();
    int index1 = 0;
    switch (likelihood)
    {
      case Likelihood.MostToLeast:
        int num1 = UnityEngine.Random.Range(0, 100);
        for (int index2 = 0; index2 < array.Length; ++index2)
        {
          if ((double) num1 < (double) array[index2])
          {
            index1 = array.Length - 1 - index2;
            break;
          }
        }
        break;
      case Likelihood.LeastToMost:
        int num2 = UnityEngine.Random.Range(0, 100);
        for (int index3 = 0; index3 < array.Length; ++index3)
        {
          if ((double) num2 < (double) array[index3])
          {
            index1 = index3;
            break;
          }
        }
        break;
      case Likelihood.Balanced:
        index1 = UnityEngine.Random.Range(0, values.Length);
        break;
    }
    return (T) values.GetValue(index1);
  }

  public static float GetPercentageBetweenValues(float inVal, float minVal, float maxVal)
  {
    return Mathf.Clamp01((float) (((double) inVal - (double) minVal) / ((double) maxVal - (double) minVal)));
  }

  public static float GetPercentageBetweenValues(this Vector2 inVec, float inVal)
  {
    return Mathf.Clamp01((float) (((double) inVal - (double) inVec.x) / ((double) inVec.y - (double) inVec.x)));
  }

  public static float GetValueAtPercentage(this Vector2 inVec, float percentage)
  {
    return inVec.x + (inVec.y - inVec.x) * percentage;
  }

  public static float Clamp(this Vector2 inVec, float inVal)
  {
    return Mathf.Clamp(inVal, inVec.x, inVec.y);
  }

  public static Vector3 ToVec3(this Vector2 inVec) => new Vector3(inVec.x, inVec.y, 0.0f);

  public static bool IsWithinThreshold(float value, float compareTo, float threshold)
  {
    return (double) value <= (double) compareTo + (double) threshold && (double) value >= (double) compareTo - (double) threshold;
  }

  public static Texture2D FlipTexture(this Texture2D original)
  {
    Texture2D texture2D = new Texture2D(original.width, original.height);
    int width = original.width;
    int height = original.height;
    for (int x = 0; x < width; ++x)
    {
      for (int y = 0; y < height; ++y)
        texture2D.SetPixel(width - x - 1, y, original.GetPixel(x, y));
    }
    texture2D.Apply();
    return texture2D;
  }

  public static Texture2D ToTexture2D(this Texture texture)
  {
    Texture2D texture2D = new Texture2D(texture.width, texture.height, TextureFormat.RGBA32, false);
    RenderTexture active = RenderTexture.active;
    RenderTexture temporary = RenderTexture.GetTemporary(texture.width, texture.height, 32);
    Graphics.Blit(texture, temporary);
    RenderTexture.active = temporary;
    texture2D.ReadPixels(new Rect(0.0f, 0.0f, (float) temporary.width, (float) temporary.height), 0, 0);
    texture2D.Apply();
    RenderTexture.active = active;
    RenderTexture.ReleaseTemporary(temporary);
    return texture2D;
  }

  public static Vector3 RandomPointInRectTransform(RectTransform rectTransform)
  {
    Rect rect = rectTransform.rect;
    double x1 = (double) rect.x;
    rect = rectTransform.rect;
    double x2 = (double) rect.x;
    rect = rectTransform.rect;
    double width = (double) rect.width;
    double maxInclusive1 = x2 + width;
    double x3 = (double) UnityEngine.Random.Range((float) x1, (float) maxInclusive1);
    rect = rectTransform.rect;
    double y1 = (double) rect.y;
    rect = rectTransform.rect;
    double y2 = (double) rect.y;
    rect = rectTransform.rect;
    double height = (double) rect.height;
    double maxInclusive2 = y2 + height;
    double y3 = (double) UnityEngine.Random.Range((float) y1, (float) maxInclusive2);
    return new Vector3((float) x3, (float) y3, 0.0f);
  }

  public static T RandomEnumValue<T>()
  {
    Array values = Enum.GetValues(typeof (T));
    return (T) values.GetValue(UnityEngine.Random.Range(0, values.Length));
  }

  public static T RandomValueFromList<T>(this List<T> list) => list[UnityEngine.Random.Range(0, list.Count)];

  public static T GetEnumValue<T>(string valueName) => (T) Enum.Parse(typeof (T), valueName);

  public static Vector2 GetCharPosition(this TextMeshPro text, int index)
  {
    text.GetComponent<Transform>();
    Vector3 zero1 = Vector3.zero;
    Vector3 zero2 = Vector3.zero;
    TMP_TextInfo textInfo = text.textInfo;
    if (index < 0 || index >= textInfo.characterInfo.Length)
      return Vector2.zero;
    TMP_CharacterInfo tmpCharacterInfo = textInfo.characterInfo[index];
    return (Vector2) ((tmpCharacterInfo.topLeft + tmpCharacterInfo.topRight + tmpCharacterInfo.bottomLeft + tmpCharacterInfo.bottomRight) / 4f);
  }

  public static bool HasReachedDestination(this NavMeshAgent agent)
  {
    float num = 0.2f;
    return (double) agent.remainingDistance != double.PositiveInfinity && (double) agent.transform.position.PlanarDistance(agent.destination, Axis.Y) < (double) num;
  }

  public static Vector3 GetRandomPointOnNavMesh(this NavMeshAgent agent, float maxWalkDist)
  {
    NavMeshHit hit;
    NavMesh.SamplePosition(UnityEngine.Random.insideUnitSphere * maxWalkDist + agent.transform.position, out hit, maxWalkDist, 1);
    return hit.position;
  }

  public static string SpiltAndCamelCase(this string inString)
  {
    string str = new Regex("\r\n                (?<=[A-Z])(?=[A-Z][a-z]) |\r\n                 (?<=[^A-Z])(?=[A-Z]) |\r\n                 (?<=[A-Za-z])(?=[^A-Za-z])", RegexOptions.IgnorePatternWhitespace).Replace(inString, " ");
    return char.ToUpper(str[0]).ToString() + str.Substring(1);
  }

  public static Vector3 GetSignedVec3(this Vector3 inVector)
  {
    return new Vector3(UtilityScript.GetSignedAngle(inVector.x), UtilityScript.GetSignedAngle(inVector.y), UtilityScript.GetSignedAngle(inVector.z));
  }

  public static bool IsInCameraView(this Camera cam, Vector3 position, float border = 0.0f)
  {
    Vector3 viewportPoint = cam.WorldToViewportPoint(position);
    return (double) viewportPoint.x >= -(double) border && (double) viewportPoint.x <= 1.0 + (double) border && (double) viewportPoint.y >= -(double) border && (double) viewportPoint.y <= 1.0 + (double) border && (double) viewportPoint.z > 0.0;
  }

  public static float GetSignedAngle(float inAngle)
  {
    float signedAngle = inAngle;
    bool flag;
    do
    {
      flag = true;
      if ((double) signedAngle < -180.0)
        signedAngle += 360f;
      else if ((double) inAngle > 180.0)
        signedAngle -= 360f;
    }
    while (!flag);
    return signedAngle;
  }

  public static T RandomValueFromList<T>(this T[] list) => list[UnityEngine.Random.Range(0, list.Length)];

  public static T RandomValueFromList<T>(List<T> listA, List<T> ignoreFromListA)
  {
    List<T> list = listA.Except<T>((IEnumerable<T>) ignoreFromListA).ToList<T>();
    return list[UnityEngine.Random.Range(0, list.Count)];
  }

  public static float RoundToNearestMultiple(this float value, float factor)
  {
    return (float) (int) Math.Round((double) value / (double) factor, MidpointRounding.AwayFromZero) * factor;
  }

  public static float Truncate(this float value, int digits)
  {
    double num = Math.Pow(10.0, (double) digits);
    return (float) (Math.Truncate(num * (double) value) / num);
  }

  public static float PingPong(float timeValue, float minValue, float maxValue)
  {
    return Mathf.PingPong(timeValue, maxValue - minValue) + minValue;
  }

  public static IEnumerator ScaleObject(GameObject gameObj, float aValue, float aTime)
  {
    Vector3 currentScale = gameObj.transform.localScale;
    for (float t = 0.0f; (double) t < 1.0; t += Time.deltaTime / aTime)
    {
      gameObj.transform.localScale = new Vector3(Mathf.Lerp(currentScale.x, aValue, t), Mathf.Lerp(currentScale.x, aValue, t), Mathf.Lerp(currentScale.x, aValue, t));
      yield return (object) null;
    }
  }

  public static GameObject FindObject(this GameObject parent, string name)
  {
    Component[] componentsInChildren = parent.GetComponentsInChildren(typeof (Transform), true);
    Transform[] transformArray = new Transform[componentsInChildren.Length];
    for (int index = 0; index < componentsInChildren.Length; ++index)
      transformArray[index] = componentsInChildren[index].transform;
    foreach (Transform transform in transformArray)
    {
      if (transform.name == name)
        return transform.gameObject;
    }
    return (GameObject) null;
  }

  public static void Update<TSource>(this IEnumerable<TSource> outer, Action<TSource> updator)
  {
    foreach (TSource source in outer)
      updator(source);
  }

  public static bool Approximately(this Quaternion quatA, Quaternion value, float acceptableRange)
  {
    return 1.0 - (double) Mathf.Abs(Quaternion.Dot(quatA, value)) < (double) acceptableRange;
  }

  public static T Next<T>(this T src) where T : struct
  {
    if (!typeof (T).IsEnum)
      throw new ArgumentException(string.Format("Argument {0} is not an Enum", (object) typeof (T).FullName));
    T[] values = (T[]) Enum.GetValues(src.GetType());
    int index = Array.IndexOf<T>(values, src) + 1;
    return values.Length != index ? values[index] : values[0];
  }

  public static Vector3 Multiply(this Vector3 src, Vector3 vector)
  {
    return new Vector3(src.x * vector.x, src.y * vector.y, src.z * vector.z);
  }

  public static Vector3 ToVector3(this Color src) => new Vector3(src.r, src.g, src.b);

  public static Color ToColour(this Vector3 src, float alpha = 1f)
  {
    return new Color(src.x, src.y, src.z, alpha);
  }

  public static Color ColourFromVector3(Vector3 src) => new Color(src.x, src.y, src.z);

  public static void CopyFrom(this Transform toEdit, Transform copyFrom)
  {
    toEdit.transform.parent = copyFrom.parent;
    toEdit.transform.localScale = copyFrom.localScale;
    toEdit.transform.localRotation = copyFrom.localRotation;
    toEdit.transform.localPosition = copyFrom.localPosition;
  }

  public static void CopyFrom(this RectTransform objRectTransform, RectTransform rectTransform)
  {
    objRectTransform.transform.parent = rectTransform.parent;
    objRectTransform.anchorMin = rectTransform.anchorMin;
    objRectTransform.anchorMax = rectTransform.anchorMax;
    objRectTransform.anchoredPosition = rectTransform.anchoredPosition;
    objRectTransform.sizeDelta = rectTransform.sizeDelta;
    objRectTransform.localPosition = rectTransform.localPosition;
  }

  public static Vector3 RotateAround(this Vector3 point, Vector3 pivot, Vector3 angle)
  {
    Vector3 vector3 = point - pivot;
    point = Quaternion.Euler(angle) * vector3 + pivot;
    return point;
  }

  public static Color ScaleToOne(this Color src)
  {
    return new Color((double) src.r > 1.0 ? src.r / 235f : src.r, (double) src.g > 1.0 ? src.g / 235f : src.g, (double) src.b > 1.0 ? src.b / 235f : src.b, (double) src.a > 1.0 ? src.a / 235f : src.a);
  }

  public static string ConvertToString(this char[] charArray)
  {
    string str = "";
    for (int index = 0; index < charArray.Length; ++index)
      str += charArray[index].ToString();
    return str;
  }

  public static void SetLayerRecursively(this GameObject src, int newLayer)
  {
    src.layer = newLayer;
    foreach (Component component in src.transform)
      component.gameObject.SetLayerRecursively(newLayer);
  }

  public static float SignedAngleBetween(Vector3 vector1, Vector3 vector2, Vector3 normal)
  {
    return Vector3.Angle(vector1, vector2) * Mathf.Sign(Vector3.Dot(normal, Vector3.Cross(vector1, vector2)));
  }

  public static float UnsignedAngleBetween(Vector3 vector1, Vector3 vector2, Vector3 normal)
  {
    return (float) (((double) Vector3.Angle(vector1, vector2) * (double) Mathf.Sign(Vector3.Dot(normal, Vector3.Cross(vector1, vector2))) + 180.0) % 360.0);
  }

  public static Vector3 GetDirTowardsPoint(this Vector3 ownPos, Vector3 pointTowards)
  {
    return (pointTowards - ownPos).normalized;
  }

  public static Vector3 GetDirAwayFromPoint(this Vector3 ownPos, Vector3 pointAway)
  {
    return (ownPos - pointAway).normalized;
  }

  public static void Reset(this Transform inTransform)
  {
    inTransform.localPosition = Vector3.zero;
    inTransform.localRotation = Quaternion.identity;
    inTransform.localScale = Vector3.one;
  }

  public static void Reset(this RectTransform rectTransform)
  {
    rectTransform.transform.Reset();
    rectTransform.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Bottom, 0.0f, 0.0f);
    rectTransform.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Top, 0.0f, 0.0f);
    rectTransform.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Left, 0.0f, 0.0f);
    rectTransform.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Right, 0.0f, 0.0f);
  }

  public static T[] RangeSubset<T>(this T[] array, int startIndex, int length)
  {
    T[] destinationArray = new T[length];
    Array.Copy((Array) array, startIndex, (Array) destinationArray, 0, length);
    return destinationArray;
  }

  public static T[] Subset<T>(this T[] array, params int[] indices)
  {
    T[] objArray = new T[indices.Length];
    for (int index = 0; index < indices.Length; ++index)
      objArray[index] = array[indices[index]];
    return objArray;
  }

  public static bool IsValidEmail(string email)
  {
    if (string.IsNullOrWhiteSpace(email))
      return false;
    try
    {
      email = Regex.Replace(email, "(@)(.+)$", (MatchEvaluator) (match =>
      {
        string ascii = new IdnMapping().GetAscii(match.Groups[2].Value);
        return match.Groups[1].Value + ascii;
      }), RegexOptions.None, TimeSpan.FromMilliseconds(200.0));
    }
    catch (RegexMatchTimeoutException ex)
    {
      return false;
    }
    catch (ArgumentException ex)
    {
      return false;
    }
    try
    {
      return Regex.IsMatch(email, "^(?(\")(\".+?(?<!\\\\)\"@)|(([0-9a-z]((\\.(?!\\.))|[-!#\\$%&'\\*\\+/=\\?\\^`\\{\\}\\|~\\w])*)(?<=[0-9a-z])@))(?(\\[)(\\[(\\d{1,3}\\.){3}\\d{1,3}\\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\\.)+[a-z0-9][\\-a-z0-9]{0,22}[a-z0-9]))$", RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250.0));
    }
    catch (RegexMatchTimeoutException ex)
    {
      return false;
    }
  }

  [CompilerGenerated]
  public static string \u003CIsValidEmail\u003Eg__DomainMapper\u007C84_0(Match match)
  {
    string ascii = new IdnMapping().GetAscii(match.Groups[2].Value);
    return match.Groups[1].Value + ascii;
  }
}
