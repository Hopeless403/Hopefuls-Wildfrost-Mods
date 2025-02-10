// Decompiled with JetBrains decompiler
// Type: CharacterExt
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
public static class CharacterExt
{
  public static void OrderNextCards(this Character character, string[] nextCardNames)
  {
    CardContainer drawContainer = character.drawContainer;
    List<Entity> entityList = new List<Entity>();
    foreach (string nextCardName in nextCardNames)
    {
      string cardName = nextCardName;
      Entity entity = drawContainer.FirstOrDefault<Entity>((Func<Entity, bool>) (a => a.name == cardName));
      if ((UnityEngine.Object) entity != (UnityEngine.Object) null)
      {
        entityList.Insert(0, entity);
        drawContainer.Remove(entity);
      }
    }
    foreach (Entity entity in entityList)
      drawContainer.Add(entity);
    drawContainer.TweenChildPositions();
  }
}
