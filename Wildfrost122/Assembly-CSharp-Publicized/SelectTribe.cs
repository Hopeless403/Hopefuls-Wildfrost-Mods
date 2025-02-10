// Decompiled with JetBrains decompiler
// Type: SelectTribe
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using Dead;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class SelectTribe : MonoBehaviour
{
  [SerializeField]
  public TribeFlagDisplay tribeFlagPrefab;
  [SerializeField]
  public Transform tribeFlagGroup;
  [SerializeField]
  public SelectLeader leaderSelection;
  [SerializeField]
  public Transform selectedFlagAnchor;
  [SerializeField]
  public TitleSetter titleSetter;
  [SerializeField]
  public ParticleSystem selectParticleSystem;
  public readonly List<TribeFlagDisplay> flags = new List<TribeFlagDisplay>();
  public readonly List<ClassData> tribes = new List<ClassData>();

  public void SetAvailableTribes(List<ClassData> tribes)
  {
    this.tribes.Clear();
    this.tribes.AddRange((IEnumerable<ClassData>) tribes);
  }

  public void Run()
  {
    this.titleSetter.Set();
    foreach (ClassData tribe1 in this.tribes)
    {
      ClassData tribe = tribe1;
      TribeFlagDisplay flag = Object.Instantiate<TribeFlagDisplay>(this.tribeFlagPrefab, this.tribeFlagGroup);
      flag.SetAvailable();
      flag.SetUnlocked();
      flag.SetFlagSprite(tribe.flag);
      flag.AddPressAction((UnityAction) (() => this.StartSelectRoutine(flag, tribe)));
      this.flags.Add(flag);
    }
    this.selectedFlagAnchor.DestroyAllChildren();
  }

  public void RevealAnimation()
  {
    foreach (TribeFlagDisplay flag in this.flags)
    {
      Transform transform = flag.flagImage.transform;
      if (transform != null)
      {
        transform.localRotation = Quaternion.Euler(0.0f, 0.0f, PettyRandom.Range(-15f, -5f));
        LeanTween.cancel(transform.gameObject);
        LeanTween.rotateLocal(transform.gameObject, Vector3.zero, PettyRandom.Range(1f, 1.5f)).setEaseOutElastic();
        LeanTween.moveLocal(transform.gameObject, Vector3.zero, PettyRandom.Range(0.25f, 0.35f)).setFrom(Vector3.up * PettyRandom.Range(1f, 2f)).setEaseOutQuart();
      }
    }
  }

  public void StartSelectRoutine(TribeFlagDisplay flag, ClassData classData)
  {
    Routine routine = new Routine(this.SelectRoutine(flag, classData));
  }

  public IEnumerator SelectRoutine(TribeFlagDisplay flag, ClassData classData)
  {
    this.selectParticleSystem.transform.position = Cursor3d.PositionWithZ;
    this.selectParticleSystem.Play();
    if (!classData.selectSfxEvent.IsNull)
      SfxSystem.OneShot(classData.selectSfxEvent);
    flag.transform.SetParent(this.selectedFlagAnchor);
    this.tribeFlagGroup.DestroyAllChildren();
    this.flags.Clear();
    flag.ClearPressActions();
    flag.SetInteractable(false);
    this.tribes.Clear();
    this.tribes.Add(classData);
    flag.transform.localPosition = Vector3.up * 3f;
    LeanTween.cancel(flag.gameObject);
    LeanTween.moveLocal(flag.gameObject, Vector3.zero, PettyRandom.Range(0.2f, 0.3f)).setEaseOutQuart();
    Transform transform = flag.flagImage.transform;
    if (transform != null)
    {
      transform.localRotation = Quaternion.Euler(0.0f, 0.0f, PettyRandom.Range(10f, 15f));
      LeanTween.cancel(transform.gameObject);
      LeanTween.rotateLocal(transform.gameObject, Vector3.zero, PettyRandom.Range(1f, 1.5f)).setEaseOutElastic();
    }
    this.leaderSelection.Run(this.tribes);
    yield return (object) this.leaderSelection.GenerateLeaders(true);
    this.leaderSelection.FlipUpLeaders();
  }
}
