// Decompiled with JetBrains decompiler
// Type: InputAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class InputAction : MonoBehaviour
{
  public UnityEvent action;

  public void Run()
  {
    if (!InputSystem.Enabled)
      return;
    this.action?.Invoke();
  }
}
