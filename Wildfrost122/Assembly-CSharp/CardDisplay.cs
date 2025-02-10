// Decompiled with JetBrains decompiler
// Type: CardDisplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

#nullable disable
public class CardDisplay : MonoBehaviour
{
  [SerializeField]
  private CardData data;
  private Card _card;

  private Card card => this._card ?? (this._card = this.GetComponent<Card>());

  private void Awake() => this.transform.localScale = Vector3.zero;

  private IEnumerator Start()
  {
    // ISSUE: reference to a compiler-generated field
    int num = this.\u003C\u003E1__state;
    CardDisplay cardDisplay = this;
    if (num != 0)
    {
      if (num != 1)
        return false;
      // ISSUE: reference to a compiler-generated field
      this.\u003C\u003E1__state = -1;
      LeanTween.scale(cardDisplay.gameObject, Vector3.one, 0.3f).setEaseOutBack();
      return false;
    }
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = -1;
    cardDisplay.card.entity.data = cardDisplay.data;
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E2__current = (object) cardDisplay.card.UpdateData(false);
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = 1;
    return true;
  }
}
