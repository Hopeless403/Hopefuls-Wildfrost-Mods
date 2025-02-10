// Decompiled with JetBrains decompiler
// Type: DeckpackBlocker
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class DeckpackBlocker : MonoBehaviour
{
  public static uint open;

  public void OnEnable() => DeckpackBlocker.Block();

  public void OnDisable() => DeckpackBlocker.Unblock();

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

  public static void SetButtonsInteractable(bool interactable)
  {
    foreach (GameObject gameObject in GameObject.FindGameObjectsWithTag("Deckpack Interaction"))
    {
      Selectable component = gameObject.GetComponent<Selectable>();
      if (component != null)
        component.interactable = interactable;
    }
  }
}
