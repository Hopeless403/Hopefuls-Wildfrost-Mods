// Decompiled with JetBrains decompiler
// Type: LeanSmooth
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
public class LeanSmooth
{
  public static float damp(
    float current,
    float target,
    ref float currentVelocity,
    float smoothTime,
    float maxSpeed = -1f,
    float deltaTime = -1f)
  {
    if ((double) deltaTime < 0.0)
      deltaTime = Time.deltaTime;
    smoothTime = Mathf.Max(0.0001f, smoothTime);
    float num1 = 2f / smoothTime;
    float num2 = num1 * deltaTime;
    float num3 = (float) (1.0 / (1.0 + (double) num2 + 0.47999998927116394 * (double) num2 * (double) num2 + 0.23499999940395355 * (double) num2 * (double) num2 * (double) num2));
    float num4 = current - target;
    float num5 = target;
    if ((double) maxSpeed > 0.0)
    {
      float max = maxSpeed * smoothTime;
      num4 = Mathf.Clamp(num4, -max, max);
    }
    target = current - num4;
    float num6 = (currentVelocity + num1 * num4) * deltaTime;
    currentVelocity = (currentVelocity - num1 * num6) * num3;
    float num7 = target + (num4 + num6) * num3;
    if ((double) num5 - (double) current > 0.0 == (double) num7 > (double) num5)
    {
      num7 = num5;
      currentVelocity = (num7 - num5) / deltaTime;
    }
    return num7;
  }

  public static Vector3 damp(
    Vector3 current,
    Vector3 target,
    ref Vector3 currentVelocity,
    float smoothTime,
    float maxSpeed = -1f,
    float deltaTime = -1f)
  {
    double x = (double) LeanSmooth.damp(current.x, target.x, ref currentVelocity.x, smoothTime, maxSpeed, deltaTime);
    float num1 = LeanSmooth.damp(current.y, target.y, ref currentVelocity.y, smoothTime, maxSpeed, deltaTime);
    float num2 = LeanSmooth.damp(current.z, target.z, ref currentVelocity.z, smoothTime, maxSpeed, deltaTime);
    double y = (double) num1;
    double z = (double) num2;
    return new Vector3((float) x, (float) y, (float) z);
  }

  public static Color damp(
    Color current,
    Color target,
    ref Color currentVelocity,
    float smoothTime,
    float maxSpeed = -1f,
    float deltaTime = -1f)
  {
    double r = (double) LeanSmooth.damp(current.r, target.r, ref currentVelocity.r, smoothTime, maxSpeed, deltaTime);
    float num1 = LeanSmooth.damp(current.g, target.g, ref currentVelocity.g, smoothTime, maxSpeed, deltaTime);
    float num2 = LeanSmooth.damp(current.b, target.b, ref currentVelocity.b, smoothTime, maxSpeed, deltaTime);
    float num3 = LeanSmooth.damp(current.a, target.a, ref currentVelocity.a, smoothTime, maxSpeed, deltaTime);
    double g = (double) num1;
    double b = (double) num2;
    double a = (double) num3;
    return new Color((float) r, (float) g, (float) b, (float) a);
  }

  public static float spring(
    float current,
    float target,
    ref float currentVelocity,
    float smoothTime,
    float maxSpeed = -1f,
    float deltaTime = -1f,
    float friction = 2f,
    float accelRate = 0.5f)
  {
    if ((double) deltaTime < 0.0)
      deltaTime = Time.deltaTime;
    float num = target - current;
    currentVelocity += deltaTime / smoothTime * accelRate * num;
    currentVelocity *= (float) (1.0 - (double) deltaTime * (double) friction);
    if ((double) maxSpeed > 0.0 && (double) maxSpeed < (double) Mathf.Abs(currentVelocity))
      currentVelocity = maxSpeed * Mathf.Sign(currentVelocity);
    return current + currentVelocity;
  }

  public static Vector3 spring(
    Vector3 current,
    Vector3 target,
    ref Vector3 currentVelocity,
    float smoothTime,
    float maxSpeed = -1f,
    float deltaTime = -1f,
    float friction = 2f,
    float accelRate = 0.5f)
  {
    double x = (double) LeanSmooth.spring(current.x, target.x, ref currentVelocity.x, smoothTime, maxSpeed, deltaTime, friction, accelRate);
    float num1 = LeanSmooth.spring(current.y, target.y, ref currentVelocity.y, smoothTime, maxSpeed, deltaTime, friction, accelRate);
    float num2 = LeanSmooth.spring(current.z, target.z, ref currentVelocity.z, smoothTime, maxSpeed, deltaTime, friction, accelRate);
    double y = (double) num1;
    double z = (double) num2;
    return new Vector3((float) x, (float) y, (float) z);
  }

  public static Color spring(
    Color current,
    Color target,
    ref Color currentVelocity,
    float smoothTime,
    float maxSpeed = -1f,
    float deltaTime = -1f,
    float friction = 2f,
    float accelRate = 0.5f)
  {
    double r = (double) LeanSmooth.spring(current.r, target.r, ref currentVelocity.r, smoothTime, maxSpeed, deltaTime, friction, accelRate);
    float num1 = LeanSmooth.spring(current.g, target.g, ref currentVelocity.g, smoothTime, maxSpeed, deltaTime, friction, accelRate);
    float num2 = LeanSmooth.spring(current.b, target.b, ref currentVelocity.b, smoothTime, maxSpeed, deltaTime, friction, accelRate);
    float num3 = LeanSmooth.spring(current.a, target.a, ref currentVelocity.a, smoothTime, maxSpeed, deltaTime, friction, accelRate);
    double g = (double) num1;
    double b = (double) num2;
    double a = (double) num3;
    return new Color((float) r, (float) g, (float) b, (float) a);
  }

