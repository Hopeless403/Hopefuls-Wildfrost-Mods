// Decompiled with JetBrains decompiler
// Type: CancelCardDragSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

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
