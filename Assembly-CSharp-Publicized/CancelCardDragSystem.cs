// Decompiled with JetBrains decompiler
// Type: CancelCardDragSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

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
