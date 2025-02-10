// Decompiled with JetBrains decompiler
// Type: CancelCardDragSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
public class CancelCardDragSystem : GameSystem
{
  [SerializeField]
  private string input = "Back";

  private void Update()
  {
    if (InputSystem.Enabled && !InputSystem.reset && !InputSystem.IsButtonPressed("Back"))
      return;
    foreach (CardController cardController in Object.FindObjectsOfType<CardController>())
    {
      if ((bool) (Object) cardController.dragging)
        cardController.DragCancel();
    }
  }
}
