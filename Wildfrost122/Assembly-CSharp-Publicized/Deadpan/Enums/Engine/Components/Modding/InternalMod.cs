// Decompiled with JetBrains decompiler
// Type: Deadpan.Enums.Engine.Components.Modding.InternalMod
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

#nullable disable
namespace Deadpan.Enums.Engine.Components.Modding
{
  public class InternalMod : WildfrostMod
  {
    public InternalMod(string modDirectory)
      : base(modDirectory)
    {
    }

    public override string GUID => "wildfrost";

    public override string[] Depends => new string[0];

    public override string Title => "wildfrost";

    public override string Description => "wildfrost";
  }
}