  public static float linear(float current, float target, float moveSpeed, float deltaTime = -1f)
  {
    if ((double) deltaTime < 0.0)
      deltaTime = Time.deltaTime;
    bool flag = (double) target > (double) current;
    float num1 = (float) ((double) deltaTime * (double) moveSpeed * (flag ? 1.0 : -1.0));
    float num2 = current + num1;
    float num3 = num2 - target;
    return flag && (double) num3 > 0.0 || !flag && (double) num3 < 0.0 ? target : num2;
  }

  public static Vector3 linear(Vector3 current, Vector3 target, float moveSpeed, float deltaTime = -1f)
  {
    double x = (double) LeanSmooth.linear(current.x, target.x, moveSpeed, deltaTime);
    float num1 = LeanSmooth.linear(current.y, target.y, moveSpeed, deltaTime);
    float num2 = LeanSmooth.linear(current.z, target.z, moveSpeed, deltaTime);
    double y = (double) num1;
    double z = (double) num2;
    return new Vector3((float) x, (float) y, (float) z);
  }

  public static Color linear(Color current, Color target, float moveSpeed)
  {
    double r = (double) LeanSmooth.linear(current.r, target.r, moveSpeed);
    float num1 = LeanSmooth.linear(current.g, target.g, moveSpeed);
    float num2 = LeanSmooth.linear(current.b, target.b, moveSpeed);
    float num3 = LeanSmooth.linear(current.a, target.a, moveSpeed);
    double g = (double) num1;
    double b = (double) num2;
    double a = (double) num3;
    return new Color((float) r, (float) g, (float) b, (float) a);
  }

  public static float bounceOut(
    float current,
    float target,
    ref float currentVelocity,
    float smoothTime,
    float maxSpeed = -1f,
    float deltaTime = -1f,
    float friction = 2f,
    float accelRate = 0.5f,
    float hitDamping = 0.9f)
  {
    if ((double) deltaTime < 0.0)
      deltaTime = Time.deltaTime;
    float num1 = target - current;
    currentVelocity += deltaTime / smoothTime * accelRate * num1;
    currentVelocity *= (float) (1.0 - (double) deltaTime * (double) friction);
    if ((double) maxSpeed > 0.0 && (double) maxSpeed < (double) Mathf.Abs(currentVelocity))
      currentVelocity = maxSpeed * Mathf.Sign(currentVelocity);
    float num2 = current + currentVelocity;
    bool flag = (double) target > (double) current;
    float num3 = num2 - target;
    if (flag && (double) num3 > 0.0 || !flag && (double) num3 < 0.0)
    {
      currentVelocity = -currentVelocity * hitDamping;
      num2 = current + currentVelocity;
    }
    return num2;
  }

  public static Vector3 bounceOut(
    Vector3 current,
    Vector3 target,
    ref Vector3 currentVelocity,
    float smoothTime,
    float maxSpeed = -1f,
    float deltaTime = -1f,
    float friction = 2f,
    float accelRate = 0.5f,
    float hitDamping = 0.9f)
  {
    double x = (double) LeanSmooth.bounceOut(current.x, target.x, ref currentVelocity.x, smoothTime, maxSpeed, deltaTime, friction, accelRate, hitDamping);
    float num1 = LeanSmooth.bounceOut(current.y, target.y, ref currentVelocity.y, smoothTime, maxSpeed, deltaTime, friction, accelRate, hitDamping);
    float num2 = LeanSmooth.bounceOut(current.z, target.z, ref currentVelocity.z, smoothTime, maxSpeed, deltaTime, friction, accelRate, hitDamping);
    double y = (double) num1;
    double z = (double) num2;
    return new Vector3((float) x, (float) y, (float) z);
  }

  public static Color bounceOut(
    Color current,
    Color target,
    ref Color currentVelocity,
    float smoothTime,
    float maxSpeed = -1f,
    float deltaTime = -1f,
    float friction = 2f,
    float accelRate = 0.5f,
    float hitDamping = 0.9f)
  {
    double r = (double) LeanSmooth.bounceOut(current.r, target.r, ref currentVelocity.r, smoothTime, maxSpeed, deltaTime, friction, accelRate, hitDamping);
    float num1 = LeanSmooth.bounceOut(current.g, target.g, ref currentVelocity.g, smoothTime, maxSpeed, deltaTime, friction, accelRate, hitDamping);
    float num2 = LeanSmooth.bounceOut(current.b, target.b, ref currentVelocity.b, smoothTime, maxSpeed, deltaTime, friction, accelRate, hitDamping);
    float num3 = LeanSmooth.bounceOut(current.a, target.a, ref currentVelocity.a, smoothTime, maxSpeed, deltaTime, friction, accelRate, hitDamping);
    double g = (double) num1;
    double b = (double) num2;
    double a = (double) num3;
    return new Color((float) r, (float) g, (float) b, (float) a);
  }
}
