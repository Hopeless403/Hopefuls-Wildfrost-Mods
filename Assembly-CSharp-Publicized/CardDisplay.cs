// Decompiled with JetBrains decompiler
// Type: CardDisplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

public class CardDisplay : MonoBehaviour
{
  [SerializeField]
  public CardData data;
  public Card _card;

  public Card card => this._card ?? (this._card = this.GetComponent<Card>());

  public void Awake() => this.transform.localScale = Vector3.zero;

  public IEnumerator Start()
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
