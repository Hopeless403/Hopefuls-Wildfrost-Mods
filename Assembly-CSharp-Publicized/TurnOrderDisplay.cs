// Decompiled with JetBrains decompiler
// Type: TurnOrderDisplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TurnOrderDisplay : MonoBehaviour
{
  [SerializeField]
  public Transform group;
  [SerializeField]
  public TurnOrderNumber prefab;
  [SerializeField]
  public CanvasGroup vignette;
  [SerializeField]
  public float musicPitch = 0.9f;
  public bool active;
  public readonly List<TurnOrderNumber> numbers = new List<TurnOrderNumber>();

  public void Toggle()
  {
    if (this.active)
      this.Clear();
    else
      this.Display();
  }

  public void Display()
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

  public void Clear()
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

  public static void OpenEye() => Object.FindObjectOfType<TurnOrderButton>()?.OpenEye();

  public static void CloseEye() => Object.FindObjectOfType<TurnOrderButton>()?.CloseEye();

  public void CreateNumber(Entity entity, int number)
  {
    TurnOrderNumber turnOrderNumber = Object.Instantiate<TurnOrderNumber>(this.prefab, entity.GetContainerWorldPosition(), Quaternion.identity, this.group);
    turnOrderNumber.Set(entity, number);
    this.numbers.Add(turnOrderNumber);
  }

  public void EntitySelect(Entity entity) => this.Clear();

  public void RedrawBellHit(RedrawBellSystem redrawBell) => this.Clear();

  public void DeckpackOpen() => this.Clear();

  public void Inspect(Entity entity) => this.Clear();
}
