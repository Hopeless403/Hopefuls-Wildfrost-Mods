// Decompiled with JetBrains decompiler
// Type: MonoBehaviourRectSingleton`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
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
