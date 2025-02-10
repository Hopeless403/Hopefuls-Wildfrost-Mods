// Decompiled with JetBrains decompiler
// Type: DeckpackBlocker
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class DeckpackBlocker : MonoBehaviour
{
  private static uint open;

  private void OnEnable() => DeckpackBlocker.Block();

  private void OnDisable() => DeckpackBlocker.Unblock();

  public static void Block()
  {
    if (DeckpackBlocker.open++ != 0U)
      return;
    DeckpackBlocker.SetButtonsInteractable(false);
    InputSystem.reset = true;
  }

  public static void Unblock()
  {
    if (--DeckpackBlocker.open != 0U)
      return;
    DeckpackBlocker.SetButtonsInteractable(true);
    InputSystem.reset = true;
  }

  private static void SetButtonsInteractable(bool interactable)
  {
    foreach (GameObject gameObject in GameObject.FindGameObjectsWithTag("Deckpack Interaction"))
    {
      Selectable component = gameObject.GetComponent<Selectable>();
      if (component != null)
        component.interactable = interactable;
    }
  }
}
