// Decompiled with JetBrains decompiler
// Type: WhenEnabled
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class WhenEnabled : MonoBehaviour
{
  [SerializeField]
  public UnityEvent action;

  public void OnEnable() => this.action?.Invoke();
}
