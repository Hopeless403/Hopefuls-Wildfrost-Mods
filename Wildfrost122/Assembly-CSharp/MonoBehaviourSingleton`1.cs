// Decompiled with JetBrains decompiler
// Type: MonoBehaviourSingleton`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
public class MonoBehaviourSingleton<T> : MonoBehaviour where T : MonoBehaviour
{
  public static T instance { get; private set; }

  protected virtual void Awake()
  {
    MonoBehaviourSingleton<T>.instance = this as T;
    Debug.Log((object) string.Format("Singleton<{0}> Created", (object) typeof (T)));
  }
}
