﻿// Decompiled with JetBrains decompiler
// Type: Deadpan.Enums.Engine.Components.Modding.InternalMod
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

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
