// Decompiled with JetBrains decompiler
// Type: Delta
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

public static class Delta
{
  public static readonly float targetFps = 60f;

  public static float Multiply(float current, float multiply, float delta) => current * Mathf.Pow(multiply, delta * Delta.targetFps);

  public static Vector2 Multiply(Vector2 current, float multiply, float delta) => current * Mathf.Pow(multiply, delta * Delta.targetFps);

  public static Vector2 Multiply(Vector2 current, Vector3 multiply, float delta)
  {
    float p = delta * Delta.targetFps;
    return new Vector2(current.x * Mathf.Pow(multiply.x, p), current.y * Mathf.Pow(multiply.y, p));
  }

  public static Vector3 Multiply(Vector3 current, float multiply, float delta) => current * Mathf.Pow(multiply, delta * Delta.targetFps);

  public static Vector3 Multiply(Vector3 current, Vector3 multiply, float delta)
  {
    float p = delta * Delta.targetFps;
    double x = (double) current.x * (double) Mathf.Pow(multiply.x, p);
    float num1 = current.y * Mathf.Pow(multiply.y, p);
    float num2 = current.z * Mathf.Pow(multiply.z, p);
    double y = (double) num1;
    double z = (double) num2;
    return new Vector3((float) x, (float) y, (float) z);
  }

  public static float Lerp(float current, float target, float amount, float delta) => Mathf.Lerp(current, target, 1f - Mathf.Pow(1f - amount, delta * Delta.targetFps));

  public static Vector2 Lerp(Vector2 current, Vector2 target, float amount, float delta) => Vector2.Lerp(current, target, 1f - Mathf.Pow(1f - amount, delta * Delta.targetFps));

  public static Vector3 Lerp(Vector3 current, Vector3 target, float amount, float delta) => Vector3.Lerp(current, target, 1f - Mathf.Pow(1f - amount, delta * Delta.targetFps));

  public static Quaternion Lerp(Quaternion current, Quaternion target, float amount, float delta) => Quaternion.Lerp(current, target, 1f - Mathf.Pow(1f - amount, delta * Delta.targetFps));

  public static Vector3 LerpAngle(Vector3 current, Vector3 target, float amount, float delta)
  {
    float t = 1f - Mathf.Pow(1f - amount, delta * Delta.targetFps);
    double x = (double) Mathf.LerpAngle(current.x, target.x, t);
    float num1 = Mathf.LerpAngle(current.y, target.y, t);
    float num2 = Mathf.LerpAngle(current.z, target.z, t);
    double y = (double) num1;
    double z = (double) num2;
    return new Vector3((float) x, (float) y, (float) z);
  }
}
