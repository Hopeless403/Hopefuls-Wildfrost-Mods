// Decompiled with JetBrains decompiler
// Type: CancelCardDragSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
public class CancelCardDragSystem : GameSystem
{
  [SerializeField]
  public string input = "Back";

  public void Update()
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
