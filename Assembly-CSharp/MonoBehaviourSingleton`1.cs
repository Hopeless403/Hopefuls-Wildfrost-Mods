// Decompiled with JetBrains decompiler
// Type: MonoBehaviourSingleton`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

public class MonoBehaviourSingleton<T> : MonoBehaviour where T : MonoBehaviour
{
  public static T instance { get; private set; }

  protected virtual void Awake()
  {
    MonoBehaviourSingleton<T>.instance = this as T;
    Debug.Log((object) string.Format("Singleton<{0}> Created", (object) typeof (T)));
  }
}
