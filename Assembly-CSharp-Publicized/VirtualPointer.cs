// Decompiled with JetBrains decompiler
// Type: VirtualPointer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

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
