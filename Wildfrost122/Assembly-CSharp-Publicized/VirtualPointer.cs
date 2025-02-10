// Decompiled with JetBrains decompiler
// Type: VirtualPointer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

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
