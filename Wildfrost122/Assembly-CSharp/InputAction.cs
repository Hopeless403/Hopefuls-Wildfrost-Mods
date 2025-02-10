// Decompiled with JetBrains decompiler
// Type: InputAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

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
