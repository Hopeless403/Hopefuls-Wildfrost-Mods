// Decompiled with JetBrains decompiler
// Type: MonoBehaviourRectSingleton`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
public class MonoBehaviourRectSingleton<T> : MonoBehaviour where T : MonoBehaviour
{
  public static T _instance;
  public RectTransform _rectTransform;

  public static T instance
  {
    get
    {
      if ((Object) MonoBehaviourRectSingleton<T>._instance == (Object) null)
        MonoBehaviourRectSingleton<T>._instance = Object.FindObjectOfType<T>();
      return MonoBehaviourRectSingleton<T>._instance;
    }
  }

  public RectTransform rectTransform
  {
    get
    {
      if ((Object) this._rectTransform == (Object) null)
        this._rectTransform = (RectTransform) this.transform;
      return this._rectTransform;
    }
  }
}
