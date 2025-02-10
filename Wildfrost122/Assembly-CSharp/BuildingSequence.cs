// Decompiled with JetBrains decompiler
// Type: BuildingSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using Dead;
using FMODUnity;
using NaughtyAttributes;
using System.Collections;
using UnityEngine;

#nullable disable
public class BuildingSequence : MonoBehaviour
{
  [ReadOnly]
  public Building building;
  [SerializeField]
  private Talker talker;
  [SerializeField]
  private EventReference enterSfxEvent;

  protected virtual IEnumerator Sequence()
  {
    yield return (object) null;
  }

  protected void TalkerGreet() => this.TalkerSay("greet", PettyRandom.Range(0.25f, 0.5f));

  protected void TalkerFirstGreet() => this.TalkerSay("firstGreet", 0.5f);

  protected void TalkerNewCard(CardData cardData)
  {
    this.TalkerSay("new card", 0.5f, (object) cardData.title);
  }

  protected void TalkerSay(string speechType, float delay, params object[] inserts)
  {
    if (!(bool) (Object) this.talker)
      return;
    this.talker.Say(speechType, delay, inserts);
  }

  public void Play(Building building)
  {
    if (!this.enterSfxEvent.IsNull)
      SfxSystem.OneShot(this.enterSfxEvent);
    this.building = building;
    this.StartCoroutine(this.Sequence());
  }

  public void Close()
  {
    this.StopAllCoroutines();
    Object.FindObjectOfType<BuildingDisplay>(true)?.End();
  }
}
