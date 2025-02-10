// Decompiled with JetBrains decompiler
// Type: VirtualPointer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

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
