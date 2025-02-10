// Decompiled with JetBrains decompiler
// Type: VirtualPointer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

#nullable disable
public class VirtualPointer : MonoBehaviourSingleton<VirtualPointer>
{
  public static void Hide()
  {
    if (MonoBehaviourSingleton<Cursor3d>.instance.usingMouse)
      return;
    MonoBehaviourSingleton<VirtualPointer>.instance.gameObject.SetActive(false);
  }

  public static void Show()
  {
    if (MonoBehaviourSingleton<Cursor3d>.instance.usingMouse)
      return;
    MonoBehaviourSingleton<VirtualPointer>.instance.gameObject.SetActive(true);
  }
}
