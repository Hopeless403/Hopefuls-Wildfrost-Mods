// Decompiled with JetBrains decompiler
// Type: TurnOrderDisplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TurnOrderDisplay : MonoBehaviour
{
  [SerializeField]
  private Transform group;
  [SerializeField]
  private TurnOrderNumber prefab;
  [SerializeField]
  private CanvasGroup vignette;
  [SerializeField]
  private float musicPitch = 0.9f;
  private bool active;
  private readonly List<TurnOrderNumber> numbers = new List<TurnOrderNumber>();

  public void Toggle()
  {
    if (this.active)
      this.Clear();
    else
      this.Display();
  }

  private void Display()
  {
    if (this.active)
      return;
    int num = 1;
    foreach (Entity entity in Battle.GetCardsOnBoard(References.Battle.enemy))
    {
      if (entity.data.counter > 0)
        this.CreateNumber(entity, num++);
    }
    foreach (Entity entity in Battle.GetCardsOnBoard(References.Battle.player))
    {
      if (entity.data.counter > 0)
        this.CreateNumber(entity, num++);
    }
    this.active = true;
    global::Events.OnEntitySelect += new UnityAction<Entity>(this.EntitySelect);
    global::Events.OnRedrawBellHit += new UnityAction<RedrawBellSystem>(this.RedrawBellHit);
    global::Events.OnDeckpackOpen += new UnityAction(this.DeckpackOpen);
    global::Events.OnInspect += new UnityAction<Entity>(this.Inspect);
    TurnOrderDisplay.OpenEye();
    this.vignette.gameObject.SetActive(true);
    this.vignette.alpha = 0.0f;
    LeanTween.cancel(this.vignette.gameObject);
    LeanTween.alphaCanvas(this.vignette, 1f, 1f).setEaseOutQuart();
    Object.FindObjectOfType<BattleMusicSystem>()?.FadePitchTo(this.musicPitch);
  }

  private void Clear()
  {
    if (!this.active)
      return;
    foreach (TurnOrderNumber number in this.numbers)
    {
      if ((bool) (Object) number)
        number.gameObject.Destroy();
    }
    this.numbers.Clear();
    this.active = false;
    global::Events.OnEntitySelect -= new UnityAction<Entity>(this.EntitySelect);
    global::Events.OnRedrawBellHit -= new UnityAction<RedrawBellSystem>(this.RedrawBellHit);
    global::Events.OnDeckpackOpen -= new UnityAction(this.DeckpackOpen);
    global::Events.OnInspect -= new UnityAction<Entity>(this.Inspect);
    TurnOrderDisplay.CloseEye();
    if ((bool) (Object) this.vignette)
      this.vignette.gameObject.SetActive(false);
    Object.FindObjectOfType<BattleMusicSystem>()?.FadePitchTo(1f);
  }

  private static void OpenEye() => Object.FindObjectOfType<TurnOrderButton>()?.OpenEye();

  private static void CloseEye() => Object.FindObjectOfType<TurnOrderButton>()?.CloseEye();

  private void CreateNumber(Entity entity, int number)
  {
    TurnOrderNumber turnOrderNumber = Object.Instantiate<TurnOrderNumber>(this.prefab, entity.GetContainerWorldPosition(), Quaternion.identity, this.group);
    turnOrderNumber.Set(entity, number);
    this.numbers.Add(turnOrderNumber);
  }

  private void EntitySelect(Entity entity) => this.Clear();

  private void RedrawBellHit(RedrawBellSystem redrawBell) => this.Clear();

  private void DeckpackOpen() => this.Clear();

  private void Inspect(Entity entity) => this.Clear();
}
