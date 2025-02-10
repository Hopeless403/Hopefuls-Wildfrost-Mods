// Decompiled with JetBrains decompiler
// Type: MonoBehaviourSingleton`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Runtime.CompilerServices;
using UnityEngine;

#nullable disable
public class MonoBehaviourSingleton<T> : MonoBehaviour where T : MonoBehaviour
{
  [CompilerGenerated]
  public static T \u003Cinstance\u003Ek__BackingField;

  public static T instance
  {
    get => MonoBehaviourSingleton<T>.\u003Cinstance\u003Ek__BackingField;
    set => MonoBehaviourSingleton<T>.\u003Cinstance\u003Ek__BackingField = value;
  }

  public virtual void Awake()
  {
    MonoBehaviourSingleton<T>.instance = this as T;
    Debug.Log((object) string.Format("Singleton<{0}> Created", (object) typeof (T)));
  }
}
