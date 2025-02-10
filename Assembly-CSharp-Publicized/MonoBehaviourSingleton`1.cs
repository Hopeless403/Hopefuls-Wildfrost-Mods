// Decompiled with JetBrains decompiler
// Type: MonoBehaviourSingleton`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Runtime.CompilerServices;
using UnityEngine;

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
