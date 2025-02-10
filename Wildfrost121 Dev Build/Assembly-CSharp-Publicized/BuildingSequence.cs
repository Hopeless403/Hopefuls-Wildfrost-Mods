// Decompiled with JetBrains decompiler
// Type: BuildingSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

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
  public Talker talker;
  [SerializeField]
  public EventReference enterSfxEvent;

  public virtual IEnumerator Sequence()
  {
    yield return (object) null;
  }

  public void TalkerGreet() => this.TalkerSay("greet", PettyRandom.Range(0.25f, 0.5f));

  public void TalkerFirstGreet() => this.TalkerSay("firstGreet", 0.5f);

  public void TalkerNewCard(CardData cardData)
  {
    this.TalkerSay("new card", 0.5f, (object) cardData.title);
  }

  public void TalkerSay(string speechType, float delay, params object[] inserts)
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
