// Decompiled with JetBrains decompiler
// Type: Deadpan.Enums.Engine.Components.Modding.InternalMod
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

#nullable disable
namespace Deadpan.Enums.Engine.Components.Modding
{
  internal class InternalMod : WildfrostMod
  {
    internal InternalMod(string modDirectory)
      : base(modDirectory)
    {
    }

    public override string GUID => "wildfrost";

    public override string[] Depends => new string[0];

    public override string Title => "wildfrost";

    public override string Description => "wildfrost";
  }
}
