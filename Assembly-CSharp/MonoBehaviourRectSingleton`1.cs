// Decompiled with JetBrains decompiler
// Type: MonoBehaviourRectSingleton`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

public class MonoBehaviourRectSingleton<T> : MonoBehaviour where T : MonoBehaviour
{
  private static T _instance;
  private RectTransform _rectTransform;

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
